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
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthority operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthority">REST API Reference for CreateCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginCreateCertificateAuthority(CreateCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = CreateCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  CreateCertificateAuthorityResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthority">REST API Reference for CreateCertificateAuthority Operation</seealso>
        public virtual CreateCertificateAuthorityResponse EndCreateCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCertificateAuthorityResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthorityAuditReport operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCertificateAuthorityAuditReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthorityAuditReport">REST API Reference for CreateCertificateAuthorityAuditReport Operation</seealso>
        public virtual IAsyncResult BeginCreateCertificateAuthorityAuditReport(CreateCertificateAuthorityAuditReportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateCertificateAuthorityAuditReportRequestMarshaller.Instance;
            var unmarshaller = CreateCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCertificateAuthorityAuditReportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCertificateAuthorityAuditReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCertificateAuthorityAuditReport.</param>
        /// 
        /// <returns>Returns a  CreateCertificateAuthorityAuditReportResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthorityAuditReport">REST API Reference for CreateCertificateAuthorityAuditReport Operation</seealso>
        public virtual CreateCertificateAuthorityAuditReportResponse EndCreateCertificateAuthorityAuditReport(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCertificateAuthorityAuditReportResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificateAuthority operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeleteCertificateAuthority">REST API Reference for DeleteCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginDeleteCertificateAuthority(DeleteCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = DeleteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateAuthorityResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeleteCertificateAuthority">REST API Reference for DeleteCertificateAuthority Operation</seealso>
        public virtual DeleteCertificateAuthorityResponse EndDeleteCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCertificateAuthorityResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthority operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthority">REST API Reference for DescribeCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginDescribeCertificateAuthority(DescribeCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateAuthorityResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthority">REST API Reference for DescribeCertificateAuthority Operation</seealso>
        public virtual DescribeCertificateAuthorityResponse EndDescribeCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificateAuthorityResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificateAuthorityAuditReport operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificateAuthorityAuditReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthorityAuditReport">REST API Reference for DescribeCertificateAuthorityAuditReport Operation</seealso>
        public virtual IAsyncResult BeginDescribeCertificateAuthorityAuditReport(DescribeCertificateAuthorityAuditReportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeCertificateAuthorityAuditReportRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCertificateAuthorityAuditReportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificateAuthorityAuditReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificateAuthorityAuditReport.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateAuthorityAuditReportResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DescribeCertificateAuthorityAuditReport">REST API Reference for DescribeCertificateAuthorityAuditReport Operation</seealso>
        public virtual DescribeCertificateAuthorityAuditReportResponse EndDescribeCertificateAuthorityAuditReport(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificateAuthorityAuditReportResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual IAsyncResult BeginGetCertificate(GetCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<GetCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCertificate.</param>
        /// 
        /// <returns>Returns a  GetCertificateResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual GetCertificateResponse EndGetCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCertificateResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCertificate operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCertificateAuthorityCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCertificate">REST API Reference for GetCertificateAuthorityCertificate Operation</seealso>
        public virtual IAsyncResult BeginGetCertificateAuthorityCertificate(GetCertificateAuthorityCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCertificateAuthorityCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<GetCertificateAuthorityCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCertificateAuthorityCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCertificateAuthorityCertificate.</param>
        /// 
        /// <returns>Returns a  GetCertificateAuthorityCertificateResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCertificate">REST API Reference for GetCertificateAuthorityCertificate Operation</seealso>
        public virtual GetCertificateAuthorityCertificateResponse EndGetCertificateAuthorityCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCertificateAuthorityCertificateResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCsr operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCertificateAuthorityCsr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCsr">REST API Reference for GetCertificateAuthorityCsr Operation</seealso>
        public virtual IAsyncResult BeginGetCertificateAuthorityCsr(GetCertificateAuthorityCsrRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCertificateAuthorityCsrRequestMarshaller.Instance;
            var unmarshaller = GetCertificateAuthorityCsrResponseUnmarshaller.Instance;

            return BeginInvoke<GetCertificateAuthorityCsrRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCertificateAuthorityCsr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCertificateAuthorityCsr.</param>
        /// 
        /// <returns>Returns a  GetCertificateAuthorityCsrResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCsr">REST API Reference for GetCertificateAuthorityCsr Operation</seealso>
        public virtual GetCertificateAuthorityCsrResponse EndGetCertificateAuthorityCsr(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCertificateAuthorityCsrResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificateAuthorityCertificate operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCertificateAuthorityCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ImportCertificateAuthorityCertificate">REST API Reference for ImportCertificateAuthorityCertificate Operation</seealso>
        public virtual IAsyncResult BeginImportCertificateAuthorityCertificate(ImportCertificateAuthorityCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ImportCertificateAuthorityCertificateRequestMarshaller.Instance;
            var unmarshaller = ImportCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<ImportCertificateAuthorityCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCertificateAuthorityCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCertificateAuthorityCertificate.</param>
        /// 
        /// <returns>Returns a  ImportCertificateAuthorityCertificateResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ImportCertificateAuthorityCertificate">REST API Reference for ImportCertificateAuthorityCertificate Operation</seealso>
        public virtual ImportCertificateAuthorityCertificateResponse EndImportCertificateAuthorityCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportCertificateAuthorityCertificateResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the IssueCertificate operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIssueCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/IssueCertificate">REST API Reference for IssueCertificate Operation</seealso>
        public virtual IAsyncResult BeginIssueCertificate(IssueCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = IssueCertificateRequestMarshaller.Instance;
            var unmarshaller = IssueCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<IssueCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  IssueCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIssueCertificate.</param>
        /// 
        /// <returns>Returns a  IssueCertificateResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/IssueCertificate">REST API Reference for IssueCertificate Operation</seealso>
        public virtual IssueCertificateResponse EndIssueCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<IssueCertificateResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the ListCertificateAuthorities operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificateAuthorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListCertificateAuthorities">REST API Reference for ListCertificateAuthorities Operation</seealso>
        public virtual IAsyncResult BeginListCertificateAuthorities(ListCertificateAuthoritiesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListCertificateAuthoritiesRequestMarshaller.Instance;
            var unmarshaller = ListCertificateAuthoritiesResponseUnmarshaller.Instance;

            return BeginInvoke<ListCertificateAuthoritiesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificateAuthorities.</param>
        /// 
        /// <returns>Returns a  ListCertificateAuthoritiesResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListCertificateAuthorities">REST API Reference for ListCertificateAuthorities Operation</seealso>
        public virtual ListCertificateAuthoritiesResponse EndListCertificateAuthorities(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCertificateAuthoritiesResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the RevokeCertificate operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        public virtual IAsyncResult BeginRevokeCertificate(RevokeCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RevokeCertificateRequestMarshaller.Instance;
            var unmarshaller = RevokeCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<RevokeCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeCertificate.</param>
        /// 
        /// <returns>Returns a  RevokeCertificateResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RevokeCertificate">REST API Reference for RevokeCertificate Operation</seealso>
        public virtual RevokeCertificateResponse EndRevokeCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeCertificateResponse>(asyncResult);
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
        /// <param name="request">Container for the necessary parameters to execute the TagCertificateAuthority operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/TagCertificateAuthority">REST API Reference for TagCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginTagCertificateAuthority(TagCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = TagCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = TagCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<TagCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  TagCertificateAuthorityResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/TagCertificateAuthority">REST API Reference for TagCertificateAuthority Operation</seealso>
        public virtual TagCertificateAuthorityResponse EndTagCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<TagCertificateAuthorityResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the UntagCertificateAuthority operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UntagCertificateAuthority">REST API Reference for UntagCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginUntagCertificateAuthority(UntagCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UntagCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = UntagCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<UntagCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  UntagCertificateAuthorityResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UntagCertificateAuthority">REST API Reference for UntagCertificateAuthority Operation</seealso>
        public virtual UntagCertificateAuthorityResponse EndUntagCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagCertificateAuthorityResponse>(asyncResult);
        }

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
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateAuthority operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UpdateCertificateAuthority">REST API Reference for UpdateCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginUpdateCertificateAuthority(UpdateCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateCertificateAuthorityRequestMarshaller.Instance;
            var unmarshaller = UpdateCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateCertificateAuthorityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  UpdateCertificateAuthorityResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UpdateCertificateAuthority">REST API Reference for UpdateCertificateAuthority Operation</seealso>
        public virtual UpdateCertificateAuthorityResponse EndUpdateCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
    }
}