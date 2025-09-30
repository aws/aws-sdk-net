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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PaymentCryptographyData.Model;
using Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations;
using Amazon.PaymentCryptographyData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PaymentCryptographyData
{
    /// <summary>
    /// <para>Implementation for accessing PaymentCryptographyData</para>
    ///
    /// You use the Amazon Web Services Payment Cryptography Data Plane to manage how encryption
    /// keys are used for payment-related transaction processing and associated cryptographic
    /// operations. You can encrypt, decrypt, generate, verify, and translate payment-related
    /// cryptographic operations in Amazon Web Services Payment Cryptography. For more information,
    /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/data-operations.html">Data
    /// operations</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
    /// 
    ///  
    /// <para>
    /// To manage your encryption keys, you use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/Welcome.html">Amazon
    /// Web Services Payment Cryptography Control Plane</a>. You can create, import, export,
    /// share, manage, and delete keys. You can also manage Identity and Access Management
    /// (IAM) policies for keys. 
    /// </para>
    /// </summary>
    public partial class AmazonPaymentCryptographyDataClient : AmazonServiceClient, IAmazonPaymentCryptographyData
    {
        private static IServiceMetadata serviceMetadata = new AmazonPaymentCryptographyDataMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with the credentials loaded from the application's
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
        public AmazonPaymentCryptographyDataClient()
            : base(new AmazonPaymentCryptographyDataConfig()) { }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with the credentials loaded from the application's
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
        public AmazonPaymentCryptographyDataClient(RegionEndpoint region)
            : base(new AmazonPaymentCryptographyDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(AmazonPaymentCryptographyDataConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPaymentCryptographyDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonPaymentCryptographyDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPaymentCryptographyDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Credentials and an
        /// AmazonPaymentCryptographyDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(AWSCredentials credentials, AmazonPaymentCryptographyDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentCryptographyDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPaymentCryptographyDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentCryptographyDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonPaymentCryptographyDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentCryptographyDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPaymentCryptographyDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPaymentCryptographyDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPaymentCryptographyDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPaymentCryptographyDataClient Configuration Object</param>
        public AmazonPaymentCryptographyDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPaymentCryptographyDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPaymentCryptographyDataEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPaymentCryptographyDataAuthSchemeHandler());
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


        #region  DecryptData

        internal virtual DecryptDataResponse DecryptData(DecryptDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptDataResponseUnmarshaller.Instance;

            return Invoke<DecryptDataResponse>(request, options);
        }



        /// <summary>
        /// Decrypts ciphertext data to plaintext using a symmetric (TDES, AES), asymmetric (RSA),
        /// or derived (DUKPT or EMV) encryption key scheme. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/decrypt-data.html">Decrypt
        /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use an decryption key generated within Amazon Web Services Payment Cryptography,
        /// or you can import your own decryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// For this operation, the key must have <c>KeyModesOfUse</c> set to <c>Decrypt</c>.
        /// In asymmetric decryption, Amazon Web Services Payment Cryptography decrypts the ciphertext
        /// using the private component of the asymmetric encryption key pair. For data encryption
        /// outside of Amazon Web Services Payment Cryptography, you can export the public component
        /// of the asymmetric key pair by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation also supports dynamic keys, allowing you to pass a dynamic decryption
        /// key as a TR-31 WrappedKeyBlock. This can be used when key material is frequently rotated,
        /// such as during every card transaction, and there is need to avoid importing short-lived
        /// keys into Amazon Web Services Payment Cryptography. To decrypt using dynamic keys,
        /// the <c>keyARN</c> is the Key Encryption Key (KEK) of the TR-31 wrapped decryption
        /// key material. The incoming wrapped key shall have a key purpose of D0 with a mode
        /// of use of B or D. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/use-cases-acquirers-dynamickeys.html">Using
        /// Dynamic Keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For symmetric and DUKPT decryption, Amazon Web Services Payment Cryptography supports
        /// <c>TDES</c> and <c>AES</c> algorithms. For EMV decryption, Amazon Web Services Payment
        /// Cryptography supports <c>TDES</c> algorithms. For asymmetric decryption, Amazon Web
        /// Services Payment Cryptography supports <c>RSA</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you use TDES or TDES DUKPT, the ciphertext data length must be a multiple of
        /// 8 bytes. For AES or AES DUKPT, the ciphertext data length must be a multiple of 16
        /// bytes. For RSA, it sould be equal to the key size unless padding is enabled.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
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
        ///  <a>EncryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DecryptData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DecryptData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/DecryptData">REST API Reference for DecryptData Operation</seealso>
        public virtual Task<DecryptDataResponse> DecryptDataAsync(DecryptDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DecryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DecryptDataResponseUnmarshaller.Instance;

            return InvokeAsync<DecryptDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EncryptData

        internal virtual EncryptDataResponse EncryptData(EncryptDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptDataResponseUnmarshaller.Instance;

            return Invoke<EncryptDataResponse>(request, options);
        }



        /// <summary>
        /// Encrypts plaintext data to ciphertext using a symmetric (TDES, AES), asymmetric (RSA),
        /// or derived (DUKPT or EMV) encryption key scheme. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/encrypt-data.html">Encrypt
        /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can generate an encryption key within Amazon Web Services Payment Cryptography
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// You can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// </para>
        ///  
        /// <para>
        /// For this operation, the key must have <c>KeyModesOfUse</c> set to <c>Encrypt</c>.
        /// In asymmetric encryption, plaintext is encrypted using public component. You can import
        /// the public component of an asymmetric key pair created outside Amazon Web Services
        /// Payment Cryptography by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// This operation also supports dynamic keys, allowing you to pass a dynamic encryption
        /// key as a TR-31 WrappedKeyBlock. This can be used when key material is frequently rotated,
        /// such as during every card transaction, and there is need to avoid importing short-lived
        /// keys into Amazon Web Services Payment Cryptography. To encrypt using dynamic keys,
        /// the <c>keyARN</c> is the Key Encryption Key (KEK) of the TR-31 wrapped encryption
        /// key material. The incoming wrapped key shall have a key purpose of D0 with a mode
        /// of use of B or D. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/use-cases-acquirers-dynamickeys.html">Using
        /// Dynamic Keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
        /// <c>TDES</c> and <c>AES</c> algorithms. For EMV encryption, Amazon Web Services Payment
        /// Cryptography supports <c>TDES</c> algorithms.For asymmetric encryption, Amazon Web
        /// Services Payment Cryptography supports <c>RSA</c>. 
        /// </para>
        ///  
        /// <para>
        /// When you use TDES or TDES DUKPT, the plaintext data length must be a multiple of 8
        /// bytes. For AES or AES DUKPT, the plaintext data length must be a multiple of 16 bytes.
        /// For RSA, it sould be equal to the key size unless padding is enabled.
        /// </para>
        ///  
        /// <para>
        /// To encrypt using DUKPT, you must already have a BDK (Base Derivation Key) key in your
        /// account with <c>KeyModesOfUse</c> set to <c>DeriveKey</c>, or you can generate a new
        /// DUKPT key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// To encrypt using EMV, you must already have an IMK (Issuer Master Key) key in your
        /// account with <c>KeyModesOfUse</c> set to <c>DeriveKey</c>.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
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
        ///  <a>DecryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReEncryptData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EncryptData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EncryptData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/EncryptData">REST API Reference for EncryptData Operation</seealso>
        public virtual Task<EncryptDataResponse> EncryptDataAsync(EncryptDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EncryptDataResponseUnmarshaller.Instance;

            return InvokeAsync<EncryptDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateCardValidationData

        internal virtual GenerateCardValidationDataResponse GenerateCardValidationData(GenerateCardValidationDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCardValidationDataResponseUnmarshaller.Instance;

            return Invoke<GenerateCardValidationDataResponse>(request, options);
        }



        /// <summary>
        /// Generates card-related validation data using algorithms such as Card Verification
        /// Values (CVV/CVV2), Dynamic Card Verification Values (dCVV/dCVV2), or Card Security
        /// Codes (CSC). For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/generate-card-data.html">Generate
        /// card data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation generates a CVV or CSC value that is printed on a payment credit or
        /// debit card during card production. The CVV or CSC, PAN (Primary Account Number) and
        /// expiration date of the card are required to check its validity during transaction
        /// processing. To begin this operation, a CVK (Card Verification Key) encryption key
        /// is required. You can use <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// or <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// to establish a CVK within Amazon Web Services Payment Cryptography. The <c>KeyModesOfUse</c>
        /// should be set to <c>Generate</c> and <c>Verify</c> for a CVK encryption key. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyCardValidationData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateCardValidationData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateCardValidationData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateCardValidationData">REST API Reference for GenerateCardValidationData Operation</seealso>
        public virtual Task<GenerateCardValidationDataResponse> GenerateCardValidationDataAsync(GenerateCardValidationDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateCardValidationDataResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateCardValidationDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateMac

        internal virtual GenerateMacResponse GenerateMac(GenerateMacRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMacResponseUnmarshaller.Instance;

            return Invoke<GenerateMacResponse>(request, options);
        }



        /// <summary>
        /// Generates a Message Authentication Code (MAC) cryptogram within Amazon Web Services
        /// Payment Cryptography. 
        /// 
        ///  
        /// <para>
        /// You can use this operation to authenticate card-related data by using known data values
        /// to generate MAC for data validation between the sending and receiving parties. This
        /// operation uses message data, a secret encryption key and MAC algorithm to generate
        /// a unique MAC value for transmission. The receiving party of the MAC must use the same
        /// message data, secret encryption key and MAC algorithm to reproduce another MAC value
        /// for comparision.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to generate a DUPKT, CMAC, HMAC or EMV MAC by setting generation
        /// attributes and algorithm to the associated values. The MAC generation encryption key
        /// must have valid values for <c>KeyUsage</c> such as <c>TR31_M7_HMAC_KEY</c> for HMAC
        /// generation, and they key must have <c>KeyModesOfUse</c> set to <c>Generate</c> and
        /// <c>Verify</c>.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
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
        ///  <a>VerifyMac</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMac service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateMac service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateMac">REST API Reference for GenerateMac Operation</seealso>
        public virtual Task<GenerateMacResponse> GenerateMacAsync(GenerateMacRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMacResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateMacResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GenerateMacEmvPinChange

        internal virtual GenerateMacEmvPinChangeResponse GenerateMacEmvPinChange(GenerateMacEmvPinChangeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMacEmvPinChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMacEmvPinChangeResponseUnmarshaller.Instance;

            return Invoke<GenerateMacEmvPinChangeResponse>(request, options);
        }



        /// <summary>
        /// Generates an issuer script mac for EMV payment cards that use offline PINs as the
        /// cardholder verification method (CVM).
        /// 
        ///  
        /// <para>
        /// This operation generates an authenticated issuer script response by appending the
        /// incoming message data (APDU command) with the target encrypted PIN block in ISO2 format.
        /// The command structure and method to send the issuer script update to the card is not
        /// defined by this operation and is typically determined by the applicable payment card
        /// scheme.
        /// </para>
        ///  
        /// <para>
        /// The primary inputs to this operation include the incoming new encrypted pinblock,
        /// PIN encryption key (PEK), issuer master key (IMK), primary account number (PAN), and
        /// the payment card derivation method.
        /// </para>
        ///  
        /// <para>
        /// The operation uses two issuer master keys - secure messaging for confidentiality (IMK-SMC)
        /// and secure messaging for integrity (IMK-SMI). The SMC key is used to internally derive
        /// a key to secure the pin, while SMI key is used to internally derive a key to authenticate
        /// the script reponse as per the <a href="https://www.emvco.com/specifications/">EMV
        /// 4.4 - Book 2 - Security and Key Management</a> specification. 
        /// </para>
        ///  
        /// <para>
        /// This operation supports Amex, EMV2000, EMVCommon, Mastercard and Visa derivation methods,
        /// each requiring specific input parameters. Users must follow the specific derivation
        /// method and input parameters defined by the respective payment card scheme.
        /// </para>
        ///  <note> 
        /// <para>
        /// Use <a>GenerateMac</a> operation when sending a script update to an EMV card that
        /// does not involve PIN change. When assigning IAM permissions, it is important to understand
        /// that <a>EncryptData</a> using EMV keys and <a>GenerateMac</a> perform similar functions
        /// to this command.
        /// </para>
        ///  </note> 
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
        ///  <a>EncryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateMac</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMacEmvPinChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateMacEmvPinChange service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateMacEmvPinChange">REST API Reference for GenerateMacEmvPinChange Operation</seealso>
        public virtual Task<GenerateMacEmvPinChangeResponse> GenerateMacEmvPinChangeAsync(GenerateMacEmvPinChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GenerateMacEmvPinChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GenerateMacEmvPinChangeResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateMacEmvPinChangeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GeneratePinData

        internal virtual GeneratePinDataResponse GeneratePinData(GeneratePinDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GeneratePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeneratePinDataResponseUnmarshaller.Instance;

            return Invoke<GeneratePinDataResponse>(request, options);
        }



        /// <summary>
        /// Generates pin-related data such as PIN, PIN Verification Value (PVV), PIN Block, and
        /// PIN Offset during new card issuance or reissuance. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/generate-pin-data.html">Generate
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// PIN data is never transmitted in clear to or from Amazon Web Services Payment Cryptography.
        /// This operation generates PIN, PVV, or PIN Offset and then encrypts it using Pin Encryption
        /// Key (PEK) to create an <c>EncryptedPinBlock</c> for transmission from Amazon Web Services
        /// Payment Cryptography. This operation uses a separate Pin Verification Key (PVK) for
        /// VISA PVV generation. 
        /// </para>
        ///  
        /// <para>
        /// Using ECDH key exchange, you can receive cardholder selectable PINs into Amazon Web
        /// Services Payment Cryptography. The ECDH derived key protects the incoming PIN block.
        /// You can also use it for reveal PIN, wherein the generated PIN block is protected by
        /// the ECDH derived key before transmission from Amazon Web Services Payment Cryptography.
        /// For more information on establishing ECDH derived keys, see the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/create-keys.html">Generating
        /// keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
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
        ///  <a>GenerateCardValidationData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TranslatePinData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GeneratePinData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GeneratePinData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GeneratePinData">REST API Reference for GeneratePinData Operation</seealso>
        public virtual Task<GeneratePinDataResponse> GeneratePinDataAsync(GeneratePinDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GeneratePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GeneratePinDataResponseUnmarshaller.Instance;

            return InvokeAsync<GeneratePinDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ReEncryptData

        internal virtual ReEncryptDataResponse ReEncryptData(ReEncryptDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReEncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptDataResponseUnmarshaller.Instance;

            return Invoke<ReEncryptDataResponse>(request, options);
        }



        /// <summary>
        /// Re-encrypt ciphertext using DUKPT or Symmetric data encryption keys. 
        /// 
        ///  
        /// <para>
        /// You can either generate an encryption key within Amazon Web Services Payment Cryptography
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// or import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// The <c>KeyArn</c> for use with this operation must be in a compatible key state with
        /// <c>KeyModesOfUse</c> set to <c>Encrypt</c>. 
        /// </para>
        ///  
        /// <para>
        /// This operation also supports dynamic keys, allowing you to pass a dynamic encryption
        /// key as a TR-31 WrappedKeyBlock. This can be used when key material is frequently rotated,
        /// such as during every card transaction, and there is need to avoid importing short-lived
        /// keys into Amazon Web Services Payment Cryptography. To re-encrypt using dynamic keys,
        /// the <c>keyARN</c> is the Key Encryption Key (KEK) of the TR-31 wrapped encryption
        /// key material. The incoming wrapped key shall have a key purpose of D0 with a mode
        /// of use of B or D. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/use-cases-acquirers-dynamickeys.html">Using
        /// Dynamic Keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
        /// <c>TDES</c> and <c>AES</c> algorithms. To encrypt using DUKPT, a DUKPT key must already
        /// exist within your account with <c>KeyModesOfUse</c> set to <c>DeriveKey</c> or a new
        /// DUKPT can be generated by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
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
        ///  <a>DecryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EncryptData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncryptData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReEncryptData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/ReEncryptData">REST API Reference for ReEncryptData Operation</seealso>
        public virtual Task<ReEncryptDataResponse> ReEncryptDataAsync(ReEncryptDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReEncryptDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReEncryptDataResponseUnmarshaller.Instance;

            return InvokeAsync<ReEncryptDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TranslatePinData

        internal virtual TranslatePinDataResponse TranslatePinData(TranslatePinDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TranslatePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslatePinDataResponseUnmarshaller.Instance;

            return Invoke<TranslatePinDataResponse>(request, options);
        }



        /// <summary>
        /// Translates encrypted PIN block from and to ISO 9564 formats 0,1,3,4. For more information,
        /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/translate-pin-data.html">Translate
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// PIN block translation involves changing a PIN block from one encryption key to another
        /// and optionally change its format. PIN block translation occurs entirely within the
        /// HSM boundary and PIN data never enters or leaves Amazon Web Services Payment Cryptography
        /// in clear text. The encryption key transformation can be from PEK (Pin Encryption Key)
        /// to BDK (Base Derivation Key) for DUKPT or from BDK for DUKPT to PEK.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography also supports use of dynamic keys and ECDH
        /// (Elliptic Curve Diffie-Hellman) based key exchange for this operation.
        /// </para>
        ///  
        /// <para>
        /// Dynamic keys allow you to pass a PEK as a TR-31 WrappedKeyBlock. They can be used
        /// when key material is frequently rotated, such as during every card transaction, and
        /// there is need to avoid importing short-lived keys into Amazon Web Services Payment
        /// Cryptography. To translate PIN block using dynamic keys, the <c>keyARN</c> is the
        /// Key Encryption Key (KEK) of the TR-31 wrapped PEK. The incoming wrapped key shall
        /// have a key purpose of P0 with a mode of use of B or D. For more information, see <a
        /// href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/use-cases-acquirers-dynamickeys.html">Using
        /// Dynamic Keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Using ECDH key exchange, you can receive cardholder selectable PINs into Amazon Web
        /// Services Payment Cryptography. The ECDH derived key protects the incoming PIN block,
        /// which is translated to a PEK encrypted PIN block for use within the service. You can
        /// also use ECDH for reveal PIN, wherein the service translates the PIN block from PEK
        /// to a ECDH derived encryption key. For more information on establishing ECDH derived
        /// keys, see the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/create-keys.html">Generating
        /// keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The allowed combinations of PIN block format translations are guided by PCI. It is
        /// important to note that not all encrypted PIN block formats (example, format 1) require
        /// PAN (Primary Account Number) as input. And as such, PIN block format that requires
        /// PAN (example, formats 0,3,4) cannot be translated to a format (format 1) that does
        /// not require a PAN for generation. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services Payment Cryptography currently supports ISO PIN block 4 translation
        /// for PIN block built using legacy PAN length. That is, PAN is the right most 12 digits
        /// excluding the check digits.
        /// </para>
        ///  </note> 
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
        ///  <a>GeneratePinData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TranslatePinData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TranslatePinData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/TranslatePinData">REST API Reference for TranslatePinData Operation</seealso>
        public virtual Task<TranslatePinDataResponse> TranslatePinDataAsync(TranslatePinDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TranslatePinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TranslatePinDataResponseUnmarshaller.Instance;

            return InvokeAsync<TranslatePinDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  VerifyAuthRequestCryptogram

        internal virtual VerifyAuthRequestCryptogramResponse VerifyAuthRequestCryptogram(VerifyAuthRequestCryptogramRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyAuthRequestCryptogramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyAuthRequestCryptogramResponseUnmarshaller.Instance;

            return Invoke<VerifyAuthRequestCryptogramResponse>(request, options);
        }



        /// <summary>
        /// Verifies Authorization Request Cryptogram (ARQC) for a EMV chip payment card authorization.
        /// For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/data-operations.verifyauthrequestcryptogram.html">Verify
        /// auth request cryptogram</a> in the <i>Amazon Web Services Payment Cryptography User
        /// Guide</i>.
        /// 
        ///  
        /// <para>
        /// ARQC generation is done outside of Amazon Web Services Payment Cryptography and is
        /// typically generated on a point of sale terminal for an EMV chip card to obtain payment
        /// authorization during transaction time. For ARQC verification, you must first import
        /// the ARQC generated outside of Amazon Web Services Payment Cryptography by calling
        /// <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// This operation uses the imported ARQC and an major encryption key (DUKPT) created
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// to either provide a boolean ARQC verification result or provide an APRC (Authorization
        /// Response Cryptogram) response using Method 1 or Method 2. The <c>ARPC_METHOD_1</c>
        /// uses <c>AuthResponseCode</c> to generate ARPC and <c>ARPC_METHOD_2</c> uses <c>CardStatusUpdate</c>
        /// to generate ARPC. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>.
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
        ///  <a>VerifyCardValidationData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyAuthRequestCryptogram service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyAuthRequestCryptogram service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyAuthRequestCryptogram">REST API Reference for VerifyAuthRequestCryptogram Operation</seealso>
        public virtual Task<VerifyAuthRequestCryptogramResponse> VerifyAuthRequestCryptogramAsync(VerifyAuthRequestCryptogramRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyAuthRequestCryptogramRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyAuthRequestCryptogramResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyAuthRequestCryptogramResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  VerifyCardValidationData

        internal virtual VerifyCardValidationDataResponse VerifyCardValidationData(VerifyCardValidationDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyCardValidationDataResponseUnmarshaller.Instance;

            return Invoke<VerifyCardValidationDataResponse>(request, options);
        }



        /// <summary>
        /// Verifies card-related validation data using algorithms such as Card Verification Values
        /// (CVV/CVV2), Dynamic Card Verification Values (dCVV/dCVV2) and Card Security Codes
        /// (CSC). For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/verify-card-data.html">Verify
        /// card data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation validates the CVV or CSC codes that is printed on a payment credit
        /// or debit card during card payment transaction. The input values are typically provided
        /// as part of an inbound transaction to an issuer or supporting platform partner. Amazon
        /// Web Services Payment Cryptography uses CVV or CSC, PAN (Primary Account Number) and
        /// expiration date of the card to check its validity during transaction processing. In
        /// this operation, the CVK (Card Verification Key) encryption key for use with card data
        /// verification is same as the one in used for <a>GenerateCardValidationData</a>. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
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
        ///  <a>GenerateCardValidationData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyAuthRequestCryptogram</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>VerifyPinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyCardValidationData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyCardValidationData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyCardValidationData">REST API Reference for VerifyCardValidationData Operation</seealso>
        public virtual Task<VerifyCardValidationDataResponse> VerifyCardValidationDataAsync(VerifyCardValidationDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyCardValidationDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyCardValidationDataResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyCardValidationDataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  VerifyMac

        internal virtual VerifyMacResponse VerifyMac(VerifyMacRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyMacResponseUnmarshaller.Instance;

            return Invoke<VerifyMacResponse>(request, options);
        }



        /// <summary>
        /// Verifies a Message Authentication Code (MAC). 
        /// 
        ///  
        /// <para>
        /// You can use this operation to verify MAC for message data authentication such as .
        /// In this operation, you must use the same message data, secret encryption key and MAC
        /// algorithm that was used to generate MAC. You can use this operation to verify a DUPKT,
        /// CMAC, HMAC or EMV MAC by setting generation attributes and algorithm to the associated
        /// values. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
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
        ///  <a>GenerateMac</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyMac service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyMac service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyMac">REST API Reference for VerifyMac Operation</seealso>
        public virtual Task<VerifyMacResponse> VerifyMacAsync(VerifyMacRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyMacRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyMacResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyMacResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  VerifyPinData

        internal virtual VerifyPinDataResponse VerifyPinData(VerifyPinDataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyPinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyPinDataResponseUnmarshaller.Instance;

            return Invoke<VerifyPinDataResponse>(request, options);
        }



        /// <summary>
        /// Verifies pin-related data such as PIN and PIN Offset using algorithms including VISA
        /// PVV and IBM3624. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/verify-pin-data.html">Verify
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This operation verifies PIN data for user payment card. A card holder PIN data is
        /// never transmitted in clear to or from Amazon Web Services Payment Cryptography. This
        /// operation uses PIN Verification Key (PVK) for PIN or PIN Offset generation and then
        /// encrypts it using PIN Encryption Key (PEK) to create an <c>EncryptedPinBlock</c> for
        /// transmission from Amazon Web Services Payment Cryptography. 
        /// </para>
        ///  
        /// <para>
        /// For information about valid keys for this operation, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> and <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/crypto-ops-validkeys-ops.html">Key
        /// types for specific data operations</a> in the <i>Amazon Web Services Payment Cryptography
        /// User Guide</i>. 
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
        ///  <a>GeneratePinData</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TranslatePinData</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyPinData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyPinData service method, as returned by PaymentCryptographyData.</returns>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ResourceNotFoundException">
        /// The request was denied due to an invalid resource error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptographyData.Model.VerificationFailedException">
        /// This request failed verification.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyPinData">REST API Reference for VerifyPinData Operation</seealso>
        public virtual Task<VerifyPinDataResponse> VerifyPinDataAsync(VerifyPinDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyPinDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyPinDataResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyPinDataResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}