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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IAMRolesAnywhere.Model;

namespace Amazon.IAMRolesAnywhere
{
    /// <summary>
    /// Interface for accessing IAMRolesAnywhere
    ///
    /// AWS Identity and Access Management Roles Anywhere provides a secure way for your workloads
    /// such as servers, containers, and applications running outside of AWS to obtain Temporary
    /// AWS credentials. Your workloads can use the same IAM policies and roles that you have
    /// configured with native AWS applications to access AWS resources. Using IAM Roles Anywhere
    /// will eliminate the need to manage long term credentials for workloads running outside
    /// of AWS.
    /// 
    ///  
    /// <para>
    /// To use IAM Roles Anywhere customer workloads will need to use X.509 certificates issued
    /// by their Certificate Authority (CA) . The Certificate Authority (CA) needs to be registered
    /// with IAM Roles Anywhere as a trust anchor to establish trust between customer PKI
    /// and IAM Roles Anywhere. Customers who do not manage their own PKI system can use AWS
    /// Certificate Manager Private Certificate Authority (ACM PCA) to create a Certificate
    /// Authority and use that to establish trust with IAM Roles Anywhere
    /// </para>
    ///  
    /// <para>
    /// This guide describes the IAM rolesanywhere operations that you can call programmatically.
    /// For general information about IAM Roles Anywhere see <a href="https://docs.aws.amazon.com/">https://docs.aws.amazon.com/</a>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonIAMRolesAnywhere : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIAMRolesAnywherePaginatorFactory Paginators { get; }
#endif
                
        #region  CreateProfile



        /// <summary>
        /// Creates a profile. A profile is configuration resource to list the roles that RolesAnywhere
        /// service is trusted to assume. In addition, by applying a profile you can intersect
        /// permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:CreateProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrustAnchor



