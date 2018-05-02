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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CertificateManager.Model;
using Amazon.CertificateManager.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CertificateManager
{
    /// <summary>
    /// Implementation for accessing CertificateManager
    ///
    /// AWS Certificate Manager 
    /// <para>
    /// Welcome to the AWS Certificate Manager (ACM) API documentation.
    /// </para>
    ///  
    /// <para>
    /// You can use ACM to manage SSL/TLS certificates for your AWS-based websites and applications.
    /// For general information about using ACM, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/">
    /// <i>AWS Certificate Manager User Guide</i> </a>.
    /// </para>
    /// </summary>
    public partial class AmazonCertificateManagerClient : AmazonServiceClient, IAmazonCertificateManager
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
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
        public AmazonCertificateManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCertificateManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
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
        public AmazonCertificateManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCertificateManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AmazonCertificateManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials and an
        /// AmazonCertificateManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, AmazonCertificateManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCertificateManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCertificateManagerConfig clientConfig)
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

        
        #region  AddTagsToCertificate


        /// <summary>
        /// Adds one or more tags to an ACM certificate. Tags are labels that you can use to identify
        /// and organize your AWS resources. Each tag consists of a <code>key</code> and an optional
        /// <code>value</code>. You specify the certificate on input by its Amazon Resource Name
        /// (ARN). You specify the tag by using a key-value pair. 
        /// 
        ///  
        /// <para>
        /// You can apply a tag to just one certificate if you want to identify a specific characteristic
        /// of that certificate, or you can apply the same tag to multiple certificates if you
        /// want to filter for a common relationship among those certificates. Similarly, you
        /// can apply the same tag to multiple resources if you want to specify a relationship
        /// among those resources. For example, you can add the same tag to an ACM certificate
        /// and an Elastic Load Balancing load balancer to indicate that they are both used by
        /// the same website. For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
        /// ACM certificates</a>. 
        /// </para>
        ///  
        /// <para>
        /// To remove one or more tags, use the <a>RemoveTagsFromCertificate</a> action. To view
        /// all of the tags that have been applied to the certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate service method.</param>
        /// 
        /// <returns>The response from the AddTagsToCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        public virtual AddTagsToCertificateResponse AddTagsToCertificate(AddTagsToCertificateRequest request)
        {
            var marshaller = AddTagsToCertificateRequestMarshaller.Instance;
            var unmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return Invoke<AddTagsToCertificateRequest,AddTagsToCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/AddTagsToCertificate">REST API Reference for AddTagsToCertificate Operation</seealso>
        public virtual Task<AddTagsToCertificateResponse> AddTagsToCertificateAsync(AddTagsToCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddTagsToCertificateRequestMarshaller.Instance;
            var unmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToCertificateRequest,AddTagsToCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by AWS services integrated with ACM. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM certificate to be deleted. This must be of the form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove the
        /// association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse DeleteCertificate(string certificateArn)
        {
            var request = new DeleteCertificateRequest();
            request.CertificateArn = certificateArn;
            return DeleteCertificate(request);
        }


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by AWS services integrated with ACM. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove the
        /// association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var marshaller = DeleteCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateRequest,DeleteCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes a certificate and its associated private key. If this action succeeds, the
        /// certificate no longer appears in the list that can be displayed by calling the <a>ListCertificates</a>
        /// action or be retrieved by calling the <a>GetCertificate</a> action. The certificate
        /// will not be available for use by AWS services integrated with ACM. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM certificate to be deleted. This must be of the form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove the
        /// association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteCertificateRequest();
            request.CertificateArn = certificateArn;
            return DeleteCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCertificateRequest,DeleteCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificate


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// </summary>
        /// <param name="certificateArn">The Amazon Resource Name (ARN) of the ACM certificate. The ARN must have the following form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse DescribeCertificate(string certificateArn)
        {
            var request = new DescribeCertificateRequest();
            request.CertificateArn = certificateArn;
            return DescribeCertificate(request);
        }


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var marshaller = DescribeCertificateRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateRequest,DescribeCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Returns detailed metadata about the specified ACM certificate.
        /// </summary>
        /// <param name="certificateArn">The Amazon Resource Name (ARN) of the ACM certificate. The ARN must have the following form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeCertificateRequest();
            request.CertificateArn = certificateArn;
            return DescribeCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        public virtual Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCertificateRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificateRequest,DescribeCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ExportCertificate


        /// <summary>
        /// Exports a private certificate issued by a private certificate authority (CA) for use
        /// anywhere. You can export the certificate, the certificate chain, and the encrypted
        /// private key associated with the public key embedded in the certificate. You must store
        /// the private key securely. The private key is a 2048 bit RSA key. You must provide
        /// a passphrase for the private key when exporting it. You can use the following OpenSSL
        /// command to decrypt it later. Provide the passphrase when prompted. 
        /// 
        ///  
        /// <para>
        ///  <code>openssl rsa -in encrypted_key.pem -out decrypted_key.pem</code> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportCertificate service method.</param>
        /// 
        /// <returns>The response from the ExportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ExportCertificate">REST API Reference for ExportCertificate Operation</seealso>
        public virtual ExportCertificateResponse ExportCertificate(ExportCertificateRequest request)
        {
            var marshaller = ExportCertificateRequestMarshaller.Instance;
            var unmarshaller = ExportCertificateResponseUnmarshaller.Instance;

            return Invoke<ExportCertificateRequest,ExportCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ExportCertificate">REST API Reference for ExportCertificate Operation</seealso>
        public virtual Task<ExportCertificateResponse> ExportCertificateAsync(ExportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ExportCertificateRequestMarshaller.Instance;
            var unmarshaller = ExportCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ExportCertificateRequest,ExportCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetCertificate


        /// <summary>
        /// Retrieves a certificate specified by an ARN and its certificate chain . The chain
        /// is an ordered list of certificates that contains the end entity certificate, intermediate
        /// certificates of subordinate CAs, and the root certificate in that order. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate to
        /// see the individual fields, you can use OpenSSL.
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual GetCertificateResponse GetCertificate(string certificateArn)
        {
            var request = new GetCertificateRequest();
            request.CertificateArn = certificateArn;
            return GetCertificate(request);
        }


        /// <summary>
        /// Retrieves a certificate specified by an ARN and its certificate chain . The chain
        /// is an ordered list of certificates that contains the end entity certificate, intermediate
        /// certificates of subordinate CAs, and the root certificate in that order. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate to
        /// see the individual fields, you can use OpenSSL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            var marshaller = GetCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateRequest,GetCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a certificate specified by an ARN and its certificate chain . The chain
        /// is an ordered list of certificates that contains the end entity certificate, intermediate
        /// certificates of subordinate CAs, and the root certificate in that order. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate to
        /// see the individual fields, you can use OpenSSL.
        /// </summary>
        /// <param name="certificateArn">String that contains a certificate ARN in the following format:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual Task<GetCertificateResponse> GetCertificateAsync(string certificateArn, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCertificateRequest();
            request.CertificateArn = certificateArn;
            return GetCertificateAsync(request, cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/GetCertificate">REST API Reference for GetCertificate Operation</seealso>
        public virtual Task<GetCertificateResponse> GetCertificateAsync(GetCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetCertificateRequestMarshaller.Instance;
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetCertificateRequest,GetCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportCertificate


        /// <summary>
        /// Imports a certificate into AWS Certificate Manager (ACM) to use with services that
        /// are integrated with ACM. Note that <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">integrated
        /// services</a> allow only certificate types and keys they support to be associated with
        /// their resources. Further, their support differs depending on whether the certificate
        /// is imported into IAM or into ACM. For more information, see the documentation for
        /// each service. For more information about importing certificates into ACM, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>AWS Certificate Manager User Guide</i>. 
        /// 
        ///  <note> 
        /// <para>
        /// ACM does not provide <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for certificates that you import.
        /// </para>
        ///  </note> 
        /// <para>
        /// Note the following guidelines when importing third party certificates:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You must enter the private key that matches the certificate you are importing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The private key must be unencrypted. You cannot import a private key that is protected
        /// by a password or a passphrase.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the certificate you are importing is not self-signed, you must enter its certificate
        /// chain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a certificate chain is included, the issuer must be the subject of one of the certificates
        /// in the chain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The certificate, private key, and certificate chain must be PEM-encoded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The current time must be between the <code>Not Before</code> and <code>Not After</code>
        /// certificate fields.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Issuer</code> field must not be empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The OCSP authority URL, if present, must not exceed 1000 characters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To import a new certificate, omit the <code>CertificateArn</code> argument. Include
        /// this argument only when you want to replace a previously imported certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using the CLI, you must specify the certificate,
        /// the certificate chain, and the private key by their file names preceded by <code>file://</code>.
        /// For example, you can specify a certificate saved in the <code>C:\temp</code> folder
        /// as <code>file://C:\temp\certificate_to_import.pem</code>. If you are making an HTTP
        /// or HTTPS Query request, include these arguments as BLOBs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you import a certificate by using an SDK, you must specify the certificate, the
        /// certificate chain, and the private key files in the manner required by the programming
        /// language you're using. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation returns the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the imported certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var marshaller = ImportCertificateRequestMarshaller.Instance;
            var unmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateRequest,ImportCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportCertificateRequestMarshaller.Instance;
            var unmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCertificateRequest,ImportCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListCertificates


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate.
        /// </summary>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse ListCertificates()
        {
            return ListCertificates(new ListCertificatesRequest());
        }


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var marshaller = ListCertificatesRequestMarshaller.Instance;
            var unmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesRequest,ListCertificatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Retrieves a list of certificate ARNs and domain names. You can request that only certificates
        /// that match a specific status be listed. You can also filter by specific attributes
        /// of the certificate.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListCertificatesAsync(new ListCertificatesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        public virtual Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListCertificatesRequestMarshaller.Instance;
            var unmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListCertificatesRequest,ListCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForCertificate


        /// <summary>
        /// Lists the tags that have been applied to the ACM certificate. Use the certificate's
        /// Amazon Resource Name (ARN) to specify the certificate. To add a tag to an ACM certificate,
        /// use the <a>AddTagsToCertificate</a> action. To delete a tag, use the <a>RemoveTagsFromCertificate</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate service method.</param>
        /// 
        /// <returns>The response from the ListTagsForCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        public virtual ListTagsForCertificateResponse ListTagsForCertificate(ListTagsForCertificateRequest request)
        {
            var marshaller = ListTagsForCertificateRequestMarshaller.Instance;
            var unmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return Invoke<ListTagsForCertificateRequest,ListTagsForCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ListTagsForCertificate">REST API Reference for ListTagsForCertificate Operation</seealso>
        public virtual Task<ListTagsForCertificateResponse> ListTagsForCertificateAsync(ListTagsForCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForCertificateRequestMarshaller.Instance;
            var unmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForCertificateRequest,ListTagsForCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromCertificate


        /// <summary>
        /// Remove one or more tags from an ACM certificate. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value. 
        /// 
        ///  
        /// <para>
        /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
        /// all of the tags that have been applied to a specific ACM certificate, use the <a>ListTagsForCertificate</a>
        /// action. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate service method.</param>
        /// 
        /// <returns>The response from the RemoveTagsFromCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidTagException">
        /// One or both of the values that make up the key-value pair is not valid. For example,
        /// you cannot specify a tag value that begins with <code>aws:</code>.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        public virtual RemoveTagsFromCertificateResponse RemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request)
        {
            var marshaller = RemoveTagsFromCertificateRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromCertificateRequest,RemoveTagsFromCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RemoveTagsFromCertificate">REST API Reference for RemoveTagsFromCertificate Operation</seealso>
        public virtual Task<RemoveTagsFromCertificateResponse> RemoveTagsFromCertificateAsync(RemoveTagsFromCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveTagsFromCertificateRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromCertificateRequest,RemoveTagsFromCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestCertificate


        /// <summary>
        /// Requests an ACM certificate for use with other AWS services. To request an ACM certificate,
        /// you must specify a fully qualified domain name (FQDN) in the <code>DomainName</code>
        /// parameter. You can also specify additional FQDNs in the <code>SubjectAlternativeNames</code>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="http://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="http://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation. ACM issues public certificates
        /// after receiving approval from the domain owner. 
        /// </para>
        /// </summary>
        /// <param name="domainName"> Fully qualified domain name (FQDN), such as www.example.com, that you want to secure with an ACM certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.   The first domain name you enter cannot exceed 63 octets, including periods. Each subsequent Subject Alternative Name (SAN), however, can be up to 253 octets in length. </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual RequestCertificateResponse RequestCertificate(string domainName)
        {
            var request = new RequestCertificateRequest();
            request.DomainName = domainName;
            return RequestCertificate(request);
        }


        /// <summary>
        /// Requests an ACM certificate for use with other AWS services. To request an ACM certificate,
        /// you must specify a fully qualified domain name (FQDN) in the <code>DomainName</code>
        /// parameter. You can also specify additional FQDNs in the <code>SubjectAlternativeNames</code>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="http://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="http://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation. ACM issues public certificates
        /// after receiving approval from the domain owner. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual RequestCertificateResponse RequestCertificate(RequestCertificateRequest request)
        {
            var marshaller = RequestCertificateRequestMarshaller.Instance;
            var unmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return Invoke<RequestCertificateRequest,RequestCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Requests an ACM certificate for use with other AWS services. To request an ACM certificate,
        /// you must specify a fully qualified domain name (FQDN) in the <code>DomainName</code>
        /// parameter. You can also specify additional FQDNs in the <code>SubjectAlternativeNames</code>
        /// parameter. 
        /// 
        ///  
        /// <para>
        /// If you are requesting a private certificate, domain validation is not required. If
        /// you are requesting a public certificate, each domain name that you specify must be
        /// validated to verify that you own or control the domain. You can use <a href="http://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-dns.html">DNS
        /// validation</a> or <a href="http://docs.aws.amazon.com/acm/latest/userguide/gs-acm-validate-email.html">email
        /// validation</a>. We recommend that you use DNS validation. ACM issues public certificates
        /// after receiving approval from the domain owner. 
        /// </para>
        /// </summary>
        /// <param name="domainName"> Fully qualified domain name (FQDN), such as www.example.com, that you want to secure with an ACM certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.   The first domain name you enter cannot exceed 63 octets, including periods. Each subsequent Subject Alternative Name (SAN), however, can be up to 253 octets in length. </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual Task<RequestCertificateResponse> RequestCertificateAsync(string domainName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RequestCertificateRequest();
            request.DomainName = domainName;
            return RequestCertificateAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/RequestCertificate">REST API Reference for RequestCertificate Operation</seealso>
        public virtual Task<RequestCertificateResponse> RequestCertificateAsync(RequestCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RequestCertificateRequestMarshaller.Instance;
            var unmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<RequestCertificateRequest,RequestCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResendValidationEmail


        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or an
        /// authorized representative must approve the ACM certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
        /// For more information about setting up your contact email addresses, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/setup-email.html">Configure
        /// Email for your Domain</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail service method.</param>
        /// 
        /// <returns>The response from the ResendValidationEmail service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        public virtual ResendValidationEmailResponse ResendValidationEmail(ResendValidationEmailRequest request)
        {
            var marshaller = ResendValidationEmailRequestMarshaller.Instance;
            var unmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return Invoke<ResendValidationEmailRequest,ResendValidationEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResendValidationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/ResendValidationEmail">REST API Reference for ResendValidationEmail Operation</seealso>
        public virtual Task<ResendValidationEmailResponse> ResendValidationEmailAsync(ResendValidationEmailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResendValidationEmailRequestMarshaller.Instance;
            var unmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return InvokeAsync<ResendValidationEmailRequest,ResendValidationEmailResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateCertificateOptions


        /// <summary>
        /// Updates a certificate. Currently, you can use this function to specify whether to
        /// opt in to or out of recording your certificate in a certificate transparency log.
        /// For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency">
        /// Opting Out of Certificate Transparency Logging</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateOptions service method.</param>
        /// 
        /// <returns>The response from the UpdateCertificateOptions service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account or the caller's
        /// account cannot be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateCertificateOptions">REST API Reference for UpdateCertificateOptions Operation</seealso>
        public virtual UpdateCertificateOptionsResponse UpdateCertificateOptions(UpdateCertificateOptionsRequest request)
        {
            var marshaller = UpdateCertificateOptionsRequestMarshaller.Instance;
            var unmarshaller = UpdateCertificateOptionsResponseUnmarshaller.Instance;

            return Invoke<UpdateCertificateOptionsRequest,UpdateCertificateOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCertificateOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificateOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-2015-12-08/UpdateCertificateOptions">REST API Reference for UpdateCertificateOptions Operation</seealso>
        public virtual Task<UpdateCertificateOptionsResponse> UpdateCertificateOptionsAsync(UpdateCertificateOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateCertificateOptionsRequestMarshaller.Instance;
            var unmarshaller = UpdateCertificateOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCertificateOptionsRequest,UpdateCertificateOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}