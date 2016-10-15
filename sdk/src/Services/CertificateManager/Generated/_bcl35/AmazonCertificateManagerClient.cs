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
        /// Adds one or more tags to an ACM Certificate. Tags are labels that you can use to identify
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
        /// among those resources. For example, you can add the same tag to an ACM Certificate
        /// and an Elastic Load Balancing load balancer to indicate that they are both used by
        /// the same website. For more information, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/tags.html">Tagging
        /// ACM Certificates</a>.
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
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.TooManyTagsException">
        /// The request contains too many tags. Try the request again with fewer tags.
        /// </exception>
        public AddTagsToCertificateResponse AddTagsToCertificate(AddTagsToCertificateRequest request)
        {
            var marshaller = new AddTagsToCertificateRequestMarshaller();
            var unmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return Invoke<AddTagsToCertificateRequest,AddTagsToCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTagsToCertificate
        ///         operation.</returns>
        public IAsyncResult BeginAddTagsToCertificate(AddTagsToCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AddTagsToCertificateRequestMarshaller();
            var unmarshaller = AddTagsToCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsToCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTagsToCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTagsToCertificate.</param>
        /// 
        /// <returns>Returns a  AddTagsToCertificateResult from CertificateManager.</returns>
        public  AddTagsToCertificateResponse EndAddTagsToCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsToCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCertificate

        /// <summary>
        /// Deletes an ACM Certificate and its associated private key. If this action succeeds,
        /// the certificate no longer appears in the list of ACM Certificates that can be displayed
        /// by calling the <a>ListCertificates</a> action or be retrieved by calling the <a>GetCertificate</a>
        /// action. The certificate will not be available for use by other AWS services.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM Certificate that is being used by another AWS service. To
        /// delete a certificate that is in use, the certificate association must first be removed.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="certificateArn">String that contains the ARN of the ACM Certificate to be deleted. This must be of the form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
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
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DeleteCertificateResponse DeleteCertificate(string certificateArn)
        {
            var request = new DeleteCertificateRequest();
            request.CertificateArn = certificateArn;
            return DeleteCertificate(request);
        }


        /// <summary>
        /// Deletes an ACM Certificate and its associated private key. If this action succeeds,
        /// the certificate no longer appears in the list of ACM Certificates that can be displayed
        /// by calling the <a>ListCertificates</a> action or be retrieved by calling the <a>GetCertificate</a>
        /// action. The certificate will not be available for use by other AWS services.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete an ACM Certificate that is being used by another AWS service. To
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
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var marshaller = new DeleteCertificateRequestMarshaller();
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateRequest,DeleteCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteCertificateRequestMarshaller();
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from CertificateManager.</returns>
        public  DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCertificate

        /// <summary>
        /// Returns a list of the fields contained in the specified ACM Certificate. For example,
        /// this action returns the certificate status, a flag that indicates whether the certificate
        /// is associated with any other AWS service, and the date at which the certificate request
        /// was created. You specify the ACM Certificate on input by its Amazon Resource Name
        /// (ARN).
        /// </summary>
        /// <param name="certificateArn">String that contains an ACM Certificate ARN. The ARN must be of the form:  <code>arn:aws:acm:region:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>  For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DescribeCertificateResponse DescribeCertificate(string certificateArn)
        {
            var request = new DescribeCertificateRequest();
            request.CertificateArn = certificateArn;
            return DescribeCertificate(request);
        }


        /// <summary>
        /// Returns a list of the fields contained in the specified ACM Certificate. For example,
        /// this action returns the certificate status, a flag that indicates whether the certificate
        /// is associated with any other AWS service, and the date at which the certificate request
        /// was created. You specify the ACM Certificate on input by its Amazon Resource Name
        /// (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var marshaller = new DescribeCertificateRequestMarshaller();
            var unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateRequest,DescribeCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificate
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCertificate(DescribeCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeCertificateRequestMarshaller();
            var unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificate.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateResult from CertificateManager.</returns>
        public  DescribeCertificateResponse EndDescribeCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCertificate

        /// <summary>
        /// Retrieves an ACM Certificate and certificate chain for the certificate specified by
        /// an ARN. The chain is an ordered list of certificates that contains the root certificate,
        /// intermediate certificates of subordinate CAs, and the ACM Certificate. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate chain
        /// to see the individual certificate fields, you can use OpenSSL.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, ACM Certificates can be used only with Elastic Load Balancing and Amazon
        /// CloudFront.
        /// </para>
        ///  </note>
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
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public GetCertificateResponse GetCertificate(string certificateArn)
        {
            var request = new GetCertificateRequest();
            request.CertificateArn = certificateArn;
            return GetCertificate(request);
        }


        /// <summary>
        /// Retrieves an ACM Certificate and certificate chain for the certificate specified by
        /// an ARN. The chain is an ordered list of certificates that contains the root certificate,
        /// intermediate certificates of subordinate CAs, and the ACM Certificate. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate chain
        /// to see the individual certificate fields, you can use OpenSSL.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, ACM Certificates can be used only with Elastic Load Balancing and Amazon
        /// CloudFront.
        /// </para>
        ///  </note>
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
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            var marshaller = new GetCertificateRequestMarshaller();
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateRequest,GetCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCertificate
        ///         operation.</returns>
        public IAsyncResult BeginGetCertificate(GetCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetCertificateRequestMarshaller();
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
        /// <returns>Returns a  GetCertificateResult from CertificateManager.</returns>
        public  GetCertificateResponse EndGetCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportCertificate

        /// <summary>
        /// Imports an SSL/TLS certificate into AWS Certificate Manager (ACM) to use with <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-services.html">ACM's
        /// integrated AWS services</a>.
        /// 
        ///  <note> 
        /// <para>
        /// ACM does not provide <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html">managed
        /// renewal</a> for certificates that you import.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about importing certificates into ACM, including the differences
        /// between certificates that you import and those that ACM provides, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html">Importing
        /// Certificates</a> in the <i>AWS Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To import a certificate, you must provide the certificate and the matching private
        /// key. When the certificate is not self-signed, you must also provide a certificate
        /// chain. You can omit the certificate chain when importing a self-signed certificate.
        /// </para>
        ///  
        /// <para>
        /// The certificate, private key, and certificate chain must be PEM-encoded. For more
        /// information about converting these items to PEM format, see <a href="http://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html#import-certificate-troubleshooting">Importing
        /// Certificates Troubleshooting</a> in the <i>AWS Certificate Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To import a new certificate, omit the <code>CertificateArn</code> field. Include this
        /// field only when you want to replace a previously imported certificate.
        /// </para>
        ///  
        /// <para>
        /// This operation returns the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Name (ARN)</a> of the imported certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate service method.</param>
        /// 
        /// <returns>The response from the ImportCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Limits</a>
        /// topic.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var marshaller = new ImportCertificateRequestMarshaller();
            var unmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateRequest,ImportCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportCertificate
        ///         operation.</returns>
        public IAsyncResult BeginImportCertificate(ImportCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ImportCertificateRequestMarshaller();
            var unmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<ImportCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportCertificate.</param>
        /// 
        /// <returns>Returns a  ImportCertificateResult from CertificateManager.</returns>
        public  ImportCertificateResponse EndImportCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCertificates

        /// <summary>
        /// Retrieves a list of ACM Certificates and the domain name for each. You can optionally
        /// filter the list to return only the certificates that match the specified status.
        /// </summary>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        public ListCertificatesResponse ListCertificates()
        {
            return ListCertificates(new ListCertificatesRequest());
        }

        /// <summary>
        /// Retrieves a list of ACM Certificates and the domain name for each. You can optionally
        /// filter the list to return only the certificates that match the specified status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var marshaller = new ListCertificatesRequestMarshaller();
            var unmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesRequest,ListCertificatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificates
        ///         operation.</returns>
        public IAsyncResult BeginListCertificates(ListCertificatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCertificatesRequestMarshaller();
            var unmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke<ListCertificatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificates.</param>
        /// 
        /// <returns>Returns a  ListCertificatesResult from CertificateManager.</returns>
        public  ListCertificatesResponse EndListCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForCertificate

        /// <summary>
        /// Lists the tags that have been applied to the ACM Certificate. Use the certificate
        /// ARN to specify the certificate. To add a tag to an ACM Certificate, use the <a>AddTagsToCertificate</a>
        /// action. To delete a tag, use the <a>RemoveTagsFromCertificate</a> action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate service method.</param>
        /// 
        /// <returns>The response from the ListTagsForCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public ListTagsForCertificateResponse ListTagsForCertificate(ListTagsForCertificateRequest request)
        {
            var marshaller = new ListTagsForCertificateRequestMarshaller();
            var unmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return Invoke<ListTagsForCertificateRequest,ListTagsForCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForCertificate
        ///         operation.</returns>
        public IAsyncResult BeginListTagsForCertificate(ListTagsForCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListTagsForCertificateRequestMarshaller();
            var unmarshaller = ListTagsForCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsForCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForCertificate.</param>
        /// 
        /// <returns>Returns a  ListTagsForCertificateResult from CertificateManager.</returns>
        public  ListTagsForCertificateResponse EndListTagsForCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTagsFromCertificate

        /// <summary>
        /// Remove one or more tags from an ACM Certificate. A tag consists of a key-value pair.
        /// If you do not specify the value portion of the tag when calling this function, the
        /// tag will be removed regardless of value. If you specify a value, the tag is removed
        /// only if it is associated with the specified value.
        /// 
        ///  
        /// <para>
        /// To add tags to a certificate, use the <a>AddTagsToCertificate</a> action. To view
        /// all of the tags that have been applied to a specific ACM Certificate, use the <a>ListTagsForCertificate</a>
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
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public RemoveTagsFromCertificateResponse RemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request)
        {
            var marshaller = new RemoveTagsFromCertificateRequestMarshaller();
            var unmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromCertificateRequest,RemoveTagsFromCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTagsFromCertificate
        ///         operation.</returns>
        public IAsyncResult BeginRemoveTagsFromCertificate(RemoveTagsFromCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RemoveTagsFromCertificateRequestMarshaller();
            var unmarshaller = RemoveTagsFromCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsFromCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTagsFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTagsFromCertificate.</param>
        /// 
        /// <returns>Returns a  RemoveTagsFromCertificateResult from CertificateManager.</returns>
        public  RemoveTagsFromCertificateResponse EndRemoveTagsFromCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsFromCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestCertificate

        /// <summary>
        /// Requests an ACM Certificate for use with other AWS services. To request an ACM Certificate,
        /// you must specify the fully qualified domain name (FQDN) for your site. You can also
        /// specify additional FQDNs if users can reach your site by using other names. For each
        /// domain name you specify, email is sent to the domain owner to request approval to
        /// issue the certificate. After receiving approval from the domain owner, the ACM Certificate
        /// is issued. For more information, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/">AWS
        /// Certificate Manager User Guide</a>.
        /// </summary>
        /// <param name="domainName">Fully qualified domain name (FQDN), such as www.example.com, of the site you want to secure with an ACM Certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com.</param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Limits</a>
        /// topic.
        /// </exception>
        public RequestCertificateResponse RequestCertificate(string domainName)
        {
            var request = new RequestCertificateRequest();
            request.DomainName = domainName;
            return RequestCertificate(request);
        }


        /// <summary>
        /// Requests an ACM Certificate for use with other AWS services. To request an ACM Certificate,
        /// you must specify the fully qualified domain name (FQDN) for your site. You can also
        /// specify additional FQDNs if users can reach your site by using other names. For each
        /// domain name you specify, email is sent to the domain owner to request approval to
        /// issue the certificate. After receiving approval from the domain owner, the ACM Certificate
        /// is issued. For more information, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/">AWS
        /// Certificate Manager User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html">Limits</a>
        /// topic.
        /// </exception>
        public RequestCertificateResponse RequestCertificate(RequestCertificateRequest request)
        {
            var marshaller = new RequestCertificateRequestMarshaller();
            var unmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return Invoke<RequestCertificateRequest,RequestCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestCertificate
        ///         operation.</returns>
        public IAsyncResult BeginRequestCertificate(RequestCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RequestCertificateRequestMarshaller();
            var unmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<RequestCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestCertificate.</param>
        /// 
        /// <returns>Returns a  RequestCertificateResult from CertificateManager.</returns>
        public  RequestCertificateResponse EndRequestCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  ResendValidationEmail

        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or an
        /// authorized representative must approve the ACM Certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM Certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
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
        /// Processing has reached an invalid state. For example, this exception can occur if
        /// the specified domain is not using email validation, or the current certificate status
        /// does not permit the requested operation. See the exception message returned by ACM
        /// to determine which state is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public ResendValidationEmailResponse ResendValidationEmail(ResendValidationEmailRequest request)
        {
            var marshaller = new ResendValidationEmailRequestMarshaller();
            var unmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return Invoke<ResendValidationEmailRequest,ResendValidationEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResendValidationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResendValidationEmail
        ///         operation.</returns>
        public IAsyncResult BeginResendValidationEmail(ResendValidationEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResendValidationEmailRequestMarshaller();
            var unmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return BeginInvoke<ResendValidationEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResendValidationEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendValidationEmail.</param>
        /// 
        /// <returns>Returns a  ResendValidationEmailResult from CertificateManager.</returns>
        public  ResendValidationEmailResponse EndResendValidationEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<ResendValidationEmailResponse>(asyncResult);
        }

        #endregion
        
    }
}