        /// <summary>
        /// Creates a trust anchor. You establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA) by configuring a trust anchor. A Trust Anchor is defined either as
        /// a reference to a AWS Certificate Manager Private Certificate Authority (ACM PCA),
        /// or by uploading a Certificate Authority (CA) certificate. Your AWS workloads can authenticate
        /// with the trust anchor using certificates issued by the trusted Certificate Authority
        /// (CA) in exchange for temporary AWS credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:CreateTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateTrustAnchor">REST API Reference for CreateTrustAnchor Operation</seealso>
        Task<CreateTrustAnchorResponse> CreateTrustAnchorAsync(CreateTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCrl



        /// <summary>
        /// Deletes a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DeleteCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteCrl">REST API Reference for DeleteCrl Operation</seealso>
        Task<DeleteCrlResponse> DeleteCrlAsync(DeleteCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProfile



        /// <summary>
        /// Deletes a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DeleteProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrustAnchor



        /// <summary>
        /// Deletes a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DeleteTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteTrustAnchor">REST API Reference for DeleteTrustAnchor Operation</seealso>
        Task<DeleteTrustAnchorResponse> DeleteTrustAnchorAsync(DeleteTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableCrl



        /// <summary>
        /// Disables a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DisableCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableCrl">REST API Reference for DisableCrl Operation</seealso>
        Task<DisableCrlResponse> DisableCrlAsync(DisableCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableProfile



        /// <summary>
        /// Disables a profile. When disabled, <a href="https://docs.aws.amazon.com/rolesanywhere/latest/APIReference/API_CreateSession.html">CreateSession</a>
        /// requests with this profile fail.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DisableProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableProfile">REST API Reference for DisableProfile Operation</seealso>
        Task<DisableProfileResponse> DisableProfileAsync(DisableProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableTrustAnchor



        /// <summary>
        /// Disables a trust anchor. When disabled, <a href="https://docs.aws.amazon.com/rolesanywhere/latest/APIReference/API_CreateSession.html">CreateSession</a>
        /// requests specifying this trust anchor are unauthorized.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:DisableTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableTrustAnchor">REST API Reference for DisableTrustAnchor Operation</seealso>
        Task<DisableTrustAnchorResponse> DisableTrustAnchorAsync(DisableTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableCrl



        /// <summary>
        /// Enables a certificate revocation list (CRL). When enabled, certificates stored in
        /// the CRL are unauthorized to receive session credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:EnableCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableCrl">REST API Reference for EnableCrl Operation</seealso>
        Task<EnableCrlResponse> EnableCrlAsync(EnableCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableProfile



        /// <summary>
        /// Enables the roles in a profile to receive session credentials in <a href="https://docs.aws.amazon.com/rolesanywhere/latest/APIReference/API_CreateSession.html">CreateSession</a>.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:EnableProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableProfile">REST API Reference for EnableProfile Operation</seealso>
        Task<EnableProfileResponse> EnableProfileAsync(EnableProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableTrustAnchor



        /// <summary>
        /// Enables a trust anchor. When enabled, certificates in the trust anchor chain are authorized
        /// for trust validation. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:EnableTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableTrustAnchor">REST API Reference for EnableTrustAnchor Operation</seealso>
        Task<EnableTrustAnchorResponse> EnableTrustAnchorAsync(EnableTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCrl



        /// <summary>
        /// Gets a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetCrl">REST API Reference for GetCrl Operation</seealso>
        Task<GetCrlResponse> GetCrlAsync(GetCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProfile



        /// <summary>
        /// Gets a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSubject



        /// <summary>
        /// Gets a Subject. A Subject associates a certificate identity with authentication attempts
        /// by CreateSession. The Subject resources stores audit information such as status of
        /// the last authentication attempt, the certificate data used in the attempt, and the
        /// last time the associated identity attempted authentication. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetSubject</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubject service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetSubject">REST API Reference for GetSubject Operation</seealso>
        Task<GetSubjectResponse> GetSubjectAsync(GetSubjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrustAnchor



        /// <summary>
        /// Gets a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:GetTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetTrustAnchorResponse> GetTrustAnchorAsync(GetTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportCrl



        /// <summary>
        /// Imports the certificate revocation list (CRL). CRl is a list of certificates that
        /// have been revoked by the issuing certificate Authority (CA). IAM Roles Anywhere validates
        /// against the crl list before issuing credentials. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ImportCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ImportCrl">REST API Reference for ImportCrl Operation</seealso>
        Task<ImportCrlResponse> ImportCrlAsync(ImportCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCrls



        /// <summary>
        /// Lists all Crls in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListCrls</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCrls service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListCrls">REST API Reference for ListCrls Operation</seealso>
        Task<ListCrlsResponse> ListCrlsAsync(ListCrlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProfiles



        /// <summary>
        /// Lists all profiles in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListProfiles</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSubjects



        /// <summary>
        /// Lists the subjects in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListSubjects</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubjects service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListSubjects">REST API Reference for ListSubjects Operation</seealso>
        Task<ListSubjectsResponse> ListSubjectsAsync(ListSubjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists the tags attached to the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListTagsForResource</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTrustAnchors



        /// <summary>
        /// Lists the trust anchors in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:ListTrustAnchors</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustAnchors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrustAnchors service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTrustAnchors">REST API Reference for ListTrustAnchors Operation</seealso>
        Task<ListTrustAnchorsResponse> ListTrustAnchorsAsync(ListTrustAnchorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Attaches tags to a resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:TagResource</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UntagResource</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCrl



        /// <summary>
        /// Updates the certificate revocation list (CRL). CRl is a list of certificates that
        /// have been revoked by the issuing certificate Authority (CA). IAM Roles Anywhere validates
        /// against the crl list before issuing credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateCrl</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UpdateCrlResponse> UpdateCrlAsync(UpdateCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProfile



        /// <summary>
        /// Updates the profile. A profile is configuration resource to list the roles that RolesAnywhere
        /// service is trusted to assume. In addition, by applying a profile you can scope-down
        /// permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateProfile</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrustAnchor



        /// <summary>
        /// Updates the trust anchor.You establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA) by configuring a trust anchor. A Trust Anchor is defined either as
        /// a reference to a AWS Certificate Manager Private Certificate Authority (ACM PCA),
        /// or by uploading a Certificate Authority (CA) certificate. Your AWS workloads can authenticate
        /// with the trust anchor using certificates issued by the trusted Certificate Authority
        /// (CA) in exchange for temporary AWS credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <code>rolesanywhere:UpdateTrustAnchor</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UpdateTrustAnchorResponse> UpdateTrustAnchorAsync(UpdateTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}