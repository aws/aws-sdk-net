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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ACMPCA.Model;
using Amazon.ACMPCA.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ACMPCA
{
    /// <summary>
    /// Implementation for accessing ACMPCA
    ///
    /// You can use the ACM PCA API to create a private certificate authority (CA). You must
    /// first call the <a>CreateCertificateAuthority</a> operation. If successful, the operation
    /// returns an Amazon Resource Name (ARN) for your private CA. Use this ARN as input to
    /// the <a>GetCertificateAuthorityCsr</a> operation to retrieve the certificate signing
    /// request (CSR) for your private CA certificate. Sign the CSR using the root or an intermediate
    /// CA in your on-premises PKI hierarchy, and call the <a>ImportCertificateAuthorityCertificate</a>
    /// to import your signed private CA certificate into ACM PCA. 
    /// 
    ///  
    /// <para>
    /// Use your private CA to issue and revoke certificates. These are private certificates
    /// that identify and secure client computers, servers, applications, services, devices,
    /// and users over SSLS/TLS connections within your organization. Call the <a>IssueCertificate</a>
    /// operation to issue a certificate. Call the <a>RevokeCertificate</a> operation to revoke
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
    /// object when you call the <a>CreateCertificateAuthority</a> operation. ACM PCA writes
    /// the CRL to an S3 bucket that you specify. You must specify a bucket policy that grants
    /// ACM PCA write permission. 
    /// </para>
    ///  
    /// <para>
    /// You can also call the <a>CreateCertificateAuthorityAuditReport</a> to create an optional
    /// audit report that lists every time the CA private key is used. The private key is
    /// used for signing when the <b>IssueCertificate</b> or <b>RevokeCertificate</b> operation
    /// is called. 
    /// </para>
    /// </summary>
    public partial class AmazonACMPCAClient : AmazonServiceClient, IAmazonACMPCA
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonACMPCAClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonACMPCAClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonACMPCAConfig()) { }

        /// <summary>
        /// Constructs AmazonACMPCAClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonACMPCAClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonACMPCAConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonACMPCAClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonACMPCAClient Configuration Object</param>
        public AmazonACMPCAClient(AmazonACMPCAConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonACMPCAClient(AWSCredentials credentials)
            : this(credentials, new AmazonACMPCAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonACMPCAClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonACMPCAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Credentials and an
        /// AmazonACMPCAClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonACMPCAClient Configuration Object</param>
        public AmazonACMPCAClient(AWSCredentials credentials, AmazonACMPCAConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonACMPCAClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonACMPCAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonACMPCAClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonACMPCAConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonACMPCAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonACMPCAClient Configuration Object</param>
        public AmazonACMPCAClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonACMPCAConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonACMPCAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonACMPCAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonACMPCAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonACMPCAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonACMPCAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonACMPCAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonACMPCAClient Configuration Object</param>
        public AmazonACMPCAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonACMPCAConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    


        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateCertificateAuthority


        /// <summary>
        /// Creates a private subordinate certificate authority (CA). You must specify the CA
        /// configuration, the revocation configuration, the CA type, and an optional idempotency
        /// token. The CA configuration specifies the name of the algorithm and key size to be
        /// used to create the CA private key, the type of signing algorithm that the CA uses
        /// to sign, and X.500 subject information. The CRL (certificate revocation list) configuration
        /// specifies the CRL expiration period in days (the validity period of the CRL), the
        /// Amazon S3 bucket that will contain the CRL, and a CNAME alias for the S3 bucket that
        /// is included in certificates issued by the CA. If successful, this operation returns
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
        public virtual CreateCertificateAuthorityResponse CreateCertificateAuthority(CreateCertificateAuthorityRequest request)
        {
            var marshaller = CreateCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = CreateCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<CreateCertificateAuthorityRequest,CreateCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateCertificateAuthorityResponse> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = CreateCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCertificateAuthorityRequest,CreateCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCertificateAuthorityAuditReport


        /// <summary>
        /// Creates an audit report that lists every time that the your CA private key is used.
        /// The report is saved in the Amazon S3 bucket that you specify on input. The <a>IssueCertificate</a>
        /// and <a>RevokeCertificate</a> operations use the private key. You can generate a new
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
        public virtual CreateCertificateAuthorityAuditReportResponse CreateCertificateAuthorityAuditReport(CreateCertificateAuthorityAuditReportRequest request)
        {
            var marshaller = CreateCertificateAuthorityAuditReportRequestMarshaller.Instance;
            var unmarshaller = CreateCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return Invoke<CreateCertificateAuthorityAuditReportRequest,CreateCertificateAuthorityAuditReportResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<CreateCertificateAuthorityAuditReportResponse> CreateCertificateAuthorityAuditReportAsync(CreateCertificateAuthorityAuditReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCertificateAuthorityAuditReportRequestMarshaller.Instance;
            var unmarshaller = CreateCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCertificateAuthorityAuditReportRequest,CreateCertificateAuthorityAuditReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificateAuthority


        /// <summary>
        /// Deletes a private certificate authority (CA). You must provide the ARN (Amazon Resource
        /// Name) of the private CA that you want to delete. You can find the ARN by calling the
        /// <a>ListCertificateAuthorities</a> operation. Before you can delete a CA, you must
        /// disable it. Call the <a>UpdateCertificateAuthority</a> operation and set the <b>CertificateAuthorityStatus</b>
        /// parameter to <code>DISABLED</code>. 
        /// 
        ///  
        /// <para>
        /// Additionally, you can delete a CA if you are waiting for it to be created (the <b>Status</b>
        /// field of the <a>CertificateAuthority</a> is <code>CREATING</code>). You can also delete
        /// it if the CA has been created but you haven't yet imported the signed certificate
        /// (the <b>Status</b> is <code>PENDING_CERTIFICATE</code>) into ACM PCA. 
        /// </para>
        ///  
        /// <para>
        /// If the CA is in one of the aforementioned states and you call <a>DeleteCertificateAuthority</a>,
        /// the CA's status changes to <code>DELETED</code>. However, the CA won't be permentantly
        /// deleted until the restoration period has passed. By default, if you do not set the
        /// <code>PermanentDeletionTimeInDays</code> parameter, the CA remains restorable for
        /// 30 days. You can set the parameter from 7 to 30 days. The <a>DescribeCertificateAuthority</a>
        /// operation returns the time remaining in the restoration window of a Private CA in
        /// the <code>DELETED</code> state. To restore an eligable CA, call the <a>RestoreCertificateAuthority</a>
        /// operation.
        /// </para>
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
        public virtual DeleteCertificateAuthorityResponse DeleteCertificateAuthority(DeleteCertificateAuthorityRequest request)
        {
            var marshaller = DeleteCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = DeleteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateAuthorityRequest,DeleteCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DeleteCertificateAuthorityResponse> DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = DeleteCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCertificateAuthorityRequest,DeleteCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificateAuthority


        /// <summary>
        /// Lists information about your private certificate authority (CA). You specify the private
        /// CA on input by its ARN (Amazon Resource Name). The output contains the status of your
        /// CA. This can be any of the following: 
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATING</code> - ACM PCA is creating your private certificate authority.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_CERTIFICATE</code> - The certificate is pending. You must use your
        /// on-premises root or subordinate CA to sign your private CA CSR and then import it
        /// into PCA. 
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
        /// such a network outage or backend AWS failure or other errors. A failed CA can never
        /// return to the pending state. You must create a new CA. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETED</code> - Your private CA is within the restoration period, after which
        /// it will be permanently deleted. The length of time remaining in the CA's restoration
        /// period will also be included in this operation's output.
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
        public virtual DescribeCertificateAuthorityResponse DescribeCertificateAuthority(DescribeCertificateAuthorityRequest request)
        {
            var marshaller = DescribeCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateAuthorityRequest,DescribeCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeCertificateAuthorityResponse> DescribeCertificateAuthorityAsync(DescribeCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificateAuthorityRequest,DescribeCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificateAuthorityAuditReport


        /// <summary>
        /// Lists information about a specific audit report created by calling the <a>CreateCertificateAuthorityAuditReport</a>
        /// operation. Audit information is created every time the certificate authority (CA)
        /// private key is used. The private key is used when you call the <a>IssueCertificate</a>
        /// operation or the <a>RevokeCertificate</a> operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthorityAuditReport service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificateAuthorityAuditReport service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthorityAuditReport">REST API Reference for DescribeCertificateAuthorityAuditReport Operation</seealso>
        public virtual DescribeCertificateAuthorityAuditReportResponse DescribeCertificateAuthorityAuditReport(DescribeCertificateAuthorityAuditReportRequest request)
        {
            var marshaller = DescribeCertificateAuthorityAuditReportRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateAuthorityAuditReportRequest,DescribeCertificateAuthorityAuditReportResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<DescribeCertificateAuthorityAuditReportResponse> DescribeCertificateAuthorityAuditReportAsync(DescribeCertificateAuthorityAuditReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCertificateAuthorityAuditReportRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificateAuthorityAuditReportRequest,DescribeCertificateAuthorityAuditReportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCertificate


        /// <summary>
        /// Retrieves a certificate from your private CA. The ARN of the certificate is returned
        /// when you call the <a>IssueCertificate</a> operation. You must specify both the ARN
        /// of your private CA and the ARN of the issued certificate when calling the <b>GetCertificate</b>
        /// operation. You can retrieve the certificate if it is in the <b>ISSUED</b> state. You
        /// can call the <a>CreateCertificateAuthorityAuditReport</a> operation to create a report
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
        public virtual GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            var marshaller = GetCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateRequest,GetCertificateResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCertificateRequest,GetCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public virtual GetCertificateAuthorityCertificateResponse GetCertificateAuthorityCertificate(GetCertificateAuthorityCertificateRequest request)
        {
            var marshaller = GetCertificateAuthorityCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateAuthorityCertificateRequest,GetCertificateAuthorityCertificateResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<GetCertificateAuthorityCertificateResponse> GetCertificateAuthorityCertificateAsync(GetCertificateAuthorityCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCertificateAuthorityCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCertificateAuthorityCertificateRequest,GetCertificateAuthorityCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCertificateAuthorityCsr


        /// <summary>
        /// Retrieves the certificate signing request (CSR) for your private certificate authority
        /// (CA). The CSR is created when you call the <a>CreateCertificateAuthority</a> operation.
        /// Take the CSR to your on-premises X.509 infrastructure and sign it by using your root
        /// or a subordinate CA. Then import the signed certificate back into ACM PCA by calling
        /// the <a>ImportCertificateAuthorityCertificate</a> operation. The CSR is returned as
        /// a base64 PEM-encoded string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCsr service method.</param>
        /// 
        /// <returns>The response from the GetCertificateAuthorityCsr service method, as returned by ACMPCA.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCsr">REST API Reference for GetCertificateAuthorityCsr Operation</seealso>
        public virtual GetCertificateAuthorityCsrResponse GetCertificateAuthorityCsr(GetCertificateAuthorityCsrRequest request)
        {
            var marshaller = GetCertificateAuthorityCsrRequestMarshaller.Instance;
            var unmarshaller = GetCertificateAuthorityCsrResponseUnmarshaller.Instance;

            return Invoke<GetCertificateAuthorityCsrRequest,GetCertificateAuthorityCsrResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<GetCertificateAuthorityCsrResponse> GetCertificateAuthorityCsrAsync(GetCertificateAuthorityCsrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCertificateAuthorityCsrRequestMarshaller.Instance;
            var unmarshaller = GetCertificateAuthorityCsrResponseUnmarshaller.Instance;

            return InvokeAsync<GetCertificateAuthorityCsrRequest,GetCertificateAuthorityCsrResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportCertificateAuthorityCertificate


        /// <summary>
        /// Imports your signed private CA certificate into ACM PCA. Before you can call this
        /// operation, you must create the private certificate authority by calling the <a>CreateCertificateAuthority</a>
        /// operation. You must then generate a certificate signing request (CSR) by calling the
        /// <a>GetCertificateAuthorityCsr</a> operation. Take the CSR to your on-premises CA and
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
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
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
        public virtual ImportCertificateAuthorityCertificateResponse ImportCertificateAuthorityCertificate(ImportCertificateAuthorityCertificateRequest request)
        {
            var marshaller = ImportCertificateAuthorityCertificateRequestMarshaller.Instance;
            var unmarshaller = ImportCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateAuthorityCertificateRequest,ImportCertificateAuthorityCertificateResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ImportCertificateAuthorityCertificateResponse> ImportCertificateAuthorityCertificateAsync(ImportCertificateAuthorityCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportCertificateAuthorityCertificateRequestMarshaller.Instance;
            var unmarshaller = ImportCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCertificateAuthorityCertificateRequest,ImportCertificateAuthorityCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  IssueCertificate


        /// <summary>
        /// Uses your private certificate authority (CA) to issue a client certificate. This operation
        /// returns the Amazon Resource Name (ARN) of the certificate. You can retrieve the certificate
        /// by calling the <a>GetCertificate</a> operation and specifying the ARN. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use the ACM <b>ListCertificateAuthorities</b> operation to retrieve the
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
        public virtual IssueCertificateResponse IssueCertificate(IssueCertificateRequest request)
        {
            var marshaller = IssueCertificateRequestMarshaller.Instance;
            var unmarshaller = IssueCertificateResponseUnmarshaller.Instance;

            return Invoke<IssueCertificateRequest,IssueCertificateResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<IssueCertificateResponse> IssueCertificateAsync(IssueCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = IssueCertificateRequestMarshaller.Instance;
            var unmarshaller = IssueCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<IssueCertificateRequest,IssueCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCertificateAuthorities


        /// <summary>
        /// Lists the private certificate authorities that you created by using the <a>CreateCertificateAuthority</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAuthorities service method.</param>
        /// 
        /// <returns>The response from the ListCertificateAuthorities service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidNextTokenException">
        /// The token specified in the <code>NextToken</code> argument is not valid. Use the token
        /// returned from your previous call to <a>ListCertificateAuthorities</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListCertificateAuthorities">REST API Reference for ListCertificateAuthorities Operation</seealso>
        public virtual ListCertificateAuthoritiesResponse ListCertificateAuthorities(ListCertificateAuthoritiesRequest request)
        {
            var marshaller = ListCertificateAuthoritiesRequestMarshaller.Instance;
            var unmarshaller = ListCertificateAuthoritiesResponseUnmarshaller.Instance;

            return Invoke<ListCertificateAuthoritiesRequest,ListCertificateAuthoritiesResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListCertificateAuthoritiesResponse> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListCertificateAuthoritiesRequestMarshaller.Instance;
            var unmarshaller = ListCertificateAuthoritiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificateAuthoritiesRequest,ListCertificateAuthoritiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Lists the tags, if any, that are associated with your private CA. Tags are labels
        /// that you can use to identify and organize your CAs. Each tag consists of a key and
        /// an optional value. Call the <a>TagCertificateAuthority</a> operation to add one or
        /// more tags to your CA. Call the <a>UntagCertificateAuthority</a> operation to remove
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
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsRequest,ListTagsResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsRequest,ListTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreCertificateAuthority


        /// <summary>
        /// Restores a certificate authority (CA) that is in the <code>DELETED</code> state. You
        /// can restore a CA during the period that you defined in the <b>PermanentDeletionTimeInDays</b>
        /// parameter of the <a>DeleteCertificateAuthority</a> operation. Currently, you can specify
        /// 7 to 30 days. If you did not specify a <b>PermanentDeletionTimeInDays</b> value, by
        /// default you can restore the CA at any time in a 30 day period. You can check the time
        /// remaining in the restoration period of a private CA in the <code>DELETED</code> state
        /// by calling the <a>DescribeCertificateAuthority</a> or <a>ListCertificateAuthorities</a>
        /// operations. The status of a restored CA is set to its pre-deletion status when the
        /// <b>RestoreCertificateAuthority</b> operation returns. To change its status to <code>ACTIVE</code>,
        /// call the <a>UpdateCertificateAuthority</a> operation. If the private CA was in the
        /// <code>PENDING_CERTIFICATE</code> state at deletion, you must use the <a>ImportCertificateAuthorityCertificate</a>
        /// operation to import a certificate authority into the private CA before it can be activated.
        /// You cannot restore a CA after the restoration period has ended.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the RestoreCertificateAuthority service method, as returned by ACMPCA.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RestoreCertificateAuthority">REST API Reference for RestoreCertificateAuthority Operation</seealso>
        public virtual RestoreCertificateAuthorityResponse RestoreCertificateAuthority(RestoreCertificateAuthorityRequest request)
        {
            var marshaller = RestoreCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = RestoreCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<RestoreCertificateAuthorityRequest,RestoreCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RestoreCertificateAuthority">REST API Reference for RestoreCertificateAuthority Operation</seealso>
        public virtual Task<RestoreCertificateAuthorityResponse> RestoreCertificateAuthorityAsync(RestoreCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = RestoreCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreCertificateAuthorityRequest,RestoreCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeCertificate


        /// <summary>
        /// Revokes a certificate that you issued by calling the <a>IssueCertificate</a> operation.
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
        public virtual RevokeCertificateResponse RevokeCertificate(RevokeCertificateRequest request)
        {
            var marshaller = RevokeCertificateRequestMarshaller.Instance;
            var unmarshaller = RevokeCertificateResponseUnmarshaller.Instance;

            return Invoke<RevokeCertificateRequest,RevokeCertificateResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<RevokeCertificateResponse> RevokeCertificateAsync(RevokeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RevokeCertificateRequestMarshaller.Instance;
            var unmarshaller = RevokeCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeCertificateRequest,RevokeCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagCertificateAuthority


        /// <summary>
        /// Adds one or more tags to your private CA. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a key and an optional value.
        /// You specify the private CA on input by its Amazon Resource Name (ARN). You specify
        /// the tag by using a key-value pair. You can apply a tag to just one private CA if you
        /// want to identify a specific characteristic of that CA, or you can apply the same tag
        /// to multiple private CAs if you want to filter for a common relationship among those
        /// CAs. To remove one or more tags, use the <a>UntagCertificateAuthority</a> operation.
        /// Call the <a>ListTags</a> operation to see what tags are associated with your CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the TagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
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
        public virtual TagCertificateAuthorityResponse TagCertificateAuthority(TagCertificateAuthorityRequest request)
        {
            var marshaller = TagCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = TagCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<TagCertificateAuthorityRequest,TagCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<TagCertificateAuthorityResponse> TagCertificateAuthorityAsync(TagCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = TagCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<TagCertificateAuthorityRequest,TagCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagCertificateAuthority


        /// <summary>
        /// Remove one or more tags from your private CA. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this operation, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value. To add tags to a private CA, use
        /// the <a>TagCertificateAuthority</a>. Call the <a>ListTags</a> operation to see what
        /// tags are associated with your CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the UntagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report cannot be generated.
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
        public virtual UntagCertificateAuthorityResponse UntagCertificateAuthority(UntagCertificateAuthorityRequest request)
        {
            var marshaller = UntagCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = UntagCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<UntagCertificateAuthorityRequest,UntagCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<UntagCertificateAuthorityResponse> UntagCertificateAuthorityAsync(UntagCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = UntagCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<UntagCertificateAuthorityRequest,UntagCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCertificateAuthority


        /// <summary>
        /// Updates the status or configuration of a private certificate authority (CA). Your
        /// private CA must be in the <code>ACTIVE</code> or <code>DISABLED</code> state before
        /// you can update it. You can disable a private CA that is in the <code>ACTIVE</code>
        /// state or make a CA that is in the <code>DISABLED</code> state active again.
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
        public virtual UpdateCertificateAuthorityResponse UpdateCertificateAuthority(UpdateCertificateAuthorityRequest request)
        {
            var marshaller = UpdateCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = UpdateCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<UpdateCertificateAuthorityRequest,UpdateCertificateAuthorityResponse>(request, marshaller, unmarshaller);
        }

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
        public virtual Task<UpdateCertificateAuthorityResponse> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = UpdateCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCertificateAuthorityRequest,UpdateCertificateAuthorityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}