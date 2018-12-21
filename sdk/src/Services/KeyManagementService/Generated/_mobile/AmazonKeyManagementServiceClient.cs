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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.KeyManagementService.Model;
using Amazon.KeyManagementService.Model.Internal.MarshallTransformations;
using Amazon.KeyManagementService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Implementation for accessing KeyManagementService
    ///
    /// AWS Key Management Service 
    /// <para>
    /// AWS Key Management Service (AWS KMS) is an encryption and key management web service.
    /// This guide describes the AWS KMS operations that you can call programmatically. For
    /// general information about AWS KMS, see the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/">
    /// <i>AWS Key Management Service Developer Guide</i> </a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, macOS, Android, etc.). The SDKs provide
    /// a convenient way to create programmatic access to AWS KMS and other AWS services.
    /// For example, the SDKs take care of tasks such as signing requests (see below), managing
    /// errors, and retrying requests automatically. For more information about the AWS SDKs,
    /// including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to AWS KMS.
    /// </para>
    ///  
    /// <para>
    /// Clients must support TLS (Transport Layer Security) 1.0. We recommend TLS 1.2. Clients
    /// must also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral
    /// Diffie-Hellman (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern
    /// systems such as Java 7 and later support these modes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you <i>do not</i> use your AWS account (root) access key ID and secret
    /// key for everyday work with AWS KMS. Instead, use the access key ID and secret access
    /// key for an IAM user, or you can use the AWS Security Token Service to generate temporary
    /// security credentials that you can use to sign requests.
    /// </para>
    ///  
    /// <para>
    /// All AWS KMS operations require <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS KMS supports AWS CloudTrail, a service that logs AWS API calls and related events
    /// for your AWS account and delivers them to an Amazon S3 bucket that you specify. By
    /// using the information collected by CloudTrail, you can determine what requests were
    /// made to AWS KMS, who made the request, when it was made, and so on. To learn more
    /// about CloudTrail, including how to turn it on and find your log files, see the <a
    /// href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/">AWS CloudTrail User
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Additional Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a> - This topic provides general information about the of credentials
    /// used for accessing AWS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a> - This section of the <i>IAM User Guide</i> describes how
    /// to create and use temporary security credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> - This set of topics walks you through the process of
    /// signing a request using an access key ID and a secret access key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Commonly Used APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// Of the APIs discussed in this guide, the following will prove the most useful for
    /// most applications. You will likely perform actions other than these, such as creating
    /// keys and assigning policies, by using the console.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>Encrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>Decrypt</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKey</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GenerateDataKeyWithoutPlaintext</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonKeyManagementServiceClient : AmazonServiceClient, IAmazonKeyManagementService
    {
        private static IServiceMetadata serviceMetadata = new AmazonKeyManagementServiceMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
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
        public AmazonKeyManagementServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
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
        public AmazonKeyManagementServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonKeyManagementServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AmazonKeyManagementServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Credentials and an
        /// AmazonKeyManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(AWSCredentials credentials, AmazonKeyManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonKeyManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonKeyManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonKeyManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonKeyManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonKeyManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonKeyManagementServiceClient Configuration Object</param>
        public AmazonKeyManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonKeyManagementServiceConfig clientConfig)
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


        #region  CancelKeyDeletion

        internal virtual CancelKeyDeletionResponse CancelKeyDeletion(CancelKeyDeletionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<CancelKeyDeletionResponse>(request, options);
        }


        /// <summary>
        /// Cancels the deletion of a customer master key (CMK). When this operation is successful,
        /// the CMK is set to the <code>Disabled</code> state. To enable a CMK, use <a>EnableKey</a>.
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier for the customer master key (CMK) for which to cancel deletion. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CancelKeyDeletionRequest();
            request.KeyId = keyId;
            return CancelKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        public virtual Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelKeyDeletionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConnectCustomKeyStore

        internal virtual ConnectCustomKeyStoreResponse ConnectCustomKeyStore(ConnectCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<ConnectCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ConnectCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConnectCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ConnectCustomKeyStore">REST API Reference for ConnectCustomKeyStore Operation</seealso>
        public virtual Task<ConnectCustomKeyStoreResponse> ConnectCustomKeyStoreAsync(ConnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConnectCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<ConnectCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }


        /// <summary>
        /// Creates a display name for a customer master key (CMK). You can use an alias to identify
        /// a CMK in selected operations, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. 
        /// 
        ///  
        /// <para>
        /// Each CMK can have multiple aliases, but each alias points to only one CMK. The alias
        /// name must be unique in the AWS account and region. To simplify code that runs in multiple
        /// regions, use the same alias name, but point it to a different CMK in each region.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// An alias must start with the word <code>alias</code> followed by a forward slash (<code>alias/</code>).
        /// The alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). Alias names cannot begin with <code>aws</code>; that alias name
        /// prefix is reserved by Amazon Web Services (AWS).
        /// </para>
        ///  
        /// <para>
        /// The alias and the CMK it is mapped to must be in the same AWS account and the same
        /// region. You cannot perform this operation on an alias in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// To map an existing alias to a different CMK, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the display name. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// <param name="targetKeyId">Identifies the CMK for which you are creating the alias. This value cannot be an alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return CreateAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomKeyStore

        internal virtual CreateCustomKeyStoreResponse CreateCustomKeyStore(CreateCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<CreateCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateCustomKeyStore">REST API Reference for CreateCustomKeyStore Operation</seealso>
        public virtual Task<CreateCustomKeyStoreResponse> CreateCustomKeyStoreAsync(CreateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGrant

        internal virtual CreateGrantResponse CreateGrant(CreateGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return Invoke<CreateGrantResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        public virtual Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGrantResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKey

        internal virtual CreateKeyResponse CreateKey(CreateKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return Invoke<CreateKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public virtual Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Decrypt

        internal virtual DecryptResponse Decrypt(DecryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptResponseUnmarshaller.Instance;

            return Invoke<DecryptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Decrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Decrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        public virtual Task<DecryptResponse> DecryptAsync(DecryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DecryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptResponseUnmarshaller.Instance;

            return InvokeAsync<DecryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified alias. You cannot perform this operation on an alias in a different
        /// AWS account. 
        /// 
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can delete and change the aliases
        /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
        /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Each CMK can have multiple aliases. To change the alias of a CMK, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different customer master key (CMK), call <a>UpdateAlias</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasName = aliasName;
            return DeleteAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomKeyStore

        internal virtual DeleteCustomKeyStoreResponse DeleteCustomKeyStore(DeleteCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteCustomKeyStore">REST API Reference for DeleteCustomKeyStore Operation</seealso>
        public virtual Task<DeleteCustomKeyStoreResponse> DeleteCustomKeyStoreAsync(DeleteCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteImportedKeyMaterial

        internal virtual DeleteImportedKeyMaterialResponse DeleteImportedKeyMaterial(DeleteImportedKeyMaterialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<DeleteImportedKeyMaterialResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteImportedKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        public virtual Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteImportedKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteImportedKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteImportedKeyMaterialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomKeyStores

        internal virtual DescribeCustomKeyStoresResponse DescribeCustomKeyStores(DescribeCustomKeyStoresRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomKeyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomKeyStoresResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomKeyStoresResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomKeyStores operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomKeyStores operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeCustomKeyStores">REST API Reference for DescribeCustomKeyStores Operation</seealso>
        public virtual Task<DescribeCustomKeyStoresResponse> DescribeCustomKeyStoresAsync(DescribeCustomKeyStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomKeyStoresRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomKeyStoresResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomKeyStoresResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKey

        internal virtual DescribeKeyResponse DescribeKey(DescribeKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyResponse>(request, options);
        }


        /// <summary>
        /// Provides detailed information about the specified customer master key (CMK).
        /// 
        ///  
        /// <para>
        /// If you use <code>DescribeKey</code> on a predefined AWS alias, that is, an AWS alias
        /// with no key ID, AWS KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS
        /// managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response.
        /// </para>
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// or alias ARN in the value of the KeyId parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">Describes the specified customer master key (CMK).  If you specify a predefined AWS alias (an AWS alias with no key ID), KMS associates the alias with an <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">AWS managed CMK</a> and returns its <code>KeyId</code> and <code>Arn</code> in the response. To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias ARN. When using an alias name, prefix it with "alias/". To specify a CMK in a different AWS account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Alias name: <code>alias/ExampleAlias</code>  </li> <li> Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeKeyRequest();
            request.KeyId = keyId;
            return DescribeKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        public virtual Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableKey

        internal virtual DisableKeyResponse DisableKey(DisableKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return Invoke<DisableKeyResponse>(request, options);
        }


        /// <summary>
        /// Sets the state of a customer master key (CMK) to disabled, thereby preventing its
        /// use for cryptographic operations. You cannot perform this operation on a CMK in a
        /// different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects the Use of a Customer Master Key</a> in the <i>AWS Key Management
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRequest();
            request.KeyId = keyId;
            return DisableKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        public virtual Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableKeyRotation

        internal virtual DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<DisableKeyRotationResponse>(request, options);
        }


        /// <summary>
        /// Disables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DisableKeyRotationRequest();
            request.KeyId = keyId;
            return DisableKeyRotationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        public virtual Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableKeyRotationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisconnectCustomKeyStore

        internal virtual DisconnectCustomKeyStoreResponse DisconnectCustomKeyStore(DisconnectCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<DisconnectCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisconnectCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisconnectCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisconnectCustomKeyStore">REST API Reference for DisconnectCustomKeyStore Operation</seealso>
        public virtual Task<DisconnectCustomKeyStoreResponse> DisconnectCustomKeyStoreAsync(DisconnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisconnectCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisconnectCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<DisconnectCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableKey

        internal virtual EnableKeyResponse EnableKey(EnableKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return Invoke<EnableKeyResponse>(request, options);
        }


        /// <summary>
        /// Sets the key state of a customer master key (CMK) to enabled. This allows you to use
        /// the CMK for cryptographic operations. You cannot perform this operation on a CMK in
        /// a different AWS account.
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRequest();
            request.KeyId = keyId;
            return EnableKeyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        public virtual Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableKeyRotation

        internal virtual EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return Invoke<EnableKeyRotationResponse>(request, options);
        }


        /// <summary>
        /// Enables <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> for the specified customer master key (CMK). You
        /// cannot perform this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// You cannot enable automatic rotation of CMKs with imported key material or CMKs in
        /// a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified CMK is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new EnableKeyRotationRequest();
            request.KeyId = keyId;
            return EnableKeyRotationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        public virtual Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableKeyRotationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableKeyRotationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableKeyRotationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  Encrypt

        internal virtual EncryptResponse Encrypt(EncryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptResponseUnmarshaller.Instance;

            return Invoke<EncryptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the Encrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Encrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        public virtual Task<EncryptResponse> EncryptAsync(EncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptResponseUnmarshaller.Instance;

            return InvokeAsync<EncryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKey

        internal virtual GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        public virtual Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext

        internal virtual GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return Invoke<GenerateDataKeyWithoutPlaintextResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        public virtual Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateDataKeyWithoutPlaintextRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateDataKeyWithoutPlaintextResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateDataKeyWithoutPlaintextResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GenerateRandom

        internal virtual GenerateRandomResponse GenerateRandom(GenerateRandomRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRandomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return Invoke<GenerateRandomResponse>(request, options);
        }


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// By default, the random byte string is generated in AWS KMS. To generate the byte string
        /// in the AWS CloudHSM cluster that is associated with a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, specify the custom key store ID.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see the <a href="https://d0.awsstatic.com/whitepapers/KMS-Cryptographic-Details.pdf">AWS
        /// Key Management Service Cryptographic Details</a> whitepaper.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the byte string.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <code>ConnectionState</code> of the custom
        /// key store. To get the <code>ConnectionState</code> of a custom key store, use the
        /// <a>DescribeCustomKeyStores</a> operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> or <a>GenerateRandom</a> operation in a custom
        /// key store that is not connected. These operations are valid only when the custom key
        /// store <code>ConnectionState</code> is <code>CONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <code>ConnectionState</code> is <code>DISCONNECTED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <code>ConnectionState</code> of <code>DISCONNECTING</code> or <code>FAILED</code>.
        /// This operation is valid for all other <code>ConnectionState</code> values.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because AWS KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(int numberOfBytes, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GenerateRandomRequest();
            request.NumberOfBytes = numberOfBytes;
            return GenerateRandomAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        public virtual Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GenerateRandomRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateRandomResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateRandomResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyPolicy

        internal virtual GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<GetKeyPolicyResponse>(request, options);
        }


        /// <summary>
        /// Gets a key policy attached to the specified customer master key (CMK). You cannot
        /// perform this operation on a CMK in a different AWS account.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. The only valid name is <code>default</code>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(string keyId, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyPolicyRequest();
            request.KeyId = keyId;
            request.PolicyName = policyName;
            return GetKeyPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        public virtual Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKeyRotationStatus

        internal virtual GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return Invoke<GetKeyRotationStatusResponse>(request, options);
        }


        /// <summary>
        /// Gets a Boolean value that indicates whether <a href="http://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// rotation of the key material</a> is enabled for the specified customer master key
        /// (CMK).
        /// 
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a CMK. However,
        /// while the CMK is disabled, AWS KMS does not rotate the backing key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a CMK is pending deletion, its key rotation status is <code>false</code>
        /// and AWS KMS does not rotate the backing key. If you cancel the deletion, the original
        /// key rotation status is restored.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetKeyRotationStatusRequest();
            request.KeyId = keyId;
            return GetKeyRotationStatusAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        public virtual Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRotationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyRotationStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyRotationStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParametersForImport

        internal virtual GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return Invoke<GetParametersForImportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetParametersForImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public virtual Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersForImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyMaterial

        internal virtual ImportKeyMaterialResponse ImportKeyMaterial(ImportKeyMaterialRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return Invoke<ImportKeyMaterialResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyMaterial operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        public virtual Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyMaterialRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyMaterialResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyMaterialResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListGrants

        internal virtual ListGrantsResponse ListGrants(ListGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return Invoke<ListGrantsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        public virtual Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeyPolicies

        internal virtual ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListKeyPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        public virtual Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeyPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeyPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListKeys

        internal virtual ListKeysResponse ListKeys(ListKeysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return Invoke<ListKeysResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceTags

        internal virtual ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return Invoke<ListResourceTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListResourceTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        public virtual Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourceTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRetirableGrants

        internal virtual ListRetirableGrantsResponse ListRetirableGrants(ListRetirableGrantsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetirableGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return Invoke<ListRetirableGrantsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. To specify the retiring principal, use the <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an AWS principal. Valid AWS principals include AWS accounts (root), IAM users, federated users, and assumed role users. For examples of the ARN syntax for specifying a principal, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-iam">AWS Identity and Access Management (IAM)</a> in the Example ARNs section of the <i>Amazon Web Services General Reference</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(string retiringPrincipal, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            request.RetiringPrincipal = retiringPrincipal;
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns a list of all grants for which the grant's <code>RetiringPrincipal</code>
        /// matches the one specified.
        /// 
        ///  
        /// <para>
        /// A typical use is to list all grants that you are able to retire. To retire a grant,
        /// use <a>RetireGrant</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListRetirableGrantsRequest();
            return ListRetirableGrantsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRetirableGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListRetirableGrants">REST API Reference for ListRetirableGrants Operation</seealso>
        public virtual Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRetirableGrantsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRetirableGrantsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRetirableGrantsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutKeyPolicy

        internal virtual PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return Invoke<PutKeyPolicyResponse>(request, options);
        }


        /// <summary>
        /// Attaches a key policy to the specified customer master key (CMK). You cannot perform
        /// this operation on a CMK in a different AWS account.
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the CMK. The key policy must meet the following criteria: <ul> <li> If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy must allow the principal that is making the <code>PutKeyPolicy</code> request to make a subsequent <code>PutKeyPolicy</code> request on the CMK. This reduces the risk that the CMK becomes unmanageable. For more information, refer to the scenario in the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default Key Policy</a> section of the <i>AWS Key Management Service Developer Guide</i>. </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to AWS KMS. When you create a new AWS principal (for example, an IAM user or role), you might need to enforce a delay before including the new principal in a key policy because the new principal might not be immediately visible to AWS KMS. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>AWS Identity and Access Management User Guide</i>. </li> </ul> The key policy size limit is 32 kilobytes (32768 bytes).</param>
        /// <param name="policyName">The name of the key policy. The only valid value is <code>default</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a limit was exceeded. For more information, see <a
        /// href="http://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Limits</a>
        /// in the <i>AWS Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(string keyId, string policy, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutKeyPolicyRequest();
            request.KeyId = keyId;
            request.Policy = policy;
            request.PolicyName = policyName;
            return PutKeyPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/PutKeyPolicy">REST API Reference for PutKeyPolicy Operation</seealso>
        public virtual Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutKeyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutKeyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReEncrypt

        internal virtual ReEncryptResponse ReEncrypt(ReEncryptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return Invoke<ReEncryptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        public virtual Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReEncryptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptResponseUnmarshaller.Instance;

            return InvokeAsync<ReEncryptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetireGrant

        internal virtual RetireGrantResponse RetireGrant(RetireGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetireGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return Invoke<RetireGrantResponse>(request, options);
        }


        /// <summary>
        /// Retires a grant. To clean up, you can retire a grant when you're done using it. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The AWS account (root user) under which the grant was created
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>RetiringPrincipal</code>, if present in the grant
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>GranteePrincipal</code>, if <code>RetireGrant</code> is an operation specified
        /// in the grant
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must identify the grant to retire by its grant token or by a combination of the
        /// grant ID and the Amazon Resource Name (ARN) of the customer master key (CMK). A grant
        /// token is a unique variable-length base64-encoded string. A grant ID is a 64 character
        /// unique identifier of a grant. The <a>CreateGrant</a> operation returns both.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(string grantToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RetireGrantRequest();
            request.GrantToken = grantToken;
            return RetireGrantAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        public virtual Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetireGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetireGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RetireGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeGrant

        internal virtual RevokeGrantResponse RevokeGrant(RevokeGrantRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return Invoke<RevokeGrantResponse>(request, options);
        }


        /// <summary>
        /// Revokes the specified grant for the specified customer master key (CMK). You can revoke
        /// a grant to actively deny operations that depend on it.
        /// 
        ///  
        /// <para>
        /// To perform this operation on a CMK in a different AWS account, specify the key ARN
        /// in the value of the <code>KeyId</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. To specify a CMK in a different AWS account, you must use the key ARN. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <code>GrantId</code> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(string grantId, string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RevokeGrantRequest();
            request.GrantId = grantId;
            request.KeyId = keyId;
            return RevokeGrantAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        public virtual Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeGrantRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeGrantResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeGrantResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ScheduleKeyDeletion

        internal virtual ScheduleKeyDeletionResponse ScheduleKeyDeletion(ScheduleKeyDeletionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return Invoke<ScheduleKeyDeletionResponse>(request, options);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Schedules the deletion of a customer master key (CMK). You may provide a waiting period,
        /// specified in days, before deletion occurs. If you do not provide a waiting period,
        /// the default period of 30 days is used. When this operation is successful, the key
        /// state of the CMK changes to <code>PendingDeletion</code>. Before the waiting period
        /// ends, you can use <a>CancelKeyDeletion</a> to cancel the deletion of the CMK. After
        /// the waiting period ends, AWS KMS deletes the CMK and all AWS KMS data associated with
        /// it, including all aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a CMK is a destructive and potentially dangerous operation. When a CMK is
        /// deleted, all data that was encrypted under the CMK is unrecoverable. To prevent the
        /// use of a CMK without deleting it, use <a>DisableKey</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you schedule deletion of a CMK from a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, when the waiting period expires, <code>ScheduleKeyDeletion</code> deletes
        /// the CMK from AWS KMS. Then AWS KMS makes a best effort to delete the key material
        /// from the associated AWS CloudHSM cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups.
        /// </para>
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a CMK for deletion, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// Customer Master Keys</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the customer master key (CMK) to delete. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, AWS KMS deletes the customer master key (CMK). This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, int pendingWindowInDays, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ScheduleKeyDeletionRequest();
            request.KeyId = keyId;
            request.PendingWindowInDays = pendingWindowInDays;
            return ScheduleKeyDeletionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ScheduleKeyDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        public virtual Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ScheduleKeyDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ScheduleKeyDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<ScheduleKeyDeletionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }


        /// <summary>
        /// Associates an existing alias with a different customer master key (CMK). Each CMK
        /// can have multiple aliases, but the aliases must be unique within the account and region.
        /// You cannot perform this operation on an alias in a different AWS account.
        /// 
        ///  
        /// <para>
        /// This operation works only on existing aliases. To change the alias of a CMK to a new
        /// value, use <a>CreateAlias</a> to create a new alias and <a>DeleteAlias</a> to delete
        /// the old alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a CMK, you can create, update, and delete the
        /// aliases of a CMK without affecting the CMK. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all CMKs in the account,
        /// use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word <code>alias</code> followed
        /// by a forward slash (<code>alias/</code>). The alias name can contain only alphanumeric
        /// characters, forward slashes (/), underscores (_), and dashes (-). Alias names cannot
        /// begin with <code>aws</code>; that alias name prefix is reserved by Amazon Web Services
        /// (AWS).
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modified. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/aws" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be mapped to the alias. Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct CMK, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateAliasRequest();
            request.AliasName = aliasName;
            request.TargetKeyId = targetKeyId;
            return UpdateAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCustomKeyStore

        internal virtual UpdateCustomKeyStoreResponse UpdateCustomKeyStore(UpdateCustomKeyStoreRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomKeyStoreResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomKeyStoreResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomKeyStore operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomKeyStore operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateCustomKeyStore">REST API Reference for UpdateCustomKeyStore Operation</seealso>
        public virtual Task<UpdateCustomKeyStoreResponse> UpdateCustomKeyStoreAsync(UpdateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCustomKeyStoreRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomKeyStoreResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCustomKeyStoreResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateKeyDescription

        internal virtual UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateKeyDescriptionResponse>(request, options);
        }


        /// <summary>
        /// Updates the description of a customer master key (CMK). To see the decription of a
        /// CMK, use <a>DescribeKey</a>. 
        /// 
        ///  
        /// <para>
        /// You cannot perform this operation on a CMK in a different AWS account.
        /// </para>
        ///  
        /// <para>
        /// The result of this operation varies with the key state of the CMK. For details, see
        /// <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key (CMK). Specify the key ID or the Amazon Resource Name (ARN) of the CMK. For example: <ul> <li> Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> <li> Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>  </li> </ul> To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the CMK.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. The request can be retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// For more information about how key state affects the use of a CMK, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
        /// Developer Guide</i>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(string keyId, string description, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new UpdateKeyDescriptionRequest();
            request.KeyId = keyId;
            request.Description = description;
            return UpdateKeyDescriptionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        public virtual Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateKeyDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateKeyDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateKeyDescriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}