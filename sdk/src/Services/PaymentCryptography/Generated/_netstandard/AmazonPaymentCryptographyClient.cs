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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PaymentCryptography.Model;
using Amazon.PaymentCryptography.Model.Internal.MarshallTransformations;
using Amazon.PaymentCryptography.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.PaymentCryptography
{
    /// <summary>
    /// <para>Implementation for accessing PaymentCryptography</para>
    ///
    /// Amazon Web Services Payment Cryptography Control Plane APIs manage encryption keys
    /// for use during payment-related cryptographic operations. You can create, import, export,
    /// share, manage, and delete keys. You can also manage Identity and Access Management
    /// (IAM) policies for keys. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/security-iam.html">Identity
    /// and access management</a> in the <i>Amazon Web Services Payment Cryptography User
    /// Guide.</i> 
    /// 
    ///  
    /// <para>
    /// To use encryption keys for payment-related transaction processing and associated cryptographic
    /// operations, you use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/DataAPIReference/Welcome.html">Amazon
    /// Web Services Payment Cryptography Data Plane</a>. You can perform actions like encrypt,
    /// decrypt, generate, and verify payment-related data.
    /// </para>
    ///  
    /// <para>
    /// All Amazon Web Services Payment Cryptography API calls must be signed and transmitted
    /// using Transport Layer Security (TLS). We recommend you always use the latest supported
    /// TLS version for logging API requests. 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography supports CloudTrail for control plane operations,
    /// a service that logs Amazon Web Services API calls and related events for your Amazon
    /// Web Services account and delivers them to an Amazon S3 bucket you specify. By using
    /// the information collected by CloudTrail, you can determine what requests were made
    /// to Amazon Web Services Payment Cryptography, who made the request, when it was made,
    /// and so on. If you don't conﬁgure a trail, you can still view the most recent events
    /// in the CloudTrail console. For more information, see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/">CloudTrail
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonPaymentCryptographyClient : AmazonServiceClient, IAmazonPaymentCryptography
    {
        private static IServiceMetadata serviceMetadata = new AmazonPaymentCryptographyMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with the credentials loaded from the application's
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
        public AmazonPaymentCryptographyClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPaymentCryptographyConfig()) { }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with the credentials loaded from the application's
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
        public AmazonPaymentCryptographyClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonPaymentCryptographyConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPaymentCryptographyClient Configuration Object</param>
        public AmazonPaymentCryptographyClient(AmazonPaymentCryptographyConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPaymentCryptographyClient(AWSCredentials credentials)
            : this(credentials, new AmazonPaymentCryptographyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPaymentCryptographyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Credentials and an
        /// AmazonPaymentCryptographyClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyClient Configuration Object</param>
        public AmazonPaymentCryptographyClient(AWSCredentials credentials, AmazonPaymentCryptographyConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPaymentCryptographyClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentCryptographyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentCryptographyConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentCryptographyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyClient Configuration Object</param>
        public AmazonPaymentCryptographyClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPaymentCryptographyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPaymentCryptographyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentCryptographyConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentCryptographyConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentCryptographyClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyClient Configuration Object</param>
        public AmazonPaymentCryptographyClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPaymentCryptographyConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPaymentCryptographyPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPaymentCryptographyPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PaymentCryptographyPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPaymentCryptographyEndpointResolver());
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


        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }



        /// <summary>
        /// Creates an <i>alias</i>, or a friendly name, for an Amazon Web Services Payment Cryptography
        /// key. You can use an alias to identify a key in the console and when you call cryptographic
        /// operations such as <a href="https://docs.aws.amazon.com/payment-cryptography/latest/DataAPIReference/API_EncryptData.html">EncryptData</a>
        /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/DataAPIReference/API_DecryptData.html">DecryptData</a>.
        /// 
        ///  
        /// <para>
        /// You can associate the alias with any key in the same Amazon Web Services Region. Each
        /// alias is associated with only one key at a time, but a key can have multiple aliases.
        /// You can't create an alias without a key. The alias must be unique in the account and
        /// Amazon Web Services Region, but you can create another alias with the same name in
        /// a different Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// To change the key that's associated with the alias, call <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>.
        /// To delete the alias, call <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>.
        /// These operations don't affect the underlying key. To get the alias that you created,
        /// call <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListAliases.html">ListAliases</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetAlias.html">GetAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListAliases.html">ListAliases</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
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
        /// Creates an Amazon Web Services Payment Cryptography key, a logical representation
        /// of a cryptographic key, that is unique in your account and Amazon Web Services Region.
        /// You use keys for cryptographic functions such as encryption and decryption. 
        /// 
        ///  
        /// <para>
        /// In addition to the key material used in cryptographic operations, an Amazon Web Services
        /// Payment Cryptography key includes metadata such as the key ARN, key usage, key origin,
        /// creation date, description, and key state.
        /// </para>
        ///  
        /// <para>
        /// When you create a key, you specify both immutable and mutable data about the key.
        /// The immutable data contains key attributes that define the scope and cryptographic
        /// operations that you can perform using the key, for example key class (example: <c>SYMMETRIC_KEY</c>),
        /// key algorithm (example: <c>TDES_2KEY</c>), key usage (example: <c>TR31_P0_PIN_ENCRYPTION_KEY</c>)
        /// and key modes of use (example: <c>Encrypt</c>). For information about valid combinations
        /// of key attributes, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// The mutable data contained within a key includes usage timestamp and key deletion
        /// timestamp and can be modified after creation.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography binds key attributes to keys using key blocks
        /// when you store or export them. Amazon Web Services Payment Cryptography stores the
        /// key contents wrapped and never stores or transmits them in the clear. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteKey.html">DeleteKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetKey.html">GetKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListKeys.html">ListKeys</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/CreateKey">REST API Reference for CreateKey Operation</seealso>
        public virtual Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyResponse>(request, options, cancellationToken);
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
        /// Deletes the alias, but doesn't affect the underlying key.
        /// 
        ///  
        /// <para>
        /// Each key can have multiple aliases. To get the aliases of all keys, use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
        /// operation. To change the alias of a key, first use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
        /// to delete the current alias and then use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
        /// to create a new alias. To associate an existing alias with a different key, call <a
        /// href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetAlias.html">GetAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListAliases.html">ListAliases</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKey

        internal virtual DeleteKeyResponse DeleteKey(DeleteKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the key material and metadata associated with Amazon Web Services Payment
        /// Cryptography key.
        /// 
        ///  
        /// <para>
        /// Key deletion is irreversible. After a key is deleted, you can't perform cryptographic
        /// operations using the key. For example, you can't decrypt data that was encrypted by
        /// a deleted Amazon Web Services Payment Cryptography key, and the data may become unrecoverable.
        /// Because key deletion is destructive, Amazon Web Services Payment Cryptography has
        /// a safety mechanism to prevent accidental deletion of a key. When you call this operation,
        /// Amazon Web Services Payment Cryptography disables the specified key but doesn't delete
        /// it until after a waiting period set using <c>DeleteKeyInDays</c>. The default waiting
        /// period is 7 days. During the waiting period, the <c>KeyState</c> is <c>DELETE_PENDING</c>.
        /// After the key is deleted, the <c>KeyState</c> is <c>DELETE_COMPLETE</c>.
        /// </para>
        ///  
        /// <para>
        /// You should delete a key only when you are sure that you don't need to use it anymore
        /// and no other parties are utilizing this key. If you aren't sure, consider deactivating
        /// it instead by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StopKeyUsage.html">StopKeyUsage</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_RestoreKey.html">RestoreKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StartKeyUsage.html">StartKeyUsage</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StopKeyUsage.html">StopKeyUsage</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        public virtual Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportKey

        internal virtual ExportKeyResponse ExportKey(ExportKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportKeyResponseUnmarshaller.Instance;

            return Invoke<ExportKeyResponse>(request, options);
        }



        /// <summary>
        /// Exports a key from Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography simplifies key exchange by replacing the
        /// existing paper-based approach with a modern electronic approach. With <c>ExportKey</c>
        /// you can export symmetric keys using either symmetric and asymmetric key exchange mechanisms.
        /// Using this operation, you can share your Amazon Web Services Payment Cryptography
        /// generated keys with other service partners to perform cryptographic operations outside
        /// of Amazon Web Services Payment Cryptography 
        /// </para>
        ///  
        /// <para>
        /// For symmetric key exchange, Amazon Web Services Payment Cryptography uses the ANSI
        /// X9 TR-31 norm in accordance with PCI PIN guidelines. And for asymmetric key exchange,
        /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm and RSA wrap
        /// and unwrap key exchange mechanism. Asymmetric key exchange methods are typically used
        /// to establish bi-directional trust between the two parties exhanging keys and are used
        /// for initial key exchange such as Key Encryption Key (KEK). After which you can export
        /// working keys using symmetric method to perform various cryptographic operations within
        /// Amazon Web Services Payment Cryptography.
        /// </para>
        ///  
        /// <para>
        /// The TR-34 norm is intended for exchanging 3DES keys only and keys are imported in
        /// a WrappedKeyBlock format. Key attributes (such as KeyUsage, KeyAlgorithm, KeyModesOfUse,
        /// Exportability) are contained within the key block. With RSA wrap and unwrap, you can
        /// exchange both 3DES and AES-128 keys. The keys are imported in a WrappedKeyCryptogram
        /// format and you will need to specify the key attributes during import. 
        /// </para>
        ///  
        /// <para>
        /// You can also use <c>ExportKey</c> functionality to generate and export an IPEK (Initial
        /// Pin Encryption Key) from Amazon Web Services Payment Cryptography using either TR-31
        /// or TR-34 export key exchange. IPEK is generated from BDK (Base Derivation Key) and
        /// <c>ExportDukptInitialKey</c> attribute KSN (<c>KeySerialNumber</c>). The generated
        /// IPEK does not persist within Amazon Web Services Payment Cryptography and has to be
        /// re-generated each time during export.
        /// </para>
        ///  
        /// <para>
        /// For key exchange using TR-31 or TR-34 key blocks, you can also export optional blocks
        /// within the key block header which contain additional attribute information about the
        /// key. The <c>KeyVersion</c> within <c>KeyBlockHeaders</c> indicates the version of
        /// the key within the key block. Furthermore, <c>KeyExportability</c> within <c>KeyBlockHeaders</c>
        /// can be used to further restrict exportability of the key after export from Amazon
        /// Web Services Payment Cryptography.
        /// </para>
        ///  
        /// <para>
        /// The <c>OptionalBlocks</c> contain the additional data related to the key. For information
        /// on data type that can be included within optional blocks, refer to <a href="https://webstore.ansi.org/standards/ascx9/ansix91432022">ASC
        /// X9.143-2022</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Data included in key block headers is signed but transmitted in clear text. Sensitive
        /// or confidential information should not be included in optional blocks. Refer to ASC
        /// X9.143-2022 standard for information on allowed data type.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>To export initial keys (KEK) or IPEK using TR-34</b> 
        /// </para>
        ///  
        /// <para>
        /// Using this operation, you can export initial key using TR-34 asymmetric key exchange.
        /// You can only export KEK generated within Amazon Web Services Payment Cryptography.
        /// In TR-34 terminology, the sending party of the key is called Key Distribution Host
        /// (KDH) and the receiving party of the key is called Key Receiving Device (KRD). During
        /// key export process, KDH is Amazon Web Services Payment Cryptography which initiates
        /// key export and KRD is the user receiving the key.
        /// </para>
        ///  
        /// <para>
        /// To initiate TR-34 key export, the KRD must obtain an export token by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForExport.html">GetParametersForExport</a>.
        /// This operation also generates a key pair for the purpose of key export, signs the
        /// key and returns back the signing public key certificate (also known as KDH signing
        /// certificate) and root certificate chain. The KDH uses the private key to sign the
        /// the export payload and the signing public key certificate is provided to KRD to verify
        /// the signature. The KRD can import the root certificate into its Hardware Security
        /// Module (HSM), as required. The export token and the associated KDH signing certificate
        /// expires after 7 days. 
        /// </para>
        ///  
        /// <para>
        /// Next the KRD generates a key pair for the the purpose of encrypting the KDH key and
        /// provides the public key cerificate (also known as KRD wrapping certificate) back to
        /// KDH. The KRD will also import the root cerificate chain into Amazon Web Services Payment
        /// Cryptography by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// for <c>RootCertificatePublicKey</c>. The KDH, Amazon Web Services Payment Cryptography,
        /// will use the KRD wrapping cerificate to encrypt (wrap) the key under export and signs
        /// it with signing private key to generate a TR-34 WrappedKeyBlock. For more information
        /// on TR-34 key export, see section <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-export.html">Exporting
        /// symmetric keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ExportAttributes</c>: Specify export attributes in case of IPEK export. This parameter
        /// is optional for KEK export.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExportKeyIdentifier</c>: The <c>KeyARN</c> of the KEK or BDK (in case of IPEK)
        /// under export.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>Tr34KeyBlock</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>KeyARN</c> of the certificate
        /// chain that signed the KRD wrapping key certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExportToken</c>: Obtained from KDH by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WrappingKeyCertificate</c>: The public key certificate in PEM format (base64 encoded)
        /// of the KRD wrapping key Amazon Web Services Payment Cryptography uses for encryption
        /// of the TR-34 export payload. This certificate must be signed by the root certificate
        /// (CertificateAuthorityPublicKeyIdentifier) imported into Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// the KEK or IPEK as a TR-34 WrappedKeyBlock. 
        /// </para>
        ///  
        /// <para>
        ///  <b>To export initial keys (KEK) or IPEK using RSA Wrap and Unwrap</b> 
        /// </para>
        ///  
        /// <para>
        /// Using this operation, you can export initial key using asymmetric RSA wrap and unwrap
        /// key exchange method. To initiate export, generate an asymmetric key pair on the receiving
        /// HSM and obtain the public key certificate in PEM format (base64 encoded) for the purpose
        /// of wrapping and the root certifiate chain. Import the root certificate into Amazon
        /// Web Services Payment Cryptography by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// for <c>RootCertificatePublicKey</c>.
        /// </para>
        ///  
        /// <para>
        /// Next call <c>ExportKey</c> and set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>KeyARN</c> of the certificate
        /// chain that signed wrapping key certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Set to <c>KeyCryptogram</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WrappingKeyCertificate</c>: The public key certificate in PEM format (base64 encoded)
        /// obtained by the receiving HSM and signed by the root certificate (CertificateAuthorityPublicKeyIdentifier)
        /// imported into Amazon Web Services Payment Cryptography. The receiving HSM uses its
        /// private key component to unwrap the WrappedKeyCryptogram.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// the WrappedKeyCryptogram. 
        /// </para>
        ///  
        /// <para>
        ///  <b>To export working keys or IPEK using TR-31</b> 
        /// </para>
        ///  
        /// <para>
        /// Using this operation, you can export working keys or IPEK using TR-31 symmetric key
        /// exchange. In TR-31, you must use an initial key such as KEK to encrypt or wrap the
        /// key under export. To establish a KEK, you can use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ExportAttributes</c>: Specify export attributes in case of IPEK export. This parameter
        /// is optional for KEK export.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExportKeyIdentifier</c>: The <c>KeyARN</c> of the KEK or BDK (in case of IPEK)
        /// under export.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>Tr31KeyBlock</c> parameters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// the working key or IPEK as a TR-31 WrappedKeyBlock.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForExport.html">GetParametersForExport</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ExportKey">REST API Reference for ExportKey Operation</seealso>
        public virtual Task<ExportKeyResponse> ExportKeyAsync(ExportKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportKeyResponseUnmarshaller.Instance;

            return InvokeAsync<ExportKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAlias

        internal virtual GetAliasResponse GetAlias(GetAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAliasResponseUnmarshaller.Instance;

            return Invoke<GetAliasResponse>(request, options);
        }



        /// <summary>
        /// Gets the Amazon Web Services Payment Cryptography key associated with the alias.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListAliases.html">ListAliases</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetAlias">REST API Reference for GetAlias Operation</seealso>
        public virtual Task<GetAliasResponse> GetAliasAsync(GetAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAliasResponseUnmarshaller.Instance;

            return InvokeAsync<GetAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetKey

        internal virtual GetKeyResponse GetKey(GetKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyResponseUnmarshaller.Instance;

            return Invoke<GetKeyResponse>(request, options);
        }



        /// <summary>
        /// Gets the key material for an Amazon Web Services Payment Cryptography key, including
        /// the immutable and mutable data specified when the key was created.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteKey.html">DeleteKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListKeys.html">ListKeys</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetKey">REST API Reference for GetKey Operation</seealso>
        public virtual Task<GetKeyResponse> GetKeyAsync(GetKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetParametersForExport

        internal virtual GetParametersForExportResponse GetParametersForExport(GetParametersForExportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForExportResponseUnmarshaller.Instance;

            return Invoke<GetParametersForExportResponse>(request, options);
        }



        /// <summary>
        /// Gets the export token and the signing key certificate to initiate a TR-34 key export
        /// from Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The signing key certificate signs the wrapped key under export within the TR-34 key
        /// payload. The export token and signing key certificate must be in place and operational
        /// before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>.
        /// The export token expires in 7 days. You can use the same export token to export multiple
        /// keys from your service account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForExport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParametersForExport service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetParametersForExport">REST API Reference for GetParametersForExport Operation</seealso>
        public virtual Task<GetParametersForExportResponse> GetParametersForExportAsync(GetParametersForExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForExportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForExportResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersForExportResponse>(request, options, cancellationToken);
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
        /// Gets the import token and the wrapping key certificate in PEM format (base64 encoded)
        /// to initiate a TR-34 WrappedKeyBlock or a RSA WrappedKeyCryptogram import into Amazon
        /// Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The wrapping key certificate wraps the key under import. The import token and wrapping
        /// key certificate must be in place and operational before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// The import token expires in 7 days. You can use the same import token to import multiple
        /// keys into your service account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForExport.html">GetParametersForExport</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        public virtual Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetParametersForImportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetParametersForImportResponseUnmarshaller.Instance;

            return InvokeAsync<GetParametersForImportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicKeyCertificate

        internal virtual GetPublicKeyCertificateResponse GetPublicKeyCertificate(GetPublicKeyCertificateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyCertificateResponseUnmarshaller.Instance;

            return Invoke<GetPublicKeyCertificateResponse>(request, options);
        }



        /// <summary>
        /// Gets the public key certificate of the asymmetric key pair that exists within Amazon
        /// Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// Unlike the private key of an asymmetric key, which never leaves Amazon Web Services
        /// Payment Cryptography unencrypted, callers with <c>GetPublicKeyCertificate</c> permission
        /// can download the public key certificate of the asymmetric key. You can share the public
        /// key certificate to allow others to encrypt messages and verify signatures outside
        /// of Amazon Web Services Payment Cryptography
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicKeyCertificate service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetPublicKeyCertificate">REST API Reference for GetPublicKeyCertificate Operation</seealso>
        public virtual Task<GetPublicKeyCertificateResponse> GetPublicKeyCertificateAsync(GetPublicKeyCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicKeyCertificateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicKeyCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicKeyCertificateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportKey

        internal virtual ImportKeyResponse ImportKey(ImportKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyResponseUnmarshaller.Instance;

            return Invoke<ImportKeyResponse>(request, options);
        }



        /// <summary>
        /// Imports symmetric keys and public key certificates in PEM format (base64 encoded)
        /// into Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography simplifies key exchange by replacing the
        /// existing paper-based approach with a modern electronic approach. With <c>ImportKey</c>
        /// you can import symmetric keys using either symmetric and asymmetric key exchange mechanisms.
        /// </para>
        ///  
        /// <para>
        /// For symmetric key exchange, Amazon Web Services Payment Cryptography uses the ANSI
        /// X9 TR-31 norm in accordance with PCI PIN guidelines. And for asymmetric key exchange,
        /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm and RSA wrap
        /// and unwrap key exchange mechanisms. Asymmetric key exchange methods are typically
        /// used to establish bi-directional trust between the two parties exhanging keys and
        /// are used for initial key exchange such as Key Encryption Key (KEK) or Zone Master
        /// Key (ZMK). After which you can import working keys using symmetric method to perform
        /// various cryptographic operations within Amazon Web Services Payment Cryptography.
        /// </para>
        ///  
        /// <para>
        /// The TR-34 norm is intended for exchanging 3DES keys only and keys are imported in
        /// a WrappedKeyBlock format. Key attributes (such as KeyUsage, KeyAlgorithm, KeyModesOfUse,
        /// Exportability) are contained within the key block. With RSA wrap and unwrap, you can
        /// exchange both 3DES and AES-128 keys. The keys are imported in a WrappedKeyCryptogram
        /// format and you will need to specify the key attributes during import. 
        /// </para>
        ///  
        /// <para>
        /// You can also import a <i>root public key certificate</i>, used to sign other public
        /// key certificates, or a <i>trusted public key certificate</i> under an already established
        /// root public key certificate.
        /// </para>
        ///  
        /// <para>
        ///  <b>To import a public root key certificate</b> 
        /// </para>
        ///  
        /// <para>
        /// You can also import a <i>root public key certificate</i>, used to sign other public
        /// key certificates, or a <i>trusted public key certificate</i> under an already established
        /// root public key certificate.
        /// </para>
        ///  
        /// <para>
        ///  <b>To import a public root key certificate</b> 
        /// </para>
        ///  
        /// <para>
        /// Using this operation, you can import the public component (in PEM cerificate format)
        /// of your private root key. You can use the imported public root key certificate for
        /// digital signatures, for example signing wrapping key or signing key in TR-34, within
        /// your Amazon Web Services Payment Cryptography account.
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: <c>RootCertificatePublicKey</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyClass</c>: <c>PUBLIC_KEY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyModesOfUse</c>: <c>Verify</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyUsage</c>: <c>TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PublicKeyCertificate</c>: The public key certificate in PEM format (base64 encoded)
        /// of the private root key under import.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>To import a trusted public key certificate</b> 
        /// </para>
        ///  
        /// <para>
        /// The root public key certificate must be in place and operational before you import
        /// a trusted public key certificate. Set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: <c>TrustedCertificatePublicKey</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: <c>KeyArn</c> of the <c>RootCertificatePublicKey</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KeyModesOfUse</c> and <c>KeyUsage</c>: Corresponding to the cryptographic operations
        /// such as wrap, sign, or encrypt that you will allow the trusted public key certificate
        /// to perform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PublicKeyCertificate</c>: The trusted public key certificate in PEM format (base64
        /// encoded) under import.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>To import initial keys (KEK or ZMK or similar) using TR-34</b> 
        /// </para>
        ///  
        /// <para>
        /// Using this operation, you can import initial key using TR-34 asymmetric key exchange.
        /// In TR-34 terminology, the sending party of the key is called Key Distribution Host
        /// (KDH) and the receiving party of the key is called Key Receiving Device (KRD). During
        /// the key import process, KDH is the user who initiates the key import and KRD is Amazon
        /// Web Services Payment Cryptography who receives the key.
        /// </para>
        ///  
        /// <para>
        /// To initiate TR-34 key import, the KDH must obtain an import token by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>.
        /// This operation generates an encryption keypair for the purpose of key import, signs
        /// the key and returns back the wrapping key certificate (also known as KRD wrapping
        /// certificate) and the root certificate chain. The KDH must trust and install the KRD
        /// wrapping certificate on its HSM and use it to encrypt (wrap) the KDH key during TR-34
        /// WrappedKeyBlock generation. The import token and associated KRD wrapping certificate
        /// expires after 7 days.
        /// </para>
        ///  
        /// <para>
        /// Next the KDH generates a key pair for the purpose of signing the encrypted KDH key
        /// and provides the public certificate of the signing key to Amazon Web Services Payment
        /// Cryptography. The KDH will also need to import the root certificate chain of the KDH
        /// signing certificate by calling <c>ImportKey</c> for <c>RootCertificatePublicKey</c>.
        /// For more information on TR-34 key import, see section <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-import.html">Importing
        /// symmetric keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>Tr34KeyBlock</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>KeyARN</c> of the certificate
        /// chain that signed the KDH signing key certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ImportToken</c>: Obtained from KRD by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WrappedKeyBlock</c>: The TR-34 wrapped key material from KDH. It contains the
        /// KDH key under import, wrapped with KRD wrapping certificate and signed by KDH signing
        /// private key. This TR-34 key block is typically generated by the KDH Hardware Security
        /// Module (HSM) outside of Amazon Web Services Payment Cryptography.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SigningKeyCertificate</c>: The public key certificate in PEM format (base64 encoded)
        /// of the KDH signing key generated under the root certificate (CertificateAuthorityPublicKeyIdentifier)
        /// imported in Amazon Web Services Payment Cryptography.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>To import initial keys (KEK or ZMK or similar) using RSA Wrap and Unwrap</b> 
        /// </para>
        ///  
        /// <para>
        /// Using this operation, you can import initial key using asymmetric RSA wrap and unwrap
        /// key exchange method. To initiate import, call <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>
        /// with <c>KeyMaterial</c> set to <c>KEY_CRYPTOGRAM</c> to generate an import token.
        /// This operation also generates an encryption keypair for the purpose of key import,
        /// signs the key and returns back the wrapping key certificate in PEM format (base64
        /// encoded) and its root certificate chain. The import token and associated KRD wrapping
        /// certificate expires after 7 days. 
        /// </para>
        ///  
        /// <para>
        /// You must trust and install the wrapping certificate and its certificate chain on the
        /// sending HSM and use it to wrap the key under export for WrappedKeyCryptogram generation.
        /// Next call <c>ImportKey</c> with <c>KeyMaterial</c> set to <c>KEY_CRYPTOGRAM</c> and
        /// provide the <c>ImportToken</c> and <c>KeyAttributes</c> for the key under import.
        /// </para>
        ///  
        /// <para>
        ///  <b>To import working keys using TR-31</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange norm to
        /// import working keys. A KEK must be established within Amazon Web Services Payment
        /// Cryptography by using TR-34 key import or by using <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// To initiate a TR-31 key import, set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>Tr31KeyBlock</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WrappedKeyBlock</c>: The TR-31 wrapped key material. It contains the key under
        /// import, encrypted using KEK. The TR-31 key block is typically generated by a HSM outside
        /// of Amazon Web Services Payment Cryptography. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WrappingKeyIdentifier</c>: The <c>KeyArn</c> of the KEK that Amazon Web Services
        /// Payment Cryptography uses to decrypt or unwrap the key under import.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetParametersForImport.html">GetParametersForImport</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ImportKey">REST API Reference for ImportKey Operation</seealso>
        public virtual Task<ImportKeyResponse> ImportKeyAsync(ImportKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyResponse>(request, options, cancellationToken);
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
        /// Lists the aliases for all keys in the caller's Amazon Web Services account and Amazon
        /// Web Services Region. You can filter the list of aliases. For more information, see
        /// <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-managealias.html">Using
        /// aliases</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the aliases. When the response contains only a subset of aliases, it
        /// includes a <c>NextToken</c> value. Use this value in a subsequent <c>ListAliases</c>
        /// request to get more aliases. When you receive a response with no NextToken (or an
        /// empty or null value), that means there are no more aliases to get.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetAlias.html">GetAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UpdateAlias.html">UpdateAlias</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
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
        /// Lists the keys in the caller's Amazon Web Services account and Amazon Web Services
        /// Region. You can filter the list of keys.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the keys. When the response contains only a subset of keys, it includes
        /// a <c>NextToken</c> value. Use this value in a subsequent <c>ListKeys</c> request to
        /// get more keys. When you receive a response with no NextToken (or an empty or null
        /// value), that means there are no more keys to get.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteKey.html">DeleteKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetKey.html">GetKey</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ListKeys">REST API Reference for ListKeys Operation</seealso>
        public virtual Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListKeysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ListKeysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags for an Amazon Web Services resource.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the tags. When the response contains only a subset of tags, it includes
        /// a <c>NextToken</c> value. Use this value in a subsequent <c>ListTagsForResource</c>
        /// request to get more tags. When you receive a response with no NextToken (or an empty
        /// or null value), that means there are no more tags to get.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_TagResource.html">TagResource</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UntagResource.html">UntagResource</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreKey

        internal virtual RestoreKeyResponse RestoreKey(RestoreKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreKeyResponseUnmarshaller.Instance;

            return Invoke<RestoreKeyResponse>(request, options);
        }



        /// <summary>
        /// Cancels a scheduled key deletion during the waiting period. Use this operation to
        /// restore a <c>Key</c> that is scheduled for deletion.
        /// 
        ///  
        /// <para>
        /// During the waiting period, the <c>KeyState</c> is <c>DELETE_PENDING</c> and <c>deletePendingTimestamp</c>
        /// contains the date and time after which the <c>Key</c> will be deleted. After <c>Key</c>
        /// is restored, the <c>KeyState</c> is <c>CREATE_COMPLETE</c>, and the value for <c>deletePendingTimestamp</c>
        /// is removed.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteKey.html">DeleteKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StartKeyUsage.html">StartKeyUsage</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StopKeyUsage.html">StopKeyUsage</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/RestoreKey">REST API Reference for RestoreKey Operation</seealso>
        public virtual Task<RestoreKeyResponse> RestoreKeyAsync(RestoreKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreKeyResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartKeyUsage

        internal virtual StartKeyUsageResponse StartKeyUsage(StartKeyUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyUsageResponseUnmarshaller.Instance;

            return Invoke<StartKeyUsageResponse>(request, options);
        }



        /// <summary>
        /// Enables an Amazon Web Services Payment Cryptography key, which makes it active for
        /// cryptographic operations within Amazon Web Services Payment Cryptography
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StopKeyUsage.html">StopKeyUsage</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartKeyUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartKeyUsage service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/StartKeyUsage">REST API Reference for StartKeyUsage Operation</seealso>
        public virtual Task<StartKeyUsageResponse> StartKeyUsageAsync(StartKeyUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartKeyUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartKeyUsageResponseUnmarshaller.Instance;

            return InvokeAsync<StartKeyUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopKeyUsage

        internal virtual StopKeyUsageResponse StopKeyUsage(StopKeyUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyUsageResponseUnmarshaller.Instance;

            return Invoke<StopKeyUsageResponse>(request, options);
        }



        /// <summary>
        /// Disables an Amazon Web Services Payment Cryptography key, which makes it inactive
        /// within Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// You can use this operation instead of <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteKey.html">DeleteKey</a>
        /// to deactivate a key. You can enable the key in the future by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StartKeyUsage.html">StartKeyUsage</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteKey.html">DeleteKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StartKeyUsage.html">StartKeyUsage</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopKeyUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopKeyUsage service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/StopKeyUsage">REST API Reference for StopKeyUsage Operation</seealso>
        public virtual Task<StopKeyUsageResponse> StopKeyUsageAsync(StopKeyUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopKeyUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopKeyUsageResponseUnmarshaller.Instance;

            return InvokeAsync<StopKeyUsageResponse>(request, options, cancellationToken);
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
        /// Adds or edits tags on an Amazon Web Services Payment Cryptography key.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging an Amazon Web Services Payment Cryptography key can allow or
        /// deny permission to the key.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each tag consists of a tag key and a tag value, both of which are case-sensitive strings.
        /// The tag value can be an empty (null) string. To add a tag, specify a new tag key and
        /// a tag value. To edit a tag, specify an existing tag key and a new tag value. You can
        /// also add tags to an Amazon Web Services Payment Cryptography key when you create it
        /// with <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_UntagResource.html">UntagResource</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Deletes a tag from an Amazon Web Services Payment Cryptography key.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging an Amazon Web Services Payment Cryptography key can allow or
        /// deny permission to the key.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_TagResource.html">TagResource</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// Associates an existing Amazon Web Services Payment Cryptography alias with a different
        /// key. Each alias is associated with only one Amazon Web Services Payment Cryptography
        /// key at a time, although a key can have multiple aliases. The alias and the Amazon
        /// Web Services Payment Cryptography key must be in the same Amazon Web Services account
        /// and Amazon Web Services Region
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateAlias.html">CreateAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DeleteAlias.html">DeleteAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetAlias.html">GetAlias</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ListAliases.html">ListAliases</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonPaymentCryptographyEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}