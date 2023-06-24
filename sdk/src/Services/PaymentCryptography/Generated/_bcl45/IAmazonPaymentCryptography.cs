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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PaymentCryptography.Model;

namespace Amazon.PaymentCryptography
{
    /// <summary>
    /// Interface for accessing PaymentCryptography
    ///
    /// You use the Amazon Web Services Payment Cryptography Control Plane to manage the encryption
    /// keys you use for payment-related cryptographic operations. You can create, import,
    /// export, share, manage, and delete keys. You can also manage Identity and Access Management
    /// (IAM) policies for keys. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/security-iam.html">Identity
    /// and access management</a> in the <i>Amazon Web Services Payment Cryptography User
    /// Guide.</i> 
    /// 
    ///  
    /// <para>
    /// To use encryption keys for payment-related transaction processing and associated cryptographic
    /// operations, you use the <a href="https://docs.aws.amazon.com/payment-cryptography/latest/DataAPIReference/Welcome.html">Amazon
    /// Web Services Payment Cryptography Data Plane</a>. You can encrypt, decrypt, generate,
    /// verify, and translate payment-related cryptographic operations. 
    /// </para>
    ///  
    /// <para>
    /// All Amazon Web Services Payment Cryptography API calls must be signed and transmitted
    /// using Transport Layer Security (TLS). We recommend you always use the latest supported
    /// TLS version for logging API requests. 
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services Payment Cryptography supports CloudTrail, a service that logs
    /// Amazon Web Services API calls and related events for your Amazon Web Services account
    /// and delivers them to an Amazon S3 bucket that you specify. By using the information
    /// collected by CloudTrail, you can determine what requests were made to Amazon Web Services
    /// Payment Cryptography, who made the request, when it was made, and so on. If you don't
    /// conﬁgure a trail, you can still view the most recent events in the CloudTrail console.
    /// For more information, see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/">CloudTrail
    /// User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonPaymentCryptography : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPaymentCryptographyPaginatorFactory Paginators { get; }

        
        #region  CreateAlias


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
        /// To change the key that's associated with the alias, call <a>UpdateAlias</a>. To delete
        /// the alias, call <a>DeleteAlias</a>. These operations don't affect the underlying key.
        /// To get the alias that you created, call <a>ListAliases</a>.
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
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
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
        CreateAliasResponse CreateAlias(CreateAliasRequest request);



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
        /// To change the key that's associated with the alias, call <a>UpdateAlias</a>. To delete
        /// the alias, call <a>DeleteAlias</a>. These operations don't affect the underlying key.
        /// To get the alias that you created, call <a>ListAliases</a>.
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
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
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
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateKey


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
        /// The immutable data contains key attributes that defines the scope and cryptographic
        /// operations that you can perform using the key, for example key class (example: <code>SYMMETRIC_KEY</code>),
        /// key algorithm (example: <code>TDES_2KEY</code>), key usage (example: <code>TR31_P0_PIN_ENCRYPTION_KEY</code>)
        /// and key modes of use (example: <code>Encrypt</code>). For information about valid
        /// combinations of key attributes, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
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
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
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
        CreateKeyResponse CreateKey(CreateKeyRequest request);



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
        /// The immutable data contains key attributes that defines the scope and cryptographic
        /// operations that you can perform using the key, for example key class (example: <code>SYMMETRIC_KEY</code>),
        /// key algorithm (example: <code>TDES_2KEY</code>), key usage (example: <code>TR31_P0_PIN_ENCRYPTION_KEY</code>)
        /// and key modes of use (example: <code>Encrypt</code>). For information about valid
        /// combinations of key attributes, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
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
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
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
        Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes the alias, but doesn't affect the underlying key.
        /// 
        ///  
        /// <para>
        /// Each key can have multiple aliases. To get the aliases of all keys, use the <a>ListAliases</a>
        /// operation. To change the alias of a key, first use <a>DeleteAlias</a> to delete the
        /// current alias and then use <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different key, call <a>UpdateAlias</a>.
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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
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
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);



        /// <summary>
        /// Deletes the alias, but doesn't affect the underlying key.
        /// 
        ///  
        /// <para>
        /// Each key can have multiple aliases. To get the aliases of all keys, use the <a>ListAliases</a>
        /// operation. To change the alias of a key, first use <a>DeleteAlias</a> to delete the
        /// current alias and then use <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different key, call <a>UpdateAlias</a>.
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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
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
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKey


        /// <summary>
        /// Deletes the key material and all metadata associated with Amazon Web Services Payment
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
        /// it until after a waiting period. The default waiting period is 7 days. To set a different
        /// waiting period, set <code>DeleteKeyInDays</code>. During the waiting period, the <code>KeyState</code>
        /// is <code>DELETE_PENDING</code>. After the key is deleted, the <code>KeyState</code>
        /// is <code>DELETE_COMPLETE</code>.
        /// </para>
        ///  
        /// <para>
        /// If you delete key material, you can use <a>ImportKey</a> to reimport the same key
        /// material into the Amazon Web Services Payment Cryptography key.
        /// </para>
        ///  
        /// <para>
        /// You should delete a key only when you are sure that you don't need to use it anymore
        /// and no other parties are utilizing this key. If you aren't sure, consider deactivating
        /// it instead by calling <a>StopKeyUsage</a>.
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
        ///  <a>RestoreKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartKeyUsage</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopKeyUsage</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKey service method.</param>
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
        DeleteKeyResponse DeleteKey(DeleteKeyRequest request);



        /// <summary>
        /// Deletes the key material and all metadata associated with Amazon Web Services Payment
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
        /// it until after a waiting period. The default waiting period is 7 days. To set a different
        /// waiting period, set <code>DeleteKeyInDays</code>. During the waiting period, the <code>KeyState</code>
        /// is <code>DELETE_PENDING</code>. After the key is deleted, the <code>KeyState</code>
        /// is <code>DELETE_COMPLETE</code>.
        /// </para>
        ///  
        /// <para>
        /// If you delete key material, you can use <a>ImportKey</a> to reimport the same key
        /// material into the Amazon Web Services Payment Cryptography key.
        /// </para>
        ///  
        /// <para>
        /// You should delete a key only when you are sure that you don't need to use it anymore
        /// and no other parties are utilizing this key. If you aren't sure, consider deactivating
        /// it instead by calling <a>StopKeyUsage</a>.
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
        ///  <a>RestoreKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartKeyUsage</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopKeyUsage</a> 
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
        Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportKey


        /// <summary>
        /// Exports a key from Amazon Web Services Payment Cryptography using either ANSI X9 TR-34
        /// or TR-31 key export standard.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography simplifies main or root key exchange process
        /// by eliminating the need of a paper-based key exchange process. It takes a modern and
        /// secure approach based of the ANSI X9 TR-34 key exchange standard.
        /// </para>
        ///  
        /// <para>
        /// You can use <code>ExportKey</code> to export main or root keys such as KEK (Key Encryption
        /// Key), using asymmetric key exchange technique following ANSI X9 TR-34 standard. The
        /// ANSI X9 TR-34 standard uses asymmetric keys to establishes bi-directional trust between
        /// the two parties exchanging keys. After which you can export working keys using the
        /// ANSI X9 TR-31 symmetric key exchange standard as mandated by PCI PIN. Using this operation,
        /// you can share your Amazon Web Services Payment Cryptography generated keys with other
        /// service partners to perform cryptographic operations outside of Amazon Web Services
        /// Payment Cryptography 
        /// </para>
        ///  
        /// <para>
        ///  <b>TR-34 key export</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-34 asymmetric key exchange standard
        /// to export main keys such as KEK. In TR-34 terminology, the sending party of the key
        /// is called Key Distribution Host (KDH) and the receiving party of the key is called
        /// Key Receiving Host (KRH). In key export process, KDH is Amazon Web Services Payment
        /// Cryptography which initiates key export. KRH is the user receiving the key. Before
        /// you initiate TR-34 key export, you must obtain an export token by calling <a>GetParametersForExport</a>.
        /// This operation also returns the signing key certificate that KDH uses to sign the
        /// wrapped key to generate a TR-34 wrapped key block. The export token expires after
        /// 7 days.
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <dl> <dt>CertificateAuthorityPublicKeyIdentifier</dt> <dd> 
        /// <para>
        /// The <code>KeyARN</code> of the certificate chain that will sign the wrapping key certificate.
        /// This must exist within Amazon Web Services Payment Cryptography before you initiate
        /// TR-34 key export. If it does not exist, you can import it by calling <a>ImportKey</a>
        /// for <code>RootCertificatePublicKey</code>.
        /// </para>
        ///  </dd> <dt>ExportToken</dt> <dd> 
        /// <para>
        /// Obtained from KDH by calling <a>GetParametersForExport</a>.
        /// </para>
        ///  </dd> <dt>WrappingKeyCertificate</dt> <dd> 
        /// <para>
        /// Amazon Web Services Payment Cryptography uses this to wrap the key under export.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// the TR-34 wrapped key block. 
        /// </para>
        ///  
        /// <para>
        ///  <b>TR-31 key export</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange standard
        /// to export working keys. In TR-31, you must use a main key such as KEK to encrypt or
        /// wrap the key under export. To establish a KEK, you can use <a>CreateKey</a> or <a>ImportKey</a>.
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// a TR-31 wrapped key block. 
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
        ///  <a>GetParametersForExport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportKey service method.</param>
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
        ExportKeyResponse ExportKey(ExportKeyRequest request);



        /// <summary>
        /// Exports a key from Amazon Web Services Payment Cryptography using either ANSI X9 TR-34
        /// or TR-31 key export standard.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography simplifies main or root key exchange process
        /// by eliminating the need of a paper-based key exchange process. It takes a modern and
        /// secure approach based of the ANSI X9 TR-34 key exchange standard.
        /// </para>
        ///  
        /// <para>
        /// You can use <code>ExportKey</code> to export main or root keys such as KEK (Key Encryption
        /// Key), using asymmetric key exchange technique following ANSI X9 TR-34 standard. The
        /// ANSI X9 TR-34 standard uses asymmetric keys to establishes bi-directional trust between
        /// the two parties exchanging keys. After which you can export working keys using the
        /// ANSI X9 TR-31 symmetric key exchange standard as mandated by PCI PIN. Using this operation,
        /// you can share your Amazon Web Services Payment Cryptography generated keys with other
        /// service partners to perform cryptographic operations outside of Amazon Web Services
        /// Payment Cryptography 
        /// </para>
        ///  
        /// <para>
        ///  <b>TR-34 key export</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-34 asymmetric key exchange standard
        /// to export main keys such as KEK. In TR-34 terminology, the sending party of the key
        /// is called Key Distribution Host (KDH) and the receiving party of the key is called
        /// Key Receiving Host (KRH). In key export process, KDH is Amazon Web Services Payment
        /// Cryptography which initiates key export. KRH is the user receiving the key. Before
        /// you initiate TR-34 key export, you must obtain an export token by calling <a>GetParametersForExport</a>.
        /// This operation also returns the signing key certificate that KDH uses to sign the
        /// wrapped key to generate a TR-34 wrapped key block. The export token expires after
        /// 7 days.
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <dl> <dt>CertificateAuthorityPublicKeyIdentifier</dt> <dd> 
        /// <para>
        /// The <code>KeyARN</code> of the certificate chain that will sign the wrapping key certificate.
        /// This must exist within Amazon Web Services Payment Cryptography before you initiate
        /// TR-34 key export. If it does not exist, you can import it by calling <a>ImportKey</a>
        /// for <code>RootCertificatePublicKey</code>.
        /// </para>
        ///  </dd> <dt>ExportToken</dt> <dd> 
        /// <para>
        /// Obtained from KDH by calling <a>GetParametersForExport</a>.
        /// </para>
        ///  </dd> <dt>WrappingKeyCertificate</dt> <dd> 
        /// <para>
        /// Amazon Web Services Payment Cryptography uses this to wrap the key under export.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// the TR-34 wrapped key block. 
        /// </para>
        ///  
        /// <para>
        ///  <b>TR-31 key export</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange standard
        /// to export working keys. In TR-31, you must use a main key such as KEK to encrypt or
        /// wrap the key under export. To establish a KEK, you can use <a>CreateKey</a> or <a>ImportKey</a>.
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// a TR-31 wrapped key block. 
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
        ///  <a>GetParametersForExport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKey</a> 
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
        Task<ExportKeyResponse> ExportKeyAsync(ExportKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAlias


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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlias service method.</param>
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
        GetAliasResponse GetAlias(GetAliasRequest request);



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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
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
        Task<GetAliasResponse> GetAliasAsync(GetAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKey


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
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKey service method.</param>
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
        GetKeyResponse GetKey(GetKeyRequest request);



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
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
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
        Task<GetKeyResponse> GetKeyAsync(GetKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParametersForExport


        /// <summary>
        /// Gets the export token and the signing key certificate to initiate a TR-34 key export
        /// from Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The signing key certificate signs the wrapped key under export within the TR-34 key
        /// payload. The export token and signing key certificate must be in place and operational
        /// before calling <a>ExportKey</a>. The export token expires in 7 days. You can use the
        /// same export token to export multiple keys from your service account.
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
        ///  <a>ExportKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForExport service method.</param>
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
        GetParametersForExportResponse GetParametersForExport(GetParametersForExportRequest request);



        /// <summary>
        /// Gets the export token and the signing key certificate to initiate a TR-34 key export
        /// from Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The signing key certificate signs the wrapped key under export within the TR-34 key
        /// payload. The export token and signing key certificate must be in place and operational
        /// before calling <a>ExportKey</a>. The export token expires in 7 days. You can use the
        /// same export token to export multiple keys from your service account.
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
        ///  <a>ExportKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
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
        Task<GetParametersForExportResponse> GetParametersForExportAsync(GetParametersForExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParametersForImport


        /// <summary>
        /// Gets the import token and the wrapping key certificate to initiate a TR-34 key import
        /// into Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The wrapping key certificate wraps the key under import within the TR-34 key payload.
        /// The import token and wrapping key certificate must be in place and operational before
        /// calling <a>ImportKey</a>. The import token expires in 7 days. The same import token
        /// can be used to import multiple keys into your service account.
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
        ///  <a>GetParametersForExport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
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
        GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request);



        /// <summary>
        /// Gets the import token and the wrapping key certificate to initiate a TR-34 key import
        /// into Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The wrapping key certificate wraps the key under import within the TR-34 key payload.
        /// The import token and wrapping key certificate must be in place and operational before
        /// calling <a>ImportKey</a>. The import token expires in 7 days. The same import token
        /// can be used to import multiple keys into your service account.
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
        ///  <a>GetParametersForExport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKey</a> 
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
        Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPublicKeyCertificate


        /// <summary>
        /// Gets the public key certificate of the asymmetric key pair that exists within Amazon
        /// Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// Unlike the private key of an asymmetric key, which never leaves Amazon Web Services
        /// Payment Cryptography unencrypted, callers with <code>GetPublicKeyCertificate</code>
        /// permission can download the public key certificate of the asymmetric key. You can
        /// share the public key certificate to allow others to encrypt messages and verify signatures
        /// outside of Amazon Web Services Payment Cryptography
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use:</b> This operation can't be used across different Amazon Web
        /// Services accounts.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKeyCertificate service method.</param>
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
        GetPublicKeyCertificateResponse GetPublicKeyCertificate(GetPublicKeyCertificateRequest request);



        /// <summary>
        /// Gets the public key certificate of the asymmetric key pair that exists within Amazon
        /// Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// Unlike the private key of an asymmetric key, which never leaves Amazon Web Services
        /// Payment Cryptography unencrypted, callers with <code>GetPublicKeyCertificate</code>
        /// permission can download the public key certificate of the asymmetric key. You can
        /// share the public key certificate to allow others to encrypt messages and verify signatures
        /// outside of Amazon Web Services Payment Cryptography
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
        Task<GetPublicKeyCertificateResponse> GetPublicKeyCertificateAsync(GetPublicKeyCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportKey


        /// <summary>
        /// Imports keys and public key certificates into Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography simplifies main or root key exchange process
        /// by eliminating the need of a paper-based key exchange process. It takes a modern and
        /// secure approach based of the ANSI X9 TR-34 key exchange standard. 
        /// </para>
        ///  
        /// <para>
        /// You can use <code>ImportKey</code> to import main or root keys such as KEK (Key Encryption
        /// Key) using asymmetric key exchange technique following the ANSI X9 TR-34 standard.
        /// The ANSI X9 TR-34 standard uses asymmetric keys to establishes bi-directional trust
        /// between the two parties exchanging keys. 
        /// </para>
        ///  
        /// <para>
        /// After you have imported a main or root key, you can import working keys to perform
        /// various cryptographic operations within Amazon Web Services Payment Cryptography using
        /// the ANSI X9 TR-31 symmetric key exchange standard as mandated by PCI PIN.
        /// </para>
        ///  
        /// <para>
        /// You can also import a <i>root public key certificate</i>, a self-signed certificate
        /// used to sign other public key certificates, or a <i>trusted public key certificate</i>
        /// under an already established root public key certificate. 
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
        ///  <code>KeyMaterial</code>: <code>RootCertificatePublicKey</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyClass</code>: <code>PUBLIC_KEY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyModesOfUse</code>: <code>Verify</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyUsage</code>: <code>TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PublicKeyCertificate</code>: The certificate authority used to sign the root
        /// public key certificate.
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
        ///  <code>KeyMaterial</code>: <code>TrustedCertificatePublicKey</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CertificateAuthorityPublicKeyIdentifier</code>: <code>KeyArn</code> of the
        /// <code>RootCertificatePublicKey</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyModesOfUse</code> and <code>KeyUsage</code>: Corresponding to the cryptographic
        /// operations such as wrap, sign, or encrypt that you will allow the trusted public key
        /// certificate to perform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PublicKeyCertificate</code>: The certificate authority used to sign the trusted
        /// public key certificate.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Import main keys</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-34 asymmetric key exchange standard
        /// to import main keys such as KEK. In TR-34 terminology, the sending party of the key
        /// is called Key Distribution Host (KDH) and the receiving party of the key is called
        /// Key Receiving Host (KRH). During the key import process, KDH is the user who initiates
        /// the key import and KRH is Amazon Web Services Payment Cryptography who receives the
        /// key. Before initiating TR-34 key import, you must obtain an import token by calling
        /// <a>GetParametersForImport</a>. This operation also returns the wrapping key certificate
        /// that KDH uses wrap key under import to generate a TR-34 wrapped key block. The import
        /// token expires after 7 days.
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CertificateAuthorityPublicKeyIdentifier</code>: The <code>KeyArn</code> of
        /// the certificate chain that will sign the signing key certificate and should exist
        /// within Amazon Web Services Payment Cryptography before initiating TR-34 key import.
        /// If it does not exist, you can import it by calling by calling <code>ImportKey</code>
        /// for <code>RootCertificatePublicKey</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ImportToken</code>: Obtained from KRH by calling <a>GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WrappedKeyBlock</code>: The TR-34 wrapped key block from KDH. It contains the
        /// KDH key under import, wrapped with KRH provided wrapping key certificate and signed
        /// by the KDH private signing key. This TR-34 key block is generated by the KDH Hardware
        /// Security Module (HSM) outside of Amazon Web Services Payment Cryptography.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SigningKeyCertificate</code>: The public component of the private key that
        /// signed the KDH TR-34 wrapped key block. In PEM certificate format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// TR-34 is intended primarily to exchange 3DES keys. Your ability to export AES-128
        /// and larger AES keys may be dependent on your source system.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Import working keys</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange standard
        /// to import working keys. A KEK must be established within Amazon Web Services Payment
        /// Cryptography by using TR-34 key import. To initiate a TR-31 key import, set the following
        /// parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WrappedKeyBlock</code>: The key under import and encrypted using KEK. The TR-31
        /// key block generated by your HSM outside of Amazon Web Services Payment Cryptography.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WrappingKeyIdentifier</code>: The <code>KeyArn</code> of the KEK that Amazon
        /// Web Services Payment Cryptography uses to decrypt or unwrap the key under import.
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
        ///  <a>ExportKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKey service method.</param>
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
        ImportKeyResponse ImportKey(ImportKeyRequest request);



        /// <summary>
        /// Imports keys and public key certificates into Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography simplifies main or root key exchange process
        /// by eliminating the need of a paper-based key exchange process. It takes a modern and
        /// secure approach based of the ANSI X9 TR-34 key exchange standard. 
        /// </para>
        ///  
        /// <para>
        /// You can use <code>ImportKey</code> to import main or root keys such as KEK (Key Encryption
        /// Key) using asymmetric key exchange technique following the ANSI X9 TR-34 standard.
        /// The ANSI X9 TR-34 standard uses asymmetric keys to establishes bi-directional trust
        /// between the two parties exchanging keys. 
        /// </para>
        ///  
        /// <para>
        /// After you have imported a main or root key, you can import working keys to perform
        /// various cryptographic operations within Amazon Web Services Payment Cryptography using
        /// the ANSI X9 TR-31 symmetric key exchange standard as mandated by PCI PIN.
        /// </para>
        ///  
        /// <para>
        /// You can also import a <i>root public key certificate</i>, a self-signed certificate
        /// used to sign other public key certificates, or a <i>trusted public key certificate</i>
        /// under an already established root public key certificate. 
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
        ///  <code>KeyMaterial</code>: <code>RootCertificatePublicKey</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyClass</code>: <code>PUBLIC_KEY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyModesOfUse</code>: <code>Verify</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyUsage</code>: <code>TR31_S0_ASYMMETRIC_KEY_FOR_DIGITAL_SIGNATURE</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PublicKeyCertificate</code>: The certificate authority used to sign the root
        /// public key certificate.
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
        ///  <code>KeyMaterial</code>: <code>TrustedCertificatePublicKey</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CertificateAuthorityPublicKeyIdentifier</code>: <code>KeyArn</code> of the
        /// <code>RootCertificatePublicKey</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyModesOfUse</code> and <code>KeyUsage</code>: Corresponding to the cryptographic
        /// operations such as wrap, sign, or encrypt that you will allow the trusted public key
        /// certificate to perform.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PublicKeyCertificate</code>: The certificate authority used to sign the trusted
        /// public key certificate.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Import main keys</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-34 asymmetric key exchange standard
        /// to import main keys such as KEK. In TR-34 terminology, the sending party of the key
        /// is called Key Distribution Host (KDH) and the receiving party of the key is called
        /// Key Receiving Host (KRH). During the key import process, KDH is the user who initiates
        /// the key import and KRH is Amazon Web Services Payment Cryptography who receives the
        /// key. Before initiating TR-34 key import, you must obtain an import token by calling
        /// <a>GetParametersForImport</a>. This operation also returns the wrapping key certificate
        /// that KDH uses wrap key under import to generate a TR-34 wrapped key block. The import
        /// token expires after 7 days.
        /// </para>
        ///  
        /// <para>
        /// Set the following parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CertificateAuthorityPublicKeyIdentifier</code>: The <code>KeyArn</code> of
        /// the certificate chain that will sign the signing key certificate and should exist
        /// within Amazon Web Services Payment Cryptography before initiating TR-34 key import.
        /// If it does not exist, you can import it by calling by calling <code>ImportKey</code>
        /// for <code>RootCertificatePublicKey</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ImportToken</code>: Obtained from KRH by calling <a>GetParametersForImport</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WrappedKeyBlock</code>: The TR-34 wrapped key block from KDH. It contains the
        /// KDH key under import, wrapped with KRH provided wrapping key certificate and signed
        /// by the KDH private signing key. This TR-34 key block is generated by the KDH Hardware
        /// Security Module (HSM) outside of Amazon Web Services Payment Cryptography.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SigningKeyCertificate</code>: The public component of the private key that
        /// signed the KDH TR-34 wrapped key block. In PEM certificate format.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// TR-34 is intended primarily to exchange 3DES keys. Your ability to export AES-128
        /// and larger AES keys may be dependent on your source system.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Import working keys</b> 
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services Payment Cryptography uses TR-31 symmetric key exchange standard
        /// to import working keys. A KEK must be established within Amazon Web Services Payment
        /// Cryptography by using TR-34 key import. To initiate a TR-31 key import, set the following
        /// parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WrappedKeyBlock</code>: The key under import and encrypted using KEK. The TR-31
        /// key block generated by your HSM outside of Amazon Web Services Payment Cryptography.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>WrappingKeyIdentifier</code>: The <code>KeyArn</code> of the KEK that Amazon
        /// Web Services Payment Cryptography uses to decrypt or unwrap the key under import.
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
        ///  <a>ExportKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
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
        Task<ImportKeyResponse> ImportKeyAsync(ImportKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAliases


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
        /// includes a <code>NextToken</code> value. Use this value in a subsequent <code>ListAliases</code>
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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
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
        ListAliasesResponse ListAliases(ListAliasesRequest request);



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
        /// includes a <code>NextToken</code> value. Use this value in a subsequent <code>ListAliases</code>
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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
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
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListKeys


        /// <summary>
        /// Lists the keys in the caller's Amazon Web Services account and Amazon Web Services
        /// Region. You can filter the list of keys.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the keys. When the response contains only a subset of keys, it includes
        /// a <code>NextToken</code> value. Use this value in a subsequent <code>ListKeys</code>
        /// request to get more keys. When you receive a response with no NextToken (or an empty
        /// or null value), that means there are no more keys to get.
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
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKey</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
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
        ListKeysResponse ListKeys(ListKeysRequest request);



        /// <summary>
        /// Lists the keys in the caller's Amazon Web Services account and Amazon Web Services
        /// Region. You can filter the list of keys.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the keys. When the response contains only a subset of keys, it includes
        /// a <code>NextToken</code> value. Use this value in a subsequent <code>ListKeys</code>
        /// request to get more keys. When you receive a response with no NextToken (or an empty
        /// or null value), that means there are no more keys to get.
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
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKey</a> 
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
        Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for an Amazon Web Services resource.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the tags. When the response contains only a subset of tags, it includes
        /// a <code>NextToken</code> value. Use this value in a subsequent <code>ListTagsForResource</code>
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
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags for an Amazon Web Services resource.
        /// 
        ///  
        /// <para>
        /// This is a paginated operation, which means that each response might contain only a
        /// subset of all the tags. When the response contains only a subset of tags, it includes
        /// a <code>NextToken</code> value. Use this value in a subsequent <code>ListTagsForResource</code>
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
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreKey


        /// <summary>
        /// Cancels a scheduled key deletion during the waiting period. Use this operation to
        /// restore a <code>Key</code> that is scheduled for deletion.
        /// 
        ///  
        /// <para>
        /// During the waiting period, the <code>KeyState</code> is <code>DELETE_PENDING</code>
        /// and <code>deletePendingTimestamp</code> contains the date and time after which the
        /// <code>Key</code> will be deleted. After <code>Key</code> is restored, the <code>KeyState</code>
        /// is <code>CREATE_COMPLETE</code>, and the value for <code>deletePendingTimestamp</code>
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
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartKeyUsage</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopKeyUsage</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreKey service method.</param>
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
        RestoreKeyResponse RestoreKey(RestoreKeyRequest request);



        /// <summary>
        /// Cancels a scheduled key deletion during the waiting period. Use this operation to
        /// restore a <code>Key</code> that is scheduled for deletion.
        /// 
        ///  
        /// <para>
        /// During the waiting period, the <code>KeyState</code> is <code>DELETE_PENDING</code>
        /// and <code>deletePendingTimestamp</code> contains the date and time after which the
        /// <code>Key</code> will be deleted. After <code>Key</code> is restored, the <code>KeyState</code>
        /// is <code>CREATE_COMPLETE</code>, and the value for <code>deletePendingTimestamp</code>
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
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartKeyUsage</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopKeyUsage</a> 
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
        Task<RestoreKeyResponse> RestoreKeyAsync(RestoreKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartKeyUsage


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
        ///  <a>StopKeyUsage</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartKeyUsage service method.</param>
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
        StartKeyUsageResponse StartKeyUsage(StartKeyUsageRequest request);



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
        ///  <a>StopKeyUsage</a> 
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
        Task<StartKeyUsageResponse> StartKeyUsageAsync(StartKeyUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopKeyUsage


        /// <summary>
        /// Disables an Amazon Web Services Payment Cryptography key, which makes it inactive
        /// within Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// You can use this operation instead of <a>DeleteKey</a> to deactivate a key. You can
        /// enable the key in the future by calling <a>StartKeyUsage</a>.
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
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartKeyUsage</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopKeyUsage service method.</param>
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
        StopKeyUsageResponse StopKeyUsage(StopKeyUsageRequest request);



        /// <summary>
        /// Disables an Amazon Web Services Payment Cryptography key, which makes it inactive
        /// within Amazon Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// You can use this operation instead of <a>DeleteKey</a> to deactivate a key. You can
        /// enable the key in the future by calling <a>StartKeyUsage</a>.
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
        ///  <a>DeleteKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StartKeyUsage</a> 
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
        Task<StopKeyUsageResponse> StopKeyUsageAsync(StopKeyUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


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
        /// with <a>CreateKey</a>.
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
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        /// with <a>CreateKey</a>.
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
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


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
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        ///  <a>ListTagsForResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAlias


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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
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
        UpdateAliasResponse UpdateAlias(UpdateAliasRequest request);



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
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
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
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}