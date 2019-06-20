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
using System.Net;

using Amazon.ACMPCA.Model;
using Amazon.ACMPCA.Model.Internal.MarshallTransformations;
using Amazon.ACMPCA.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ACMPCA
{
    /// <summary>
    /// Implementation for accessing ACMPCA
    ///
    /// This is the <i>ACM Private CA API Reference</i>. It provides descriptions, syntax,
    /// and usage examples for each of the actions and data types involved in creating and
    /// managing private certificate authorities (CA) for your organization.
    /// 
    ///  
    /// <para>
    /// The documentation for each action shows the Query API request parameters and the XML
    /// response. Alternatively, you can use one of the AWS SDKs to access an API that's tailored
    /// to the programming language or platform that you're using. For more information, see
    /// <a href="https://aws.amazon.com/tools/#SDKs">AWS SDKs</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Each ACM Private CA API action has a throttling limit which determines the number
    /// of times the action can be called per second. For more information, see <a href="https://docs.aws.amazon.com/acm-pca/latest/userguide/PcaLimits.html#PcaLimits-api">API
    /// Rate Limits in ACM Private CA</a> in the ACM Private CA user guide.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonACMPCAClient : AmazonServiceClient, IAmazonACMPCA
    {
        private static IServiceMetadata serviceMetadata = new AmazonACMPCAMetadata();
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

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
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
        /// Creates a root or subordinate private certificate authority (CA). You must specify
        /// the CA configuration, the certificate revocation list (CRL) configuration, the CA
        /// type, and an optional idempotency token to avoid accidental creation of multiple CAs.
        /// The CA configuration specifies the name of the algorithm and key size to be used to
        /// create the CA private key, the type of signing algorithm that the CA uses, and X.500
        /// subject information. The CRL configuration specifies the CRL expiration period in
        /// days (the validity period of the CRL), the Amazon S3 bucket that will contain the
        /// CRL, and a CNAME alias for the S3 bucket that is included in certificates issued by
        /// the CA. If successful, this action returns the Amazon Resource Name (ARN) of the CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the CreateCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArgsException">
        /// One or more of the specified arguments was not valid.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidPolicyException">
        /// The S3 bucket policy is not valid. The policy must give ACM Private CA rights to read
        /// from and write to the bucket and find the bucket location.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidTagException">
        /// The tag associated with the CA is not valid. The invalid argument is contained in
        /// the message field.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An ACM Private CA limit has been exceeded. See the exception message returned to determine
        /// the limit that was exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreateCertificateAuthority">REST API Reference for CreateCertificateAuthority Operation</seealso>
        public virtual CreateCertificateAuthorityResponse CreateCertificateAuthority(CreateCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<CreateCertificateAuthorityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Creates an audit report that lists every time that your CA private key is used. The
        /// report is saved in the Amazon S3 bucket that you specify on input. The <a>IssueCertificate</a>
        /// and <a>RevokeCertificate</a> actions use the private key.
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
        /// The private CA is in a state during which a report or certificate cannot be generated.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateAuthorityAuditReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return Invoke<CreateCertificateAuthorityAuditReportResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCertificateAuthorityAuditReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  CreatePermission

        /// <summary>
        /// Assigns permissions from a private CA to a designated AWS service. Services are specified
        /// by their service principals and can be given permission to create and retrieve certificates
        /// on a private CA. Services can also be given permission to list the active permissions
        /// that the private CA has granted. For ACM to automatically renew your private CA's
        /// certificates, you must assign all possible permissions from the CA to the ACM service
        /// principal.
        /// 
        ///  
        /// <para>
        /// At this time, you can only assign permissions to ACM (<code>acm.amazonaws.com</code>).
        /// Permissions can be revoked with the <a>DeletePermission</a> action and listed with
        /// the <a>ListPermissions</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePermission service method.</param>
        /// 
        /// <returns>The response from the CreatePermission service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An ACM Private CA limit has been exceeded. See the exception message returned to determine
        /// the limit that was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.PermissionAlreadyExistsException">
        /// The designated permission has already been given to the user.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreatePermission">REST API Reference for CreatePermission Operation</seealso>
        public virtual CreatePermissionResponse CreatePermission(CreatePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionResponseUnmarshaller.Instance;

            return Invoke<CreatePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePermission operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreatePermission">REST API Reference for CreatePermission Operation</seealso>
        public virtual IAsyncResult BeginCreatePermission(CreatePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePermission.</param>
        /// 
        /// <returns>Returns a  CreatePermissionResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/CreatePermission">REST API Reference for CreatePermission Operation</seealso>
        public virtual CreatePermissionResponse EndCreatePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePermissionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCertificateAuthority

        /// <summary>
        /// Deletes a private certificate authority (CA). You must provide the Amazon Resource
        /// Name (ARN) of the private CA that you want to delete. You can find the ARN by calling
        /// the <a>ListCertificateAuthorities</a> action. 
        /// 
        ///  <note> 
        /// <para>
        /// Deleting a CA will invalidate other CAs and certificates below it in your CA hierarchy.
        /// </para>
        ///  </note> 
        /// <para>
        /// Before you can delete a CA that you have created and activated, you must disable it.
        /// To do this, call the <a>UpdateCertificateAuthority</a> action and set the <b>CertificateAuthorityStatus</b>
        /// parameter to <code>DISABLED</code>. 
        /// </para>
        ///  
        /// <para>
        /// Additionally, you can delete a CA if you are waiting for it to be created (that is,
        /// the status of the CA is <code>CREATING</code>). You can also delete it if the CA has
        /// been created but you haven't yet imported the signed certificate into ACM Private
        /// CA (that is, the status of the CA is <code>PENDING_CERTIFICATE</code>). 
        /// </para>
        ///  
        /// <para>
        /// When you successfully call <a>DeleteCertificateAuthority</a>, the CA's status changes
        /// to <code>DELETED</code>. However, the CA won't be permanently deleted until the restoration
        /// period has passed. By default, if you do not set the <code>PermanentDeletionTimeInDays</code>
        /// parameter, the CA remains restorable for 30 days. You can set the parameter from 7
        /// to 30 days. The <a>DescribeCertificateAuthority</a> action returns the time remaining
        /// in the restoration window of a private CA in the <code>DELETED</code> state. To restore
        /// an eligible CA, call the <a>RestoreCertificateAuthority</a> action.
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
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeleteCertificateAuthority">REST API Reference for DeleteCertificateAuthority Operation</seealso>
        public virtual DeleteCertificateAuthorityResponse DeleteCertificateAuthority(DeleteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateAuthorityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  DeletePermission

        /// <summary>
        /// Revokes permissions that a private CA assigned to a designated AWS service. Permissions
        /// can be created with the <a>CreatePermission</a> action and listed with the <a>ListPermissions</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePermission service method.</param>
        /// 
        /// <returns>The response from the DeletePermission service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeletePermission">REST API Reference for DeletePermission Operation</seealso>
        public virtual DeletePermissionResponse DeletePermission(DeletePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionResponseUnmarshaller.Instance;

            return Invoke<DeletePermissionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePermission operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeletePermission">REST API Reference for DeletePermission Operation</seealso>
        public virtual IAsyncResult BeginDeletePermission(DeletePermissionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePermissionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePermission.</param>
        /// 
        /// <returns>Returns a  DeletePermissionResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/DeletePermission">REST API Reference for DeletePermission Operation</seealso>
        public virtual DeletePermissionResponse EndDeletePermission(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePermissionResponse>(asyncResult);
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
        ///  <code>CREATING</code> - ACM Private CA is creating your private certificate authority.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_CERTIFICATE</code> - The certificate is pending. You must use your
        /// ACM Private CA-hosted or on-premises root or subordinate CA to sign your private CA
        /// CSR and then import it into PCA. 
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
        /// it is permanently deleted. The length of time remaining in the CA's restoration period
        /// is also included in this action's output.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateAuthorityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// action. Audit information is created every time the certificate authority (CA) private
        /// key is used. The private key is used when you call the <a>IssueCertificate</a> action
        /// or the <a>RevokeCertificate</a> action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateAuthorityAuditReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateAuthorityAuditReportResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCertificateAuthorityAuditReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCertificateAuthorityAuditReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// when you call the <a>IssueCertificate</a> action. You must specify both the ARN of
        /// your private CA and the ARN of the issued certificate when calling the <b>GetCertificate</b>
        /// action. You can retrieve the certificate if it is in the <b>ISSUED</b> state. You
        /// can call the <a>CreateCertificateAuthorityAuditReport</a> action to create a report
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
        /// The private CA is in a state during which a report or certificate cannot be generated.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/GetCertificateAuthorityCertificate">REST API Reference for GetCertificateAuthorityCertificate Operation</seealso>
        public virtual GetCertificateAuthorityCertificateResponse GetCertificateAuthorityCertificate(GetCertificateAuthorityCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateAuthorityCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateAuthorityCertificateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateAuthorityCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// (CA). The CSR is created when you call the <a>CreateCertificateAuthority</a> action.
        /// Sign the CSR with your ACM Private CA-hosted or on-premises root or subordinate CA.
        /// Then import the signed certificate back into ACM Private CA by calling the <a>ImportCertificateAuthorityCertificate</a>
        /// action. The CSR is returned as a base64 PEM-encoded string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateAuthorityCsr service method.</param>
        /// 
        /// <returns>The response from the GetCertificateAuthorityCsr service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateAuthorityCsrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateAuthorityCsrResponseUnmarshaller.Instance;

            return Invoke<GetCertificateAuthorityCsrResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCertificateAuthorityCsrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCertificateAuthorityCsrResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Imports a signed private CA certificate into ACM Private CA. This action is used when
        /// you are using a chain of trust whose root is located outside ACM Private CA. Before
        /// you can call this action, the following preparations must in place:
        /// 
        ///  <ol> <li> 
        /// <para>
        /// In ACM Private CA, call the <a>CreateCertificateAuthority</a> action to create the
        /// private CA that that you plan to back with the imported certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <a>GetCertificateAuthorityCsr</a> action to generate a certificate signing
        /// request (CSR).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sign the CSR using a root or intermediate CA hosted either by an on-premises PKI hierarchy
        /// or a commercial CA..
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a certificate chain and copy the signed certificate and the certificate chain
        /// to your working directory.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// The following requirements apply when you import a CA certificate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot import a non-self-signed certificate for use as a root CA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot import a self-signed certificate for use as a subordinate CA.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your certificate chain must not include the private CA certificate that you are importing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your ACM Private CA-hosted or on-premises CA certificate must be the last certificate
        /// in your chain. The subordinate certificate, if any, that your root CA signed must
        /// be next to last. The subordinate certificate signed by the preceding subordinate CA
        /// must come next, and so on until your chain is built. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The chain must be PEM-encoded.
        /// </para>
        ///  </li> </ul>
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
        /// <exception cref="Amazon.ACMPCA.Model.InvalidRequestException">
        /// The request action cannot be performed or is prohibited.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateAuthorityCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateAuthorityCertificateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportCertificateAuthorityCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCertificateAuthorityCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// Uses your private certificate authority (CA) to issue a client certificate. This action
        /// returns the Amazon Resource Name (ARN) of the certificate. You can retrieve the certificate
        /// by calling the <a>GetCertificate</a> action and specifying the ARN. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot use the ACM <b>ListCertificateAuthorities</b> action to retrieve the ARNs
        /// of the certificates that you issue by using ACM Private CA.
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
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An ACM Private CA limit has been exceeded. See the exception message returned to determine
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
            var options = new InvokeOptions();
            options.RequestMarshaller = IssueCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IssueCertificateResponseUnmarshaller.Instance;

            return Invoke<IssueCertificateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = IssueCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = IssueCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// action.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificateAuthoritiesResponseUnmarshaller.Instance;

            return Invoke<ListCertificateAuthoritiesResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCertificateAuthoritiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  ListPermissions

        /// <summary>
        /// Lists all the permissions, if any, that have been assigned by a private CA. Permissions
        /// can be granted with the <a>CreatePermission</a> action and revoked with the <a>DeletePermission</a>
        /// action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidNextTokenException">
        /// The token specified in the <code>NextToken</code> argument is not valid. Use the token
        /// returned from your previous call to <a>ListCertificateAuthorities</a>.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.RequestFailedException">
        /// The request has failed for an unspecified reason.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual ListPermissionsResponse ListPermissions(ListPermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return Invoke<ListPermissionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual IAsyncResult BeginListPermissions(ListPermissionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPermissionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPermissions.</param>
        /// 
        /// <returns>Returns a  ListPermissionsResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        public virtual ListPermissionsResponse EndListPermissions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPermissionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Lists the tags, if any, that are associated with your private CA. Tags are labels
        /// that you can use to identify and organize your CAs. Each tag consists of a key and
        /// an optional value. Call the <a>TagCertificateAuthority</a> action to add one or more
        /// tags to your CA. Call the <a>UntagCertificateAuthority</a> action to remove tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/ListTags">REST API Reference for ListTags Operation</seealso>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        
        #region  RestoreCertificateAuthority

        /// <summary>
        /// Restores a certificate authority (CA) that is in the <code>DELETED</code> state. You
        /// can restore a CA during the period that you defined in the <b>PermanentDeletionTimeInDays</b>
        /// parameter of the <a>DeleteCertificateAuthority</a> action. Currently, you can specify
        /// 7 to 30 days. If you did not specify a <b>PermanentDeletionTimeInDays</b> value, by
        /// default you can restore the CA at any time in a 30 day period. You can check the time
        /// remaining in the restoration period of a private CA in the <code>DELETED</code> state
        /// by calling the <a>DescribeCertificateAuthority</a> or <a>ListCertificateAuthorities</a>
        /// actions. The status of a restored CA is set to its pre-deletion status when the <b>RestoreCertificateAuthority</b>
        /// action returns. To change its status to <code>ACTIVE</code>, call the <a>UpdateCertificateAuthority</a>
        /// action. If the private CA was in the <code>PENDING_CERTIFICATE</code> state at deletion,
        /// you must use the <a>ImportCertificateAuthorityCertificate</a> action to import a certificate
        /// authority into the private CA before it can be activated. You cannot restore a CA
        /// after the restoration period has ended.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the RestoreCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RestoreCertificateAuthority">REST API Reference for RestoreCertificateAuthority Operation</seealso>
        public virtual RestoreCertificateAuthorityResponse RestoreCertificateAuthority(RestoreCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<RestoreCertificateAuthorityResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreCertificateAuthority operation on AmazonACMPCAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreCertificateAuthority
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RestoreCertificateAuthority">REST API Reference for RestoreCertificateAuthority Operation</seealso>
        public virtual IAsyncResult BeginRestoreCertificateAuthority(RestoreCertificateAuthorityRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreCertificateAuthority.</param>
        /// 
        /// <returns>Returns a  RestoreCertificateAuthorityResult from ACMPCA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/RestoreCertificateAuthority">REST API Reference for RestoreCertificateAuthority Operation</seealso>
        public virtual RestoreCertificateAuthorityResponse EndRestoreCertificateAuthority(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreCertificateAuthorityResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeCertificate

        /// <summary>
        /// Revokes a certificate that was issued inside ACM Private CA. If you enable a certificate
        /// revocation list (CRL) when you create or update your private CA, information about
        /// the revoked certificates will be included in the CRL. ACM Private CA writes the CRL
        /// to an S3 bucket that you specify. For more information about revocation, see the <a>CrlConfiguration</a>
        /// structure. ACM Private CA also writes revocation information to the audit report.
        /// For more information, see <a>CreateCertificateAuthorityAuditReport</a>. 
        /// 
        ///  <note> 
        /// <para>
        /// You cannot revoke a root CA self-signed certificate.
        /// </para>
        ///  </note>
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
        /// <exception cref="Amazon.ACMPCA.Model.InvalidRequestException">
        /// The request action cannot be performed or is prohibited.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.LimitExceededException">
        /// An ACM Private CA limit has been exceeded. See the exception message returned to determine
        /// the limit that was exceeded.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCertificateResponseUnmarshaller.Instance;

            return Invoke<RevokeCertificateResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeCertificateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// CAs. To remove one or more tags, use the <a>UntagCertificateAuthority</a> action.
        /// Call the <a>ListTags</a> action to see what tags are associated with your CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the TagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<TagCertificateAuthorityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = TagCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// If you do not specify the value portion of the tag when calling this action, the tag
        /// will be removed regardless of value. If you specify a value, the tag is removed only
        /// if it is associated with the specified value. To add tags to a private CA, use the
        /// <a>TagCertificateAuthority</a>. Call the <a>ListTags</a> action to see what tags are
        /// associated with your CA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagCertificateAuthority service method.</param>
        /// 
        /// <returns>The response from the UntagCertificateAuthority service method, as returned by ACMPCA.</returns>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<UntagCertificateAuthorityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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
        /// The S3 bucket policy is not valid. The policy must give ACM Private CA rights to read
        /// from and write to the bucket and find the bucket location.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.InvalidStateException">
        /// The private CA is in a state during which a report or certificate cannot be generated.
        /// </exception>
        /// <exception cref="Amazon.ACMPCA.Model.ResourceNotFoundException">
        /// A resource such as a private CA, S3 bucket, certificate, or audit report cannot be
        /// found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/acm-pca-2017-08-22/UpdateCertificateAuthority">REST API Reference for UpdateCertificateAuthority Operation</seealso>
        public virtual UpdateCertificateAuthorityResponse UpdateCertificateAuthority(UpdateCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<UpdateCertificateAuthorityResponse>(request, options);
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCertificateAuthorityResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
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