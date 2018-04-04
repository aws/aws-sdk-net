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
        /// Initiates the asynchronous execution of the CreateCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthority">REST API Reference for CreateCertificateAuthority Operation</seealso>
        Task<CreateCertificateAuthorityResponse> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCertificateAuthorityAuditReport


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
        Task<CreateCertificateAuthorityAuditReportResponse> CreateCertificateAuthorityAuditReportAsync(CreateCertificateAuthorityAuditReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCertificateAuthority


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
        Task<DeleteCertificateAuthorityResponse> DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificateAuthority


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
        Task<DescribeCertificateAuthorityResponse> DescribeCertificateAuthorityAsync(DescribeCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCertificateAuthorityAuditReport


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
        Task<DescribeCertificateAuthorityAuditReportResponse> DescribeCertificateAuthorityAuditReportAsync(DescribeCertificateAuthorityAuditReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCertificate


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
        Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCertificateAuthorityCertificate


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
        Task<GetCertificateAuthorityCertificateResponse> GetCertificateAuthorityCertificateAsync(GetCertificateAuthorityCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCertificateAuthorityCsr


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
        Task<GetCertificateAuthorityCsrResponse> GetCertificateAuthorityCsrAsync(GetCertificateAuthorityCsrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportCertificateAuthorityCertificate


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
        Task<ImportCertificateAuthorityCertificateResponse> ImportCertificateAuthorityCertificateAsync(ImportCertificateAuthorityCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  IssueCertificate


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
        Task<IssueCertificateResponse> IssueCertificateAsync(IssueCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCertificateAuthorities


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
        Task<ListCertificateAuthoritiesResponse> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags


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
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeCertificate


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
        Task<RevokeCertificateResponse> RevokeCertificateAsync(RevokeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagCertificateAuthority


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
        Task<TagCertificateAuthorityResponse> TagCertificateAuthorityAsync(TagCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagCertificateAuthority


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
        Task<UntagCertificateAuthorityResponse> UntagCertificateAuthorityAsync(UntagCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCertificateAuthority


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
        Task<UpdateCertificateAuthorityResponse> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}