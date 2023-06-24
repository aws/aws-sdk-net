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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ACMPCA.Model;

namespace Amazon.ACMPCA
{
    /// <summary>
    /// Interface for accessing ACMPCA
    ///
    /// This is the <i>Amazon Web Services Private Certificate Authority API Reference</i>.
    /// It provides descriptions, syntax, and usage examples for each of the actions and data
    /// types involved in creating and managing a private certificate authority (CA) for your
    /// organization.
    /// 
    ///  
    /// <para>
    /// The documentation for each action shows the API request parameters and the JSON response.
    /// Alternatively, you can use one of the Amazon Web Services SDKs to access an API that
    /// is tailored to the programming language or platform that you prefer. For more information,
    /// see <a href="https://aws.amazon.com/tools/#SDKs">Amazon Web Services SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// Each Amazon Web Services Private CA API operation has a quota that determines the
    /// number of times the operation can be called per second. Amazon Web Services Private
    /// CA throttles API requests at different rates depending on the operation. Throttling
    /// means that Amazon Web Services Private CA rejects an otherwise valid request because
    /// the request exceeds the operation's quota for the number of requests per second. When
    /// a request is throttled, Amazon Web Services Private CA returns a <a href="https://docs.aws.amazon.com/acm-pca/latest/APIReference/CommonErrors.html">ThrottlingException</a>
    /// error. Amazon Web Services Private CA does not guarantee a minimum request rate for
    /// APIs. 
    /// </para>
    ///  
    /// <para>
    /// To see an up-to-date list of your Amazon Web Services Private CA quotas, or to request
    /// a quota increase, log into your Amazon Web Services account and visit the <a href="https://console.aws.amazon.com/servicequotas/">Service
    /// Quotas</a> console.
    /// </para>
    /// </summary>
    public partial interface IAmazonACMPCA : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IACMPCAPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateCertificateAuthority



        /// <summary>
        /// Creates a root or subordinate private certificate authority (CA). You must specify
        /// the CA configuration, an optional configuration for Online Certificate Status Protocol
        /// (OCSP) and/or a certificate revocation list (CRL), the CA type, and an optional idempotency
        /// token to avoid accidental creation of multiple CAs. The CA configuration specifies
        /// the name of the algorithm and key size to be used to create the CA private key, the
        /// type of signing algorithm that the CA uses, and X.500 subject information. The OCSP
        /// configuration can optionally specify a custom URL for the OCSP responder. The CRL
        /// configuration specifies the CRL expiration period in days (the validity period of
        /// the CRL), the Amazon S3 bucket that will contain the CRL, and a CNAME alias for the
        /// S3 bucket that is included in certificates issued by the CA. If successful, this action
        /// returns the Amazon Resource Name (ARN) of the CA.
        /// 
        ///  <note> 
        /// <para>
        /// Both Amazon Web Services Private CA and the IAM principal must have permission to
        /// write to the S3 bucket that you specify. If the IAM principal making the call does
        /// not have permission to write to the bucket, then an exception is thrown. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#s3-policies">Access
        /// policies for CRLs in Amazon S3</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Amazon Web Services Private CA assets that are stored in Amazon S3 can be protected
        /// with encryption. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaCreateCa.html#crl-encryption">Encrypting
        /// Your CRLs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidPolicyException">
        /// The resource policy is invalid or is missing a required statement. For general information
        /// about IAM policy and statement structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#access_policies-json">Overview
        /// of JSON Policies</a>.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidTagException">
        /// The tag associated with the CA is not valid. The invalid argument is contained in
        /// the message field.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An Amazon Web Services Private CA quota has been exceeded. See the exception message
        /// returned to determine the quota that was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthority">REST API Reference for CreateCertificateAuthority Operation</seealso>
        Task<CreateCertificateAuthorityResponse> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCertificateAuthorityAuditReport



