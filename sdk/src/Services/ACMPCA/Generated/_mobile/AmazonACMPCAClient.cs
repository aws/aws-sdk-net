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

#if CORECLR
    
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

#endif

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

        internal virtual CreateCertificateAuthorityResponse CreateCertificateAuthority(CreateCertificateAuthorityRequest request)
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

        internal virtual CreateCertificateAuthorityAuditReportResponse CreateCertificateAuthorityAuditReport(CreateCertificateAuthorityAuditReportRequest request)
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

        internal virtual DeleteCertificateAuthorityResponse DeleteCertificateAuthority(DeleteCertificateAuthorityRequest request)
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

        internal virtual DescribeCertificateAuthorityResponse DescribeCertificateAuthority(DescribeCertificateAuthorityRequest request)
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

        internal virtual DescribeCertificateAuthorityAuditReportResponse DescribeCertificateAuthorityAuditReport(DescribeCertificateAuthorityAuditReportRequest request)
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

        internal virtual GetCertificateResponse GetCertificate(GetCertificateRequest request)
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

        internal virtual GetCertificateAuthorityCertificateResponse GetCertificateAuthorityCertificate(GetCertificateAuthorityCertificateRequest request)
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

        internal virtual GetCertificateAuthorityCsrResponse GetCertificateAuthorityCsr(GetCertificateAuthorityCsrRequest request)
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

        internal virtual ImportCertificateAuthorityCertificateResponse ImportCertificateAuthorityCertificate(ImportCertificateAuthorityCertificateRequest request)
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

        internal virtual IssueCertificateResponse IssueCertificate(IssueCertificateRequest request)
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

        internal virtual ListCertificateAuthoritiesResponse ListCertificateAuthorities(ListCertificateAuthoritiesRequest request)
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

        internal virtual ListTagsResponse ListTags(ListTagsRequest request)
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
        
        #region  RevokeCertificate

        internal virtual RevokeCertificateResponse RevokeCertificate(RevokeCertificateRequest request)
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

        internal virtual TagCertificateAuthorityResponse TagCertificateAuthority(TagCertificateAuthorityRequest request)
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

        internal virtual UntagCertificateAuthorityResponse UntagCertificateAuthority(UntagCertificateAuthorityRequest request)
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

        internal virtual UpdateCertificateAuthorityResponse UpdateCertificateAuthority(UpdateCertificateAuthorityRequest request)
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