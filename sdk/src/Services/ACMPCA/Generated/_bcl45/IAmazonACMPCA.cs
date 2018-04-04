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
    /// You can use the ACM PCA API to create a private certificate authority (CA). You must
    /// first call the <a>CreateCertificateAuthority</a> function. If successful, the function
    /// returns an Amazon Resource Name (ARN) for your private CA. Use this ARN as input to
    /// the <a>GetCertificateAuthorityCsr</a> function to retrieve the certificate signing
    /// request (CSR) for your private CA certificate. Sign the CSR using the root or an intermediate
    /// CA in your on-premises PKI hierarchy, and call the <a>ImportCertificateAuthorityCertificate</a>
    /// to import your signed private CA certificate into ACM PCA. 
    /// 
    ///  
    /// <para>
    /// Use your private CA to issue and revoke certificates. These are private certificates
    /// that identify and secure client computers, servers, applications, services, devices,
    /// and users over SSLS/TLS connections within your organization. Call the <a>IssueCertificate</a>
    /// function to issue a certificate. Call the <a>RevokeCertificate</a> function to revoke
    /// a certificate. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Certificates issued by your private CA can be trusted only within your organization,
    /// not publicly.
    /// </para>
    ///  </note> 
    /// <para>
    /// Your private CA can optionally create a certificate revocation list (CRL) to track
    /// the certificates you revoke. To create a CRL, you must specify a <a>RevocationConfiguration</a>
    /// object when you call the <a>CreateCertificateAuthority</a> function. ACM PCA writes
    /// the CRL to an S3 bucket that you specify. You must specify a bucket policy that grants
    /// ACM PCA write permission. 
    /// </para>
    ///  
    /// <para>
    /// You can also call the <a>CreateCertificateAuthorityAuditReport</a> to create an optional
    /// audit report that lists every time the CA private key is used. The private key is
    /// used for signing when the <b>IssueCertificate</b> or <b>RevokeCertificate</b> function
    /// is called. 
    /// </para>
    /// </summary>
    public partial interface IAmazonACMPCA : IAmazonService, IDisposable
    {

        
        #region  CreateCertificateAuthority


        /// <summary>
        /// Creates a private subordinate certificate authority (CA). You must specify the CA
        /// configuration, the revocation configuration, the CA type, and an optional idempotency
        /// token. The CA configuration specifies the name of the algorithm and key size to be
        /// used to create the CA private key, the type of signing algorithm that the CA uses
        /// to sign, and X.500 subject information. The CRL (certificate revocation list) configuration
        /// specifies the CRL expiration period in days (the validity period of the CRL), the
        /// Amazon S3 bucket that will contain the CRL, and a CNAME alias for the S3 bucket that
        /// is included in certificates issued by the CA. If successful, this function returns
        /// the Amazon Resource Name (ARN) of the CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the CreateCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidPolicyException">
        /// The S3 bucket policy is not valid. The policy must give ACM PCA rights to read from
        /// and write to the bucket and find the bucket location.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An ACM PCA limit has been exceeded. See the exception message returned to determine
        /// the limit that was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthority">REST API Reference for CreateCertificateAuthority Operation</seealso>
        CreateCertificateAuthorityResponse CreateCertificateAuthority(CreateCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthority">REST API Reference for CreateCertificateAuthority Operation</seealso>
        Task<CreateCertificateAuthorityResponse> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCertificateAuthorityAuditReport


        /// <summary>
        /// Creates an audit report that lists every time that the your CA private key is used.
        /// The report is saved in the Amazon S3 bucket that you specify on input. The <a>IssueCertificate</a>
        /// and <a>RevokeCertificate</a> functions use the private key. You can generate a new
        /// report every 30 minutes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthorityAuditReport service method.</param>
        /// 
        /// <returns>The response from the CreateCertificateAuthorityAuditReport service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthorityAuditReport">REST API Reference for CreateCertificateAuthorityAuditReport Operation</seealso>
        CreateCertificateAuthorityAuditReportResponse CreateCertificateAuthorityAuditReport(CreateCertificateAuthorityAuditReportRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCertificateAuthorityAuditReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthorityAuditReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthorityAuditReport">REST API Reference for CreateCertificateAuthorityAuditReport Operation</seealso>
        Task<CreateCertificateAuthorityAuditReportResponse> CreateCertificateAuthorityAuditReportAsync(CreateCertificateAuthorityAuditReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCertificateAuthority


        /// <summary>
        /// Deletes the private certificate authority (CA) that you created or started to create
        /// by calling the <a>CreateCertificateAuthority</a> function. This action requires that
        /// you enter an ARN (Amazon Resource Name) for the private CA that you want to delete.
        /// You can find the ARN by calling the <a>ListCertificateAuthorities</a> function. You
        /// can delete the CA if you are waiting for it to be created (the <b>Status</b> field
        /// of the <a>CertificateAuthority</a> is <code>CREATING</code>) or if the CA has been
        /// created but you haven't yet imported the signed certificate (the <b>Status</b> is
        /// <code>PENDING_CERTIFICATE</code>) into ACM PCA. If you've already imported the certificate,
        /// you cannot delete the CA unless it has been disabled for more than 30 days. To disable
        /// a CA, call the <a>UpdateCertificateAuthority</a> function and set the <b>CertificateAuthorityStatus</b>
        /// argument to <code>DISABLED</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeleteCertificateAuthority">REST API Reference for DeleteCertificateAuthority Operation</seealso>
        DeleteCertificateAuthorityResponse DeleteCertificateAuthority(DeleteCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeleteCertificateAuthority">REST API Reference for DeleteCertificateAuthority Operation</seealso>
        Task<DeleteCertificateAuthorityResponse> DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCertificateAuthority


        /// <summary>
        /// Lists information about your private certificate authority (CA). You specify the private
        /// CA on input by its ARN (Amazon Resource Name). The output contains the status of your
        /// CA. This can be any of the following: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>CREATING:</b> ACM PCA is creating your private certificate authority.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>PENDING_CERTIFICATE:</b> The certificate is pending. You must use your on-premises
        /// root or subordinate CA to sign your private CA CSR and then import it into PCA. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE:</b> Your private CA is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DISABLED:</b> Your private CA has been disabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>EXPIRED:</b> Your private CA certificate has expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED:</b> Your private CA has failed. Your CA can fail for problems such a network
        /// outage or backend AWS failure or other errors. A failed CA can never return to the
        /// pending state. You must create a new CA. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthority">REST API Reference for DescribeCertificateAuthority Operation</seealso>
        DescribeCertificateAuthorityResponse DescribeCertificateAuthority(DescribeCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthority">REST API Reference for DescribeCertificateAuthority Operation</seealso>
        Task<DescribeCertificateAuthorityResponse> DescribeCertificateAuthorityAsync(DescribeCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCertificateAuthorityAuditReport


        /// <summary>
        /// Lists information about a specific audit report created by calling the <a>CreateCertificateAuthorityAuditReport</a>
        /// function. Audit information is created every time the certificate authority (CA) private
        /// key is used. The private key is used when you call the <a>IssueCertificate</a> function
        /// or the <a>RevokeCertificate</a> function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthorityAuditReport service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificateAuthorityAuditReport service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthorityAuditReport">REST API Reference for DescribeCertificateAuthorityAuditReport Operation</seealso>
        DescribeCertificateAuthorityAuditReportResponse DescribeCertificateAuthorityAuditReport(DescribeCertificateAuthorityAuditReportRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificateAuthorityAuditReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthorityAuditReport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthorityAuditReport">REST API Reference for DescribeCertificateAuthorityAuditReport Operation</seealso>
        Task<DescribeCertificateAuthorityAuditReportResponse> DescribeCertificateAuthorityAuditReportAsync(DescribeCertificateAuthorityAuditReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCertificate


        /// <summary>
        /// Retrieves a certificate from your private CA. The ARN of the certificate is returned
        /// when you call the <a>IssueCertificate</a> function. You must specify both the ARN
        /// of your private CA and the ARN of the issued certificate when calling the <b>GetCertificate</b>
        /// function. You can retrieve the certificate if it is in the <b>ISSUED</b> state. You
        /// can call the <a>CreateCertificateAuthorityAuditReport</a> function to create a report
        /// that contains information about all of the certificates issued and revoked by your
        /// private CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        GetCertificateResponse GetCertificate(GetCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCertificateAuthorityCertificate


        /// <summary>
        /// Retrieves the certificate and certificate chain for your private certificate authority
        /// (CA). Both the certificate and the chain are base64 PEM-encoded. The chain does not
        /// include the CA certificate. Each certificate in the chain signs the one before it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCertificate service method.</param>
        /// 
        /// <returns>The response from the GetCertificateAuthorityCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCertificate">REST API Reference for GetCertificateAuthorityCertificate Operation</seealso>
        GetCertificateAuthorityCertificateResponse GetCertificateAuthorityCertificate(GetCertificateAuthorityCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCertificateAuthorityCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCertificate">REST API Reference for GetCertificateAuthorityCertificate Operation</seealso>
        Task<GetCertificateAuthorityCertificateResponse> GetCertificateAuthorityCertificateAsync(GetCertificateAuthorityCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCertificateAuthorityCsr


        /// <summary>
        /// Retrieves the certificate signing request (CSR) for your private certificate authority
        /// (CA). The CSR is created when you call the <a>CreateCertificateAuthority</a> function.
        /// Take the CSR to your on-premises X.509 infrastructure and sign it by using your root
        /// or a subordinate CA. Then import the signed certificate back into ACM PCA by calling
        /// the <a>ImportCertificateAuthorityCertificate</a> function. The CSR is returned as
        /// a base64 PEM-encoded string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCsr service method.</param>
        /// 
        /// <returns>The response from the GetCertificateAuthorityCsr service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestInProgressException">
        /// Your request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCsr">REST API Reference for GetCertificateAuthorityCsr Operation</seealso>
        GetCertificateAuthorityCsrResponse GetCertificateAuthorityCsr(GetCertificateAuthorityCsrRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCertificateAuthorityCsr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCsr operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCsr">REST API Reference for GetCertificateAuthorityCsr Operation</seealso>
        Task<GetCertificateAuthorityCsrResponse> GetCertificateAuthorityCsrAsync(GetCertificateAuthorityCsrRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportCertificateAuthorityCertificate


        /// <summary>
        /// Imports your signed private CA certificate into ACM PCA. Before you can call this
        /// function, you must create the private certificate authority by calling the <a>CreateCertificateAuthority</a>
        /// function. You must then generate a certificate signing request (CSR) by calling the
        /// <a>GetCertificateAuthorityCsr</a> function. Take the CSR to your on-premises CA and
        /// use the root certificate or a subordinate certificate to sign it. Create a certificate
        /// chain and copy the signed certificate and the certificate chain to your working directory.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// Your certificate chain must not include the private CA certificate that you are importing.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Your on-premises CA certificate must be the last certificate in your chain. The subordinate
        /// certificate, if any, that your root CA signed must be next to last. The subordinate
        /// certificate signed by the preceding subordinate CA must come next, and so on until
        /// your chain is built. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// The chain must be PEM-encoded.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificateAuthorityCertificate service method.</param>
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
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ImportCertificateAuthorityCertificate">REST API Reference for ImportCertificateAuthorityCertificate Operation</seealso>
        ImportCertificateAuthorityCertificateResponse ImportCertificateAuthorityCertificate(ImportCertificateAuthorityCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificateAuthorityCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificateAuthorityCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ImportCertificateAuthorityCertificate">REST API Reference for ImportCertificateAuthorityCertificate Operation</seealso>
        Task<ImportCertificateAuthorityCertificateResponse> ImportCertificateAuthorityCertificateAsync(ImportCertificateAuthorityCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  IssueCertificate


        /// <summary>
        /// Uses your private certificate authority (CA) to issue a client certificate. This function
        /// returns the Amazon Resource Name (ARN) of the certificate. You can retrieve the certificate
        /// by calling the <a>GetCertificate</a> function and specifying the ARN. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use the ACM <b>ListCertificateAuthorities</b> function to retrieve the
        /// ARNs of the certificates that you issue by using ACM PCA.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IssueCertificate service method.</param>
        /// 
        /// <returns>The response from the IssueCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An ACM PCA limit has been exceeded. See the exception message returned to determine
        /// the limit that was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.MalformedCSRException">
        /// The certificate signing request is invalid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/IssueCertificate">REST API Reference for IssueCertificate Operation</seealso>
        IssueCertificateResponse IssueCertificate(IssueCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the IssueCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IssueCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/IssueCertificate">REST API Reference for IssueCertificate Operation</seealso>
        Task<IssueCertificateResponse> IssueCertificateAsync(IssueCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCertificateAuthorities


        /// <summary>
        /// Lists the private certificate authorities that you created by using the <a>CreateCertificateAuthority</a>
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAuthorities service method.</param>
        /// 
        /// <returns>The response from the ListCertificateAuthorities service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidNextTokenException">
        /// The token specified in the <code>NextToken</code> argument is not valid. Use the token
        /// returned from your previous call to <a>ListCertificateAuthorities</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListCertificateAuthorities">REST API Reference for ListCertificateAuthorities Operation</seealso>
        ListCertificateAuthoritiesResponse ListCertificateAuthorities(ListCertificateAuthoritiesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAuthorities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListCertificateAuthorities">REST API Reference for ListCertificateAuthorities Operation</seealso>
        Task<ListCertificateAuthoritiesResponse> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists the tags, if any, that are associated with your private CA. Tags are labels
        /// that you can use to identify and organize your CAs. Each tag consists of a key and
        /// an optional value. Call the <a>TagCertificateAuthority</a> function to add one or
        /// more tags to your CA. Call the <a>UntagCertificateAuthority</a> function to remove
        /// tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeCertificate


        /// <summary>
        /// Revokes a certificate that you issued by calling the <a>IssueCertificate</a> function.
        /// If you enable a certificate revocation list (CRL) when you create or update your private
        /// CA, information about the revoked certificates will be included in the CRL. ACM PCA
        /// writes the CRL to an S3 bucket that you specify. For more information about revocation,
        /// see the <a>CrlConfiguration</a> structure. ACM PCA also writes revocation information
        /// to the audit report. For more information, see <a>CreateCertificateAuthorityAuditReport</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeCertificate service method.</param>
        /// 
        /// <returns>The response from the RevokeCertificate service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.ConcurrentModificationException">
        /// A previous update to your private CA is still ongoing.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
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
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        RevokeCertificateResponse RevokeCertificate(RevokeCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        Task<RevokeCertificateResponse> RevokeCertificateAsync(RevokeCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagCertificateAuthority


        /// <summary>
        /// Adds one or more tags to your private CA. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a key and an optional value.
        /// You specify the private CA on input by its Amazon Resource Name (ARN). You specify
        /// the tag by using a key-value pair. You can apply a tag to just one private CA if you
        /// want to identify a specific characteristic of that CA, or you can apply the same tag
        /// to multiple private CAs if you want to filter for a common relationship among those
        /// CAs. To remove one or more tags, use the <a>UntagCertificateAuthority</a> function.
        /// Call the <a>ListTags</a> function to see what tags are associated with your CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the TagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidTagException">
        /// The tag associated with the CA is not valid. The invalid argument is contained in
        /// the message field.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.TooManyTagsException">
        /// You can associate up to 50 tags with a private CA. Exception information is contained
        /// in the exception message field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/TagCertificateAuthority">REST API Reference for TagCertificateAuthority Operation</seealso>
        TagCertificateAuthorityResponse TagCertificateAuthority(TagCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TagCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/TagCertificateAuthority">REST API Reference for TagCertificateAuthority Operation</seealso>
        Task<TagCertificateAuthorityResponse> TagCertificateAuthorityAsync(TagCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagCertificateAuthority


        /// <summary>
        /// Remove one or more tags from your private CA. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value. To add tags to a private CA, use
        /// the <a>TagCertificateAuthority</a>. Call the <a>ListTags</a> function to see what
        /// tags are associated with your CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the UntagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidTagException">
        /// The tag associated with the CA is not valid. The invalid argument is contained in
        /// the message field.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UntagCertificateAuthority">REST API Reference for UntagCertificateAuthority Operation</seealso>
        UntagCertificateAuthorityResponse UntagCertificateAuthority(UntagCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UntagCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UntagCertificateAuthority">REST API Reference for UntagCertificateAuthority Operation</seealso>
        Task<UntagCertificateAuthorityResponse> UntagCertificateAuthorityAsync(UntagCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCertificateAuthority


        /// <summary>
        /// Updates the status or configuration of a private certificate authority (CA). Your
        /// private CA must be in the <b> <code>ACTIVE</code> </b> or <b> <code>DISABLED</code>
        /// </b> state before you can update it. You can disable a private CA that is in the <b>
        /// <code>ACTIVE</code> </b> state or make a CA that is in the <b> <code>DISABLED</code>
        /// </b> state active again.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateAuthority service method.</param>
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
        /// The S3 bucket policy is not valid. The policy must give ACM PCA rights to read from
        /// and write to the bucket and find the bucket location.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UpdateCertificateAuthority">REST API Reference for UpdateCertificateAuthority Operation</seealso>
        UpdateCertificateAuthorityResponse UpdateCertificateAuthority(UpdateCertificateAuthorityRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UpdateCertificateAuthority">REST API Reference for UpdateCertificateAuthority Operation</seealso>
        Task<UpdateCertificateAuthorityResponse> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}