        /// <summary>
        /// Creates an audit report that lists every time that your CA private key is used. The
        /// report is saved in the Amazon S3 bucket that you specify on input. The <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_IssueCertificate.html">IssueCertificate</a>
        /// and <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_RevokeCertificate.html">RevokeCertificate</a>
        /// actions use the private key. 
        /// 
        ///  <note> 
        /// <para>
        /// Both Amazon Web Services Private CA and the IAM principal must have permission to
        /// write to the S3 bucket that you specify. If the IAM principal making the call does
        /// not have permission to write to the bucket, then an exception is thrown. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#s3-policies">Access
        /// policies for CRLs in Amazon S3</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Amazon Web Services Private CA assets that are stored in Amazon S3 can be protected
        /// with encryption. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaAuditReport.html#audit-report-encryption">Encrypting
        /// Your Audit Reports</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can generate a maximum of one report every 30 minutes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthorityAuditReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCertificateAuthorityAuditReport service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthorityAuditReport">REST API Reference for CreateCertificateAuthorityAuditReport Operation</seealso>
        Task<CreateCertificateAuthorityAuditReportResponse> CreateCertificateAuthorityAuditReportAsync(CreateCertificateAuthorityAuditReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePermission



        /// <summary>
        /// Grants one or more permissions on a private CA to the Certificate Manager (ACM) service
        /// principal (<code>acm.amazonaws.com</code>). These permissions allow ACM to issue and
        /// renew ACM certificates that reside in the same Amazon Web Services account as the
        /// CA.
        /// 
        ///  
        /// <para>
        /// You can list current permissions with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListPermissions.html">ListPermissions</a>
        /// action and revoke them with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePermission.html">DeletePermission</a>
        /// action.
        /// </para>
        ///  <p class="title"> <b>About Permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the private CA and the certificates it issues reside in the same account, you can
        /// use <code>CreatePermission</code> to grant permissions for ACM to carry out automatic
        /// certificate renewals.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For automatic certificate renewal to succeed, the ACM service principal needs permissions
        /// to create, retrieve, and list certificates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the private CA and the ACM certificates reside in different accounts, then permissions
        /// cannot be used to enable automatic renewals. Instead, the ACM certificate owner must
        /// set up a resource-based policy to enable cross-account issuance and renewals. For
        /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using
        /// a Resource Based Policy with Amazon Web Services Private CA</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePermission service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An Amazon Web Services Private CA quota has been exceeded. See the exception message
        /// returned to determine the quota that was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.PermissionAlreadyExistsException">
        /// The designated permission has already been given to the user.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreatePermission">REST API Reference for CreatePermission Operation</seealso>
        Task<CreatePermissionResponse> CreatePermissionAsync(CreatePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCertificateAuthority



        /// <summary>
        /// Deletes a private certificate authority (CA). You must provide the Amazon Resource
        /// Name (ARN) of the private CA that you want to delete. You can find the ARN by calling
        /// the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// action. 
        /// 
        ///  <note> 
        /// <para>
        /// Deleting a CA will invalidate other CAs and certificates below it in your CA hierarchy.
        /// </para>
        ///  </note> 
        /// <para>
        /// Before you can delete a CA that you have created and activated, you must disable it.
        /// To do this, call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UpdateCertificateAuthority.html">UpdateCertificateAuthority</a>
        /// action and set the <b>CertificateAuthorityStatus</b> parameter to <code>DISABLED</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can delete a CA if you are waiting for it to be created (that is,
        /// the status of the CA is <code>CREATING</code>). You can also delete it if the CA has
        /// been created but you haven't yet imported the signed certificate into Amazon Web Services
        /// Private CA (that is, the status of the CA is <code>PENDING_CERTIFICATE</code>). 
        /// </para>
        ///  
        /// <para>
        /// When you successfully call <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeleteCertificateAuthority.html">DeleteCertificateAuthority</a>,
        /// the CA's status changes to <code>DELETED</code>. However, the CA won't be permanently
        /// deleted until the restoration period has passed. By default, if you do not set the
        /// <code>PermanentDeletionTimeInDays</code> parameter, the CA remains restorable for
        /// 30 days. You can set the parameter from 7 to 30 days. The <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DescribeCertificateAuthority.html">DescribeCertificateAuthority</a>
        /// action returns the time remaining in the restoration window of a private CA in the
        /// <code>DELETED</code> state. To restore an eligible CA, call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_RestoreCertificateAuthority.html">RestoreCertificateAuthority</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeleteCertificateAuthority">REST API Reference for DeleteCertificateAuthority Operation</seealso>
        Task<DeleteCertificateAuthorityResponse> DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePermission



        /// <summary>
        /// Revokes permissions on a private CA granted to the Certificate Manager (ACM) service
        /// principal (acm.amazonaws.com). 
        /// 
        ///  
        /// <para>
        /// These permissions allow ACM to issue and renew ACM certificates that reside in the
        /// same Amazon Web Services account as the CA. If you revoke these permissions, ACM will
        /// no longer renew the affected certificates automatically.
        /// </para>
        ///  
        /// <para>
        /// Permissions can be granted with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreatePermission.html">CreatePermission</a>
        /// action and listed with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListPermissions.html">ListPermissions</a>
        /// action. 
        /// </para>
        ///  <p class="title"> <b>About Permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the private CA and the certificates it issues reside in the same account, you can
        /// use <code>CreatePermission</code> to grant permissions for ACM to carry out automatic
        /// certificate renewals.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For automatic certificate renewal to succeed, the ACM service principal needs permissions
        /// to create, retrieve, and list certificates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the private CA and the ACM certificates reside in different accounts, then permissions
        /// cannot be used to enable automatic renewals. Instead, the ACM certificate owner must
        /// set up a resource-based policy to enable cross-account issuance and renewals. For
        /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using
        /// a Resource Based Policy with Amazon Web Services Private CA</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePermission service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeletePermission">REST API Reference for DeletePermission Operation</seealso>
        Task<DeletePermissionResponse> DeletePermissionAsync(DeletePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePolicy



        /// <summary>
        /// Deletes the resource-based policy attached to a private CA. Deletion will remove any
        /// access that the policy has granted. If there is no policy attached to the private
        /// CA, this action will return successful.
        /// 
        ///  
        /// <para>
        /// If you delete a policy that was applied through Amazon Web Services Resource Access
        /// Manager (RAM), the CA will be removed from all shares in which it was included. 
        /// </para>
        ///  
        /// <para>
        /// The Certificate Manager Service Linked Role that the policy supports is not affected
        /// when you delete the policy. 
        /// </para>
        ///  
        /// <para>
        /// The current policy can be shown with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// and updated with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_PutPolicy.html">PutPolicy</a>.
        /// </para>
        ///  <p class="title"> <b>About Policies</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A policy grants access on a private CA to an Amazon Web Services customer account,
        /// to Amazon Web Services Organizations, or to an Amazon Web Services Organizations unit.
        /// Policies are under the control of a CA administrator. For more information, see <a
        /// href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using a
        /// Resource Based Policy with Amazon Web Services Private CA</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A policy permits a user of Certificate Manager (ACM) to issue ACM certificates signed
        /// by a CA in another account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ACM to manage automatic renewal of these certificates, the ACM user must configure
        /// a Service Linked Role (SLR). The SLR allows the ACM service to assume the identity
        /// of the user, subject to confirmation against the Amazon Web Services Private CA policy.
        /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-slr.html">Using
        /// a Service Linked Role with ACM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updates made in Amazon Web Services Resource Manager (RAM) are reflected in policies.
        /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-ram.html">Attach
        /// a Policy for Cross-Account Access</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LockoutPreventedException">
        /// The current action was prevented because it would lock the caller out from performing
        /// subsequent actions. Verify that the specified parameters would not result in the caller
        /// being denied access to the resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificateAuthority



        /// <summary>
        /// Lists information about your private certificate authority (CA) or one that has been
        /// shared with you. You specify the private CA on input by its ARN (Amazon Resource Name).
        /// The output contains the status of your CA. This can be any of the following: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code> - Amazon Web Services Private CA is creating your private certificate
        /// authority.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_CERTIFICATE</code> - The certificate is pending. You must use your
        /// Amazon Web Services Private CA-hosted or on-premises root or subordinate CA to sign
        /// your private CA CSR and then import it into Amazon Web Services Private CA. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTIVE</code> - Your private CA is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> - Your private CA has been disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXPIRED</code> - Your private CA certificate has expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - Your private CA has failed. Your CA can fail because of problems
        /// such a network outage or back-end Amazon Web Services failure or other errors. A failed
        /// CA can never return to the pending state. You must create a new CA. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> - Your private CA is within the restoration period, after which
        /// it is permanently deleted. The length of time remaining in the CA's restoration period
        /// is also included in this action's output.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthority">REST API Reference for DescribeCertificateAuthority Operation</seealso>
        Task<DescribeCertificateAuthorityResponse> DescribeCertificateAuthorityAsync(DescribeCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificateAuthorityAuditReport



        /// <summary>
        /// Lists information about a specific audit report created by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthorityAuditReport.html">CreateCertificateAuthorityAuditReport</a>
        /// action. Audit information is created every time the certificate authority (CA) private
        /// key is used. The private key is used when you call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_IssueCertificate.html">IssueCertificate</a>
        /// action or the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_RevokeCertificate.html">RevokeCertificate</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthorityAuditReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificateAuthorityAuditReport service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthorityAuditReport">REST API Reference for DescribeCertificateAuthorityAuditReport Operation</seealso>
        Task<DescribeCertificateAuthorityAuditReportResponse> DescribeCertificateAuthorityAuditReportAsync(DescribeCertificateAuthorityAuditReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCertificate



        /// <summary>
        /// Retrieves a certificate from your private CA or one that has been shared with you.
        /// The ARN of the certificate is returned when you call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_IssueCertificate.html">IssueCertificate</a>
        /// action. You must specify both the ARN of your private CA and the ARN of the issued
        /// certificate when calling the <b>GetCertificate</b> action. You can retrieve the certificate
        /// if it is in the <b>ISSUED</b> state. You can call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthorityAuditReport.html">CreateCertificateAuthorityAuditReport</a>
        /// action to create a report that contains information about all of the certificates
        /// issued and revoked by your private CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCertificateAuthorityCertificate



        /// <summary>
        /// Retrieves the certificate and certificate chain for your private certificate authority
        /// (CA) or one that has been shared with you. Both the certificate and the chain are
        /// base64 PEM-encoded. The chain does not include the CA certificate. Each certificate
        /// in the chain signs the one before it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificateAuthorityCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCertificate">REST API Reference for GetCertificateAuthorityCertificate Operation</seealso>
        Task<GetCertificateAuthorityCertificateResponse> GetCertificateAuthorityCertificateAsync(GetCertificateAuthorityCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCertificateAuthorityCsr



        /// <summary>
        /// Retrieves the certificate signing request (CSR) for your private certificate authority
        /// (CA). The CSR is created when you call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
        /// action. Sign the CSR with your Amazon Web Services Private CA-hosted or on-premises
        /// root or subordinate CA. Then import the signed certificate back into Amazon Web Services
        /// Private CA by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ImportCertificateAuthorityCertificate.html">ImportCertificateAuthorityCertificate</a>
        /// action. The CSR is returned as a base64 PEM-encoded string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCsr service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificateAuthorityCsr service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCsr">REST API Reference for GetCertificateAuthorityCsr Operation</seealso>
        Task<GetCertificateAuthorityCsrResponse> GetCertificateAuthorityCsrAsync(GetCertificateAuthorityCsrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPolicy



        /// <summary>
        /// Retrieves the resource-based policy attached to a private CA. If either the private
        /// CA resource or the policy cannot be found, this action returns a <code>ResourceNotFoundException</code>.
        /// 
        /// 
        ///  
        /// <para>
        /// The policy can be attached or updated with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_PutPolicy.html">PutPolicy</a>
        /// and removed with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePolicy.html">DeletePolicy</a>.
        /// </para>
        ///  <p class="title"> <b>About Policies</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A policy grants access on a private CA to an Amazon Web Services customer account,
        /// to Amazon Web Services Organizations, or to an Amazon Web Services Organizations unit.
        /// Policies are under the control of a CA administrator. For more information, see <a
        /// href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using a
        /// Resource Based Policy with Amazon Web Services Private CA</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A policy permits a user of Certificate Manager (ACM) to issue ACM certificates signed
        /// by a CA in another account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ACM to manage automatic renewal of these certificates, the ACM user must configure
        /// a Service Linked Role (SLR). The SLR allows the ACM service to assume the identity
        /// of the user, subject to confirmation against the Amazon Web Services Private CA policy.
        /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-slr.html">Using
        /// a Service Linked Role with ACM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updates made in Amazon Web Services Resource Manager (RAM) are reflected in policies.
        /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-ram.html">Attach
        /// a Policy for Cross-Account Access</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportCertificateAuthorityCertificate



        /// <summary>
        /// Imports a signed private CA certificate into Amazon Web Services Private CA. This
        /// action is used when you are using a chain of trust whose root is located outside Amazon
        /// Web Services Private CA. Before you can call this action, the following preparations
        /// must in place:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// In Amazon Web Services Private CA, call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
        /// action to create the private CA that you plan to back with the imported certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificateAuthorityCsr.html">GetCertificateAuthorityCsr</a>
        /// action to generate a certificate signing request (CSR).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sign the CSR using a root or intermediate CA hosted by either an on-premises PKI hierarchy
        /// or by a commercial CA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a certificate chain and copy the signed certificate and the certificate chain
        /// to your working directory.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// Amazon Web Services Private CA supports three scenarios for installing a CA certificate:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Installing a certificate for a root CA hosted by Amazon Web Services Private CA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Installing a subordinate CA certificate whose parent authority is hosted by Amazon
        /// Web Services Private CA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Installing a subordinate CA certificate whose parent authority is externally hosted.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following additional requirements apply when you import a CA certificate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Only a self-signed certificate can be imported as a root CA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A self-signed certificate cannot be imported as a subordinate CA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your certificate chain must not include the private CA certificate that you are importing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your root CA must be the last certificate in your chain. The subordinate certificate,
        /// if any, that your root CA signed must be next to last. The subordinate certificate
        /// signed by the preceding subordinate CA must come next, and so on until your chain
        /// is built. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The chain must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum allowed size of a certificate is 32 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum allowed size of a certificate chain is 2 MB.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <i>Enforcement of Critical Constraints</i> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Private CA allows the following extensions to be marked critical
        /// in the imported CA certificate or chain.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Basic constraints (<i>must</i> be marked critical)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subject alternative names
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key usage
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Extended key usage
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Authority key identifier
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subject key identifier
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Issuer alternative name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subject directory attributes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Subject information access
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Certificate policies
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy mappings
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inhibit anyPolicy
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services Private CA rejects the following extensions when they are marked
        /// critical in an imported CA certificate or chain.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Name constraints
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy constraints
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CRL distribution points
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Authority information access
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Freshest CRL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any other extension
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificateAuthorityCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCertificateAuthorityCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.CertificateMismatchException">
        /// The certificate authority certificate you are importing does not comply with conditions
        /// specified in the certificate that signed it.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidRequestException">
        /// The request action cannot be performed or is prohibited.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.MalformedCertificateException">
        /// One or more fields in the certificate are invalid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ImportCertificateAuthorityCertificate">REST API Reference for ImportCertificateAuthorityCertificate Operation</seealso>
        Task<ImportCertificateAuthorityCertificateResponse> ImportCertificateAuthorityCertificateAsync(ImportCertificateAuthorityCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  IssueCertificate



        /// <summary>
        /// Uses your private certificate authority (CA), or one that has been shared with you,
        /// to issue a client certificate. This action returns the Amazon Resource Name (ARN)
        /// of the certificate. You can retrieve the certificate by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificate.html">GetCertificate</a>
        /// action and specifying the ARN. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use the ACM <b>ListCertificateAuthorities</b> action to retrieve the ARNs
        /// of the certificates that you issue by using Amazon Web Services Private CA.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IssueCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IssueCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An Amazon Web Services Private CA quota has been exceeded. See the exception message
        /// returned to determine the quota that was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.MalformedCSRException">
        /// The certificate signing request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/IssueCertificate">REST API Reference for IssueCertificate Operation</seealso>
        Task<IssueCertificateResponse> IssueCertificateAsync(IssueCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCertificateAuthorities



        /// <summary>
        /// Lists the private certificate authorities that you created by using the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html">CreateCertificateAuthority</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAuthorities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificateAuthorities service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidNextTokenException">
        /// The token specified in the <code>NextToken</code> argument is not valid. Use the token
        /// returned from your previous call to <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListCertificateAuthorities">REST API Reference for ListCertificateAuthorities Operation</seealso>
        Task<ListCertificateAuthoritiesResponse> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPermissions



        /// <summary>
        /// List all permissions on a private CA, if any, granted to the Certificate Manager (ACM)
        /// service principal (acm.amazonaws.com). 
        /// 
        ///  
        /// <para>
        /// These permissions allow ACM to issue and renew ACM certificates that reside in the
        /// same Amazon Web Services account as the CA. 
        /// </para>
        ///  
        /// <para>
        /// Permissions can be granted with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreatePermission.html">CreatePermission</a>
        /// action and revoked with the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePermission.html">DeletePermission</a>
        /// action.
        /// </para>
        ///  <p class="title"> <b>About Permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the private CA and the certificates it issues reside in the same account, you can
        /// use <code>CreatePermission</code> to grant permissions for ACM to carry out automatic
        /// certificate renewals.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For automatic certificate renewal to succeed, the ACM service principal needs permissions
        /// to create, retrieve, and list certificates.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the private CA and the ACM certificates reside in different accounts, then permissions
        /// cannot be used to enable automatic renewals. Instead, the ACM certificate owner must
        /// set up a resource-based policy to enable cross-account issuance and renewals. For
        /// more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using
        /// a Resource Based Policy with Amazon Web Services Private CA</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidNextTokenException">
        /// The token specified in the <code>NextToken</code> argument is not valid. Use the token
        /// returned from your previous call to <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags



        /// <summary>
        /// Lists the tags, if any, that are associated with your private CA or one that has been
        /// shared with you. Tags are labels that you can use to identify and organize your CAs.
        /// Each tag consists of a key and an optional value. Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_TagCertificateAuthority.html">TagCertificateAuthority</a>
        /// action to add one or more tags to your CA. Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UntagCertificateAuthority.html">UntagCertificateAuthority</a>
        /// action to remove tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutPolicy



        /// <summary>
        /// Attaches a resource-based policy to a private CA. 
        /// 
        ///  
        /// <para>
        /// A policy can also be applied by sharing a private CA through Amazon Web Services Resource
        /// Access Manager (RAM). For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-ram.html">Attach
        /// a Policy for Cross-Account Access</a>.
        /// </para>
        ///  
        /// <para>
        /// The policy can be displayed with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetPolicy.html">GetPolicy</a>
        /// and removed with <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeletePolicy.html">DeletePolicy</a>.
        /// </para>
        ///  <p class="title"> <b>About Policies</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A policy grants access on a private CA to an Amazon Web Services customer account,
        /// to Amazon Web Services Organizations, or to an Amazon Web Services Organizations unit.
        /// Policies are under the control of a CA administrator. For more information, see <a
        /// href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-rbp.html">Using a
        /// Resource Based Policy with Amazon Web Services Private CA</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A policy permits a user of Certificate Manager (ACM) to issue ACM certificates signed
        /// by a CA in another account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For ACM to manage automatic renewal of these certificates, the ACM user must configure
        /// a Service Linked Role (SLR). The SLR allows the ACM service to assume the identity
        /// of the user, subject to confirmation against the Amazon Web Services Private CA policy.
        /// For more information, see <a href="https://docs.aws.amazon.com/acm/latest/userguide/acm-slr.html">Using
        /// a Service Linked Role with ACM</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Updates made in Amazon Web Services Resource Manager (RAM) are reflected in policies.
        /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/pca-ram.html">Attach
        /// a Policy for Cross-Account Access</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidPolicyException">
        /// The resource policy is invalid or is missing a required statement. For general information
        /// about IAM policy and statement structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#access_policies-json">Overview
        /// of JSON Policies</a>.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LockoutPreventedException">
        /// The current action was prevented because it would lock the caller out from performing
        /// subsequent actions. Verify that the specified parameters would not result in the caller
        /// being denied access to the resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        Task<PutPolicyResponse> PutPolicyAsync(PutPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreCertificateAuthority



        /// <summary>
        /// Restores a certificate authority (CA) that is in the <code>DELETED</code> state. You
        /// can restore a CA during the period that you defined in the <b>PermanentDeletionTimeInDays</b>
        /// parameter of the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeleteCertificateAuthority.html">DeleteCertificateAuthority</a>
        /// action. Currently, you can specify 7 to 30 days. If you did not specify a <b>PermanentDeletionTimeInDays</b>
        /// value, by default you can restore the CA at any time in a 30 day period. You can check
        /// the time remaining in the restoration period of a private CA in the <code>DELETED</code>
        /// state by calling the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_DescribeCertificateAuthority.html">DescribeCertificateAuthority</a>
        /// or <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// actions. The status of a restored CA is set to its pre-deletion status when the <b>RestoreCertificateAuthority</b>
        /// action returns. To change its status to <code>ACTIVE</code>, call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UpdateCertificateAuthority.html">UpdateCertificateAuthority</a>
        /// action. If the private CA was in the <code>PENDING_CERTIFICATE</code> state at deletion,
        /// you must use the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ImportCertificateAuthorityCertificate.html">ImportCertificateAuthorityCertificate</a>
        /// action to import a certificate authority into the private CA before it can be activated.
        /// You cannot restore a CA after the restoration period has ended.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RestoreCertificateAuthority">REST API Reference for RestoreCertificateAuthority Operation</seealso>
        Task<RestoreCertificateAuthorityResponse> RestoreCertificateAuthorityAsync(RestoreCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeCertificate



        /// <summary>
        /// Revokes a certificate that was issued inside Amazon Web Services Private CA. If you
        /// enable a certificate revocation list (CRL) when you create or update your private
        /// CA, information about the revoked certificates will be included in the CRL. Amazon
        /// Web Services Private CA writes the CRL to an S3 bucket that you specify. A CRL is
        /// typically updated approximately 30 minutes after a certificate is revoked. If for
        /// any reason the CRL update fails, Amazon Web Services Private CA attempts makes further
        /// attempts every 15 minutes. With Amazon CloudWatch, you can create alarms for the metrics
        /// <code>CRLGenerated</code> and <code>MisconfiguredCRLBucket</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/PcaCloudWatch.html">Supported
        /// CloudWatch Metrics</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Both Amazon Web Services Private CA and the IAM principal must have permission to
        /// write to the S3 bucket that you specify. If the IAM principal making the call does
        /// not have permission to write to the bucket, then an exception is thrown. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#s3-policies">Access
        /// policies for CRLs in Amazon S3</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Amazon Web Services Private CA also writes revocation information to the audit report.
        /// For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthorityAuditReport.html">CreateCertificateAuthorityAuditReport</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot revoke a root CA self-signed certificate.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidRequestException">
        /// The request action cannot be performed or is prohibited.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An Amazon Web Services Private CA quota has been exceeded. See the exception message
        /// returned to determine the quota that was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestAlreadyProcessedException">
        /// Your request has already been completed.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        Task<RevokeCertificateResponse> RevokeCertificateAsync(RevokeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagCertificateAuthority



        /// <summary>
        /// Adds one or more tags to your private CA. Tags are labels that you can use to identify
        /// and organize your Amazon Web Services resources. Each tag consists of a key and an
        /// optional value. You specify the private CA on input by its Amazon Resource Name (ARN).
        /// You specify the tag by using a key-value pair. You can apply a tag to just one private
        /// CA if you want to identify a specific characteristic of that CA, or you can apply
        /// the same tag to multiple private CAs if you want to filter for a common relationship
        /// among those CAs. To remove one or more tags, use the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_UntagCertificateAuthority.html">UntagCertificateAuthority</a>
        /// action. Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListTags.html">ListTags</a>
        /// action to see what tags are associated with your CA. 
        /// 
        ///  <note> 
        /// <para>
        /// To attach tags to a private CA during the creation procedure, a CA administrator must
        /// first associate an inline IAM policy with the <code>CreateCertificateAuthority</code>
        /// action and explicitly allow tagging. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/auth-InlinePolicies.html#policy-tag-ca">Attaching
        /// tags to a CA at the time of creation</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidTagException">
        /// The tag associated with the CA is not valid. The invalid argument is contained in
        /// the message field.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.TooManyTagsException">
        /// You can associate up to 50 tags with a private CA. Exception information is contained
        /// in the exception message field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/TagCertificateAuthority">REST API Reference for TagCertificateAuthority Operation</seealso>
        Task<TagCertificateAuthorityResponse> TagCertificateAuthorityAsync(TagCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagCertificateAuthority



        /// <summary>
        /// Remove one or more tags from your private CA. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this action, the tag
        /// will be removed regardless of value. If you specify a value, the tag is removed only
        /// if it is associated with the specified value. To add tags to a private CA, use the
        /// <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_TagCertificateAuthority.html">TagCertificateAuthority</a>.
        /// Call the <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListTags.html">ListTags</a>
        /// action to see what tags are associated with your CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidTagException">
        /// The tag associated with the CA is not valid. The invalid argument is contained in
        /// the message field.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UntagCertificateAuthority">REST API Reference for UntagCertificateAuthority Operation</seealso>
        Task<UntagCertificateAuthorityResponse> UntagCertificateAuthorityAsync(UntagCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCertificateAuthority



        /// <summary>
        /// Updates the status or configuration of a private certificate authority (CA). Your
        /// private CA must be in the <code>ACTIVE</code> or <code>DISABLED</code> state before
        /// you can update it. You can disable a private CA that is in the <code>ACTIVE</code>
        /// state or make a CA that is in the <code>DISABLED</code> state active again.
        /// 
        ///  <note> 
        /// <para>
        /// Both Amazon Web Services Private CA and the IAM principal must have permission to
        /// write to the S3 bucket that you specify. If the IAM principal making the call does
        /// not have permission to write to the bucket, then an exception is thrown. For more
        /// information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#s3-policies">Access
        /// policies for CRLs in Amazon S3</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateAuthority service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidPolicyException">
        /// The resource policy is invalid or is missing a required statement. For general information
        /// about IAM policy and statement structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies.html#access_policies-json">Overview
        /// of JSON Policies</a>.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The state of the private CA does not allow this action to occur.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, audit report, or policy cannot
        /// be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UpdateCertificateAuthority">REST API Reference for UpdateCertificateAuthority Operation</seealso>
        Task<UpdateCertificateAuthorityResponse> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}