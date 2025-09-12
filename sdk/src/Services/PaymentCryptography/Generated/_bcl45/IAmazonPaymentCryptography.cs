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

#pragma warning disable CS1570
namespace Amazon.PaymentCryptography
{
    /// <summary>
    /// <para>Interface for accessing PaymentCryptography</para>
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
    public partial interface IAmazonPaymentCryptography : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPaymentCryptographyPaginatorFactory Paginators { get; }

        
        #region  AddKeyReplicationRegions


        /// <summary>
        /// Adds replication Amazon Web Services Regions to an existing Amazon Web Services Payment
        /// Cryptography key, enabling the key to be used for cryptographic operations in additional
        /// Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// Multi-region keys allow you to use the same key material across multiple Amazon Web
        /// Services Regions, providing lower latency for applications distributed across regions.
        /// When you add Replication Regions, Amazon Web Services Payment Cryptography securely
        /// replicates the key material to the specified Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// The key must be in an active state to add Replication Regions. You can add multiple
        /// regions in a single operation, and the key will be available for use in those regions
        /// once replication is complete.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_RemoveKeyReplicationRegions.html">RemoveKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_EnableDefaultKeyReplicationRegions.html">EnableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetDefaultKeyReplicationRegions.html">GetDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddKeyReplicationRegions service method.</param>
        /// 
        /// <returns>The response from the AddKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/AddKeyReplicationRegions">REST API Reference for AddKeyReplicationRegions Operation</seealso>
        AddKeyReplicationRegionsResponse AddKeyReplicationRegions(AddKeyReplicationRegionsRequest request);



        /// <summary>
        /// Adds replication Amazon Web Services Regions to an existing Amazon Web Services Payment
        /// Cryptography key, enabling the key to be used for cryptographic operations in additional
        /// Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// Multi-region keys allow you to use the same key material across multiple Amazon Web
        /// Services Regions, providing lower latency for applications distributed across regions.
        /// When you add Replication Regions, Amazon Web Services Payment Cryptography securely
        /// replicates the key material to the specified Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// The key must be in an active state to add Replication Regions. You can add multiple
        /// regions in a single operation, and the key will be available for use in those regions
        /// once replication is complete.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_RemoveKeyReplicationRegions.html">RemoveKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_EnableDefaultKeyReplicationRegions.html">EnableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetDefaultKeyReplicationRegions.html">GetDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddKeyReplicationRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/AddKeyReplicationRegions">REST API Reference for AddKeyReplicationRegions Operation</seealso>
        Task<AddKeyReplicationRegionsResponse> AddKeyReplicationRegionsAsync(AddKeyReplicationRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
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
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// The immutable data contains key attributes that define the scope and cryptographic
        /// operations that you can perform using the key, for example key class (example: <c>SYMMETRIC_KEY</c>),
        /// key algorithm (example: <c>TDES_2KEY</c>), key usage (example: <c>TR31_P0_PIN_ENCRYPTION_KEY</c>)
        /// and key modes of use (example: <c>Encrypt</c>). Amazon Web Services Payment Cryptography
        /// binds key attributes to keys using key blocks when you store or export them. Amazon
        /// Web Services Payment Cryptography stores the key contents wrapped and never stores
        /// or transmits them in the clear.
        /// </para>
        ///  
        /// <para>
        /// For information about valid combinations of key attributes, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// The mutable data contained within a key includes usage timestamp and key deletion
        /// timestamp and can be modified after creation.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>CreateKey</c> operation to generate an ECC (Elliptic Curve Cryptography)
        /// key pair used for establishing an ECDH (Elliptic Curve Diffie-Hellman) key agreement
        /// between two parties. In the ECDH key agreement process, both parties generate their
        /// own ECC key pair with key usage K3 and exchange the public keys. Each party then use
        /// their private key, the received public key from the other party, and the key derivation
        /// parameters including key derivation function, hash algorithm, derivation data, and
        /// key algorithm to derive a shared key.
        /// </para>
        ///  
        /// <para>
        /// To maintain the single-use principle of cryptographic keys in payments, ECDH derived
        /// keys should not be used for multiple purposes, such as a <c>TR31_P0_PIN_ENCRYPTION_KEY</c>
        /// and <c>TR31_K1_KEY_BLOCK_PROTECTION_KEY</c>. When creating ECC key pairs in Amazon
        /// Web Services Payment Cryptography you can optionally set the <c>DeriveKeyUsage</c>
        /// parameter, which defines the key usage bound to the symmetric key that will be derived
        /// using the ECC key pair.
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
        /// 
        /// <returns>The response from the CreateKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// The immutable data contains key attributes that define the scope and cryptographic
        /// operations that you can perform using the key, for example key class (example: <c>SYMMETRIC_KEY</c>),
        /// key algorithm (example: <c>TDES_2KEY</c>), key usage (example: <c>TR31_P0_PIN_ENCRYPTION_KEY</c>)
        /// and key modes of use (example: <c>Encrypt</c>). Amazon Web Services Payment Cryptography
        /// binds key attributes to keys using key blocks when you store or export them. Amazon
        /// Web Services Payment Cryptography stores the key contents wrapped and never stores
        /// or transmits them in the clear.
        /// </para>
        ///  
        /// <para>
        /// For information about valid combinations of key attributes, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-validattributes.html">Understanding
        /// key attributes</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// The mutable data contained within a key includes usage timestamp and key deletion
        /// timestamp and can be modified after creation.
        /// </para>
        ///  
        /// <para>
        /// You can use the <c>CreateKey</c> operation to generate an ECC (Elliptic Curve Cryptography)
        /// key pair used for establishing an ECDH (Elliptic Curve Diffie-Hellman) key agreement
        /// between two parties. In the ECDH key agreement process, both parties generate their
        /// own ECC key pair with key usage K3 and exchange the public keys. Each party then use
        /// their private key, the received public key from the other party, and the key derivation
        /// parameters including key derivation function, hash algorithm, derivation data, and
        /// key algorithm to derive a shared key.
        /// </para>
        ///  
        /// <para>
        /// To maintain the single-use principle of cryptographic keys in payments, ECDH derived
        /// keys should not be used for multiple purposes, such as a <c>TR31_P0_PIN_ENCRYPTION_KEY</c>
        /// and <c>TR31_K1_KEY_BLOCK_PROTECTION_KEY</c>. When creating ECC key pairs in Amazon
        /// Web Services Payment Cryptography you can optionally set the <c>DeriveKeyUsage</c>
        /// parameter, which defines the key usage bound to the symmetric key that will be derived
        /// using the ECC key pair.
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);



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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteKey


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
        /// 
        /// <returns>The response from the DeleteKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        DeleteKeyResponse DeleteKey(DeleteKeyRequest request);



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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DeleteKey">REST API Reference for DeleteKey Operation</seealso>
        Task<DeleteKeyResponse> DeleteKeyAsync(DeleteKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableDefaultKeyReplicationRegions


        /// <summary>
        /// Disables multi-region key replication settings for the specified Amazon Web Services
        /// Regions in your account, preventing new keys from being automatically replicated to
        /// those regions.
        /// 
        ///  
        /// <para>
        /// After disabling default replication for specific regions, new keys created in your
        /// account will not be automatically replicated to those regions. You can still manually
        /// add replication to those regions for individual keys using the AddKeyReplicationRegions
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// This operation does not affect existing keys or their current replication configuration.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_EnableDefaultKeyReplicationRegions.html">EnableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetDefaultKeyReplicationRegions.html">GetDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDefaultKeyReplicationRegions service method.</param>
        /// 
        /// <returns>The response from the DisableDefaultKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DisableDefaultKeyReplicationRegions">REST API Reference for DisableDefaultKeyReplicationRegions Operation</seealso>
        DisableDefaultKeyReplicationRegionsResponse DisableDefaultKeyReplicationRegions(DisableDefaultKeyReplicationRegionsRequest request);



        /// <summary>
        /// Disables multi-region key replication settings for the specified Amazon Web Services
        /// Regions in your account, preventing new keys from being automatically replicated to
        /// those regions.
        /// 
        ///  
        /// <para>
        /// After disabling default replication for specific regions, new keys created in your
        /// account will not be automatically replicated to those regions. You can still manually
        /// add replication to those regions for individual keys using the AddKeyReplicationRegions
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// This operation does not affect existing keys or their current replication configuration.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_EnableDefaultKeyReplicationRegions.html">EnableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetDefaultKeyReplicationRegions.html">GetDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableDefaultKeyReplicationRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableDefaultKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/DisableDefaultKeyReplicationRegions">REST API Reference for DisableDefaultKeyReplicationRegions Operation</seealso>
        Task<DisableDefaultKeyReplicationRegionsResponse> DisableDefaultKeyReplicationRegionsAsync(DisableDefaultKeyReplicationRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableDefaultKeyReplicationRegions


        /// <summary>
        /// Enables multi-region key replication settings for your account, causing new keys to
        /// be automatically replicated to the specified Amazon Web Services Regions when created.
        /// 
        ///  
        /// <para>
        /// When default Replication Regions are enabled, any new keys created in your account
        /// will automatically be replicated to these regions unless you explicitly override this
        /// behavior during key creation. This simplifies key management for applications that
        /// operate across multiple regions.
        /// </para>
        ///  
        /// <para>
        /// Existing keys are not affected by this operation - only keys created after enabling
        /// default replication will be automatically replicated.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisableDefaultKeyReplicationRegions.html">DisableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetDefaultKeyReplicationRegions.html">GetDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDefaultKeyReplicationRegions service method.</param>
        /// 
        /// <returns>The response from the EnableDefaultKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/EnableDefaultKeyReplicationRegions">REST API Reference for EnableDefaultKeyReplicationRegions Operation</seealso>
        EnableDefaultKeyReplicationRegionsResponse EnableDefaultKeyReplicationRegions(EnableDefaultKeyReplicationRegionsRequest request);



        /// <summary>
        /// Enables multi-region key replication settings for your account, causing new keys to
        /// be automatically replicated to the specified Amazon Web Services Regions when created.
        /// 
        ///  
        /// <para>
        /// When default Replication Regions are enabled, any new keys created in your account
        /// will automatically be replicated to these regions unless you explicitly override this
        /// behavior during key creation. This simplifies key management for applications that
        /// operate across multiple regions.
        /// </para>
        ///  
        /// <para>
        /// Existing keys are not affected by this operation - only keys created after enabling
        /// default replication will be automatically replicated.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisableDefaultKeyReplicationRegions.html">DisableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetDefaultKeyReplicationRegions.html">GetDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableDefaultKeyReplicationRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableDefaultKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/EnableDefaultKeyReplicationRegions">REST API Reference for EnableDefaultKeyReplicationRegions Operation</seealso>
        Task<EnableDefaultKeyReplicationRegionsResponse> EnableDefaultKeyReplicationRegionsAsync(EnableDefaultKeyReplicationRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ExportKey


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
        /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm, RSA unwrap,
        /// and ECDH (Elliptic Curve Diffie-Hellman) key exchange mechanisms. Asymmetric key exchange
        /// methods are typically used to establish bi-directional trust between the two parties
        /// exhanging keys and are used for initial key exchange such as Key Encryption Key (KEK).
        /// After which you can export working keys using symmetric method to perform various
        /// cryptographic operations within Amazon Web Services Payment Cryptography.
        /// </para>
        ///  
        /// <para>
        /// PCI requires specific minimum key strength of wrapping keys used to protect the keys
        /// being exchanged electronically. These requirements can change when PCI standards are
        /// revised. The rules specify that wrapping keys used for transport must be at least
        /// as strong as the key being protected. For more information on recommended key strength
        /// of wrapping keys and key exchange mechanism, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-importexport.html">Importing
        /// and exporting keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
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
        /// expires after 30 days. 
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
        ///  <b>To export working keys using ECDH</b> 
        /// </para>
        ///  
        /// <para>
        /// You can also use ECDH key agreement to export working keys in a TR-31 keyblock, where
        /// the wrapping key is an ECDH derived key.
        /// </para>
        ///  
        /// <para>
        /// To initiate a TR-31 key export using ECDH, both sides must create an ECC key pair
        /// with key usage K3 and exchange public key certificates. In Amazon Web Services Payment
        /// Cryptography, you can do this by calling <c>CreateKey</c>. If you have not already
        /// done so, you must import the CA chain that issued the receiving public key certificate
        /// by calling <c>ImportKey</c> with input <c>RootCertificatePublicKey</c> for root CA
        /// or <c>TrustedPublicKey</c> for intermediate CA. You can then complete a TR-31 key
        /// export by deriving a shared wrapping key using the service ECC key pair, public certificate
        /// of your ECC key pair outside of Amazon Web Services Payment Cryptography, and the
        /// key derivation parameters including key derivation function, hash algorithm, derivation
        /// data, key algorithm.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>DiffieHellmanTr31KeyBlock</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PrivateKeyIdentifier</c>: The <c>KeyArn</c> of the ECC key pair created within
        /// Amazon Web Services Payment Cryptography to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PublicKeyCertificate</c>: The public key certificate of the receiving ECC key
        /// pair in PEM format (base64 encoded) to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>keyARN</c> of the CA that
        /// signed the public key certificate of the receiving ECC key pair.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// the working key as a TR-31 WrappedKeyBlock, where the wrapping key is the ECDH derived
        /// key.
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
        /// 
        /// <returns>The response from the ExportKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ExportKey">REST API Reference for ExportKey Operation</seealso>
        ExportKeyResponse ExportKey(ExportKeyRequest request);



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
        /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm, RSA unwrap,
        /// and ECDH (Elliptic Curve Diffie-Hellman) key exchange mechanisms. Asymmetric key exchange
        /// methods are typically used to establish bi-directional trust between the two parties
        /// exhanging keys and are used for initial key exchange such as Key Encryption Key (KEK).
        /// After which you can export working keys using symmetric method to perform various
        /// cryptographic operations within Amazon Web Services Payment Cryptography.
        /// </para>
        ///  
        /// <para>
        /// PCI requires specific minimum key strength of wrapping keys used to protect the keys
        /// being exchanged electronically. These requirements can change when PCI standards are
        /// revised. The rules specify that wrapping keys used for transport must be at least
        /// as strong as the key being protected. For more information on recommended key strength
        /// of wrapping keys and key exchange mechanism, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-importexport.html">Importing
        /// and exporting keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
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
        /// expires after 30 days. 
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
        ///  <b>To export working keys using ECDH</b> 
        /// </para>
        ///  
        /// <para>
        /// You can also use ECDH key agreement to export working keys in a TR-31 keyblock, where
        /// the wrapping key is an ECDH derived key.
        /// </para>
        ///  
        /// <para>
        /// To initiate a TR-31 key export using ECDH, both sides must create an ECC key pair
        /// with key usage K3 and exchange public key certificates. In Amazon Web Services Payment
        /// Cryptography, you can do this by calling <c>CreateKey</c>. If you have not already
        /// done so, you must import the CA chain that issued the receiving public key certificate
        /// by calling <c>ImportKey</c> with input <c>RootCertificatePublicKey</c> for root CA
        /// or <c>TrustedPublicKey</c> for intermediate CA. You can then complete a TR-31 key
        /// export by deriving a shared wrapping key using the service ECC key pair, public certificate
        /// of your ECC key pair outside of Amazon Web Services Payment Cryptography, and the
        /// key derivation parameters including key derivation function, hash algorithm, derivation
        /// data, key algorithm.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>DiffieHellmanTr31KeyBlock</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PrivateKeyIdentifier</c>: The <c>KeyArn</c> of the ECC key pair created within
        /// Amazon Web Services Payment Cryptography to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PublicKeyCertificate</c>: The public key certificate of the receiving ECC key
        /// pair in PEM format (base64 encoded) to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>keyARN</c> of the CA that
        /// signed the public key certificate of the receiving ECC key pair.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, Amazon Web Services Payment Cryptography returns
        /// the working key as a TR-31 WrappedKeyBlock, where the wrapping key is the ECDH derived
        /// key.
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the GetAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetAlias">REST API Reference for GetAlias Operation</seealso>
        Task<GetAliasResponse> GetAliasAsync(GetAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCertificateSigningRequest


        /// <summary>
        /// Used to retrieve the public key for a keypair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateSigningRequest service method.</param>
        /// 
        /// <returns>The response from the GetCertificateSigningRequest service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetCertificateSigningRequest">REST API Reference for GetCertificateSigningRequest Operation</seealso>
        GetCertificateSigningRequestResponse GetCertificateSigningRequest(GetCertificateSigningRequestRequest request);



        /// <summary>
        /// Used to retrieve the public key for a keypair.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificateSigningRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCertificateSigningRequest service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetCertificateSigningRequest">REST API Reference for GetCertificateSigningRequest Operation</seealso>
        Task<GetCertificateSigningRequestResponse> GetCertificateSigningRequestAsync(GetCertificateSigningRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDefaultKeyReplicationRegions


        /// <summary>
        /// Retrieves the list of regions where default key replication is currently enabled for
        /// your account.
        /// 
        ///  
        /// <para>
        /// This operation returns the current configuration of default Replication Regions. New
        /// keys created in your account will be automatically replicated to these regions unless
        /// explicitly overridden during key creation.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_EnableDefaultKeyReplicationRegions.html">EnableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisableDefaultKeyReplicationRegions.html">DisableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultKeyReplicationRegions service method.</param>
        /// 
        /// <returns>The response from the GetDefaultKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetDefaultKeyReplicationRegions">REST API Reference for GetDefaultKeyReplicationRegions Operation</seealso>
        GetDefaultKeyReplicationRegionsResponse GetDefaultKeyReplicationRegions(GetDefaultKeyReplicationRegionsRequest request);



        /// <summary>
        /// Retrieves the list of regions where default key replication is currently enabled for
        /// your account.
        /// 
        ///  
        /// <para>
        /// This operation returns the current configuration of default Replication Regions. New
        /// keys created in your account will be automatically replicated to these regions unless
        /// explicitly overridden during key creation.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_EnableDefaultKeyReplicationRegions.html">EnableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisableDefaultKeyReplicationRegions.html">DisableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultKeyReplicationRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDefaultKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetDefaultKeyReplicationRegions">REST API Reference for GetDefaultKeyReplicationRegions Operation</seealso>
        Task<GetDefaultKeyReplicationRegionsResponse> GetDefaultKeyReplicationRegionsAsync(GetDefaultKeyReplicationRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetKey


        /// <summary>
        /// Gets the key metadata for an Amazon Web Services Payment Cryptography key, including
        /// the immutable and mutable attributes specified when the key was created. Returns key
        /// metadata including attributes, state, and timestamps, but does not return the actual
        /// cryptographic key material.
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
        /// 
        /// <returns>The response from the GetKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetKey">REST API Reference for GetKey Operation</seealso>
        GetKeyResponse GetKey(GetKeyRequest request);



        /// <summary>
        /// Gets the key metadata for an Amazon Web Services Payment Cryptography key, including
        /// the immutable and mutable attributes specified when the key was created. Returns key
        /// metadata including attributes, state, and timestamps, but does not return the actual
        /// cryptographic key material.
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>.
        /// The export token expires in 30 days. You can use the same export token to export multiple
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
        /// 
        /// <returns>The response from the GetParametersForExport service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ExportKey.html">ExportKey</a>.
        /// The export token expires in 30 days. You can use the same export token to export multiple
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetParametersForExport">REST API Reference for GetParametersForExport Operation</seealso>
        Task<GetParametersForExportResponse> GetParametersForExportAsync(GetParametersForExportRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetParametersForImport


        /// <summary>
        /// Gets the import token and the wrapping key certificate in PEM format (base64 encoded)
        /// to initiate a TR-34 WrappedKeyBlock or a RSA WrappedKeyCryptogram import into Amazon
        /// Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The wrapping key certificate wraps the key under import. The import token and wrapping
        /// key certificate must be in place and operational before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// The import token expires in 30 days. You can use the same import token to import multiple
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
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        GetParametersForImportResponse GetParametersForImport(GetParametersForImportRequest request);



        /// <summary>
        /// Gets the import token and the wrapping key certificate in PEM format (base64 encoded)
        /// to initiate a TR-34 WrappedKeyBlock or a RSA WrappedKeyCryptogram import into Amazon
        /// Web Services Payment Cryptography.
        /// 
        ///  
        /// <para>
        /// The wrapping key certificate wraps the key under import. The import token and wrapping
        /// key certificate must be in place and operational before calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// The import token expires in 30 days. You can use the same import token to import multiple
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the GetPublicKeyCertificate service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/GetPublicKeyCertificate">REST API Reference for GetPublicKeyCertificate Operation</seealso>
        Task<GetPublicKeyCertificateResponse> GetPublicKeyCertificateAsync(GetPublicKeyCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ImportKey


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
        /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm, RSA unwrap,
        /// and ECDH (Elliptic Curve Diffie-Hellman) key exchange mechanisms. Asymmetric key exchange
        /// methods are typically used to establish bi-directional trust between the two parties
        /// exhanging keys and are used for initial key exchange such as Key Encryption Key (KEK)
        /// or Zone Master Key (ZMK). After which you can import working keys using symmetric
        /// method to perform various cryptographic operations within Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        ///  
        /// <para>
        /// PCI requires specific minimum key strength of wrapping keys used to protect the keys
        /// being exchanged electronically. These requirements can change when PCI standards are
        /// revised. The rules specify that wrapping keys used for transport must be at least
        /// as strong as the key being protected. For more information on recommended key strength
        /// of wrapping keys and key exchange mechanism, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-importexport.html">Importing
        /// and exporting keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
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
        /// expires after 30 days.
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
        /// certificate expires after 30 days. 
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
        ///  <b>To import working keys using ECDH</b> 
        /// </para>
        ///  
        /// <para>
        /// You can also use ECDH key agreement to import working keys as a TR-31 keyblock, where
        /// the wrapping key is an ECDH derived key.
        /// </para>
        ///  
        /// <para>
        /// To initiate a TR-31 key import using ECDH, both sides must create an ECC key pair
        /// with key usage K3 and exchange public key certificates. In Amazon Web Services Payment
        /// Cryptography, you can do this by calling <c>CreateKey</c> and then <c>GetPublicKeyCertificate</c>
        /// to retrieve its public key certificate. Next, you can then generate a TR-31 WrappedKeyBlock
        /// using your own ECC key pair, the public certificate of the service's ECC key pair,
        /// and the key derivation parameters including key derivation function, hash algorithm,
        /// derivation data, and key algorithm. If you have not already done so, you must import
        /// the CA chain that issued the receiving public key certificate by calling <c>ImportKey</c>
        /// with input <c>RootCertificatePublicKey</c> for root CA or <c>TrustedPublicKey</c>
        /// for intermediate CA. To complete the TR-31 key import, you can use the following parameters.
        /// It is important that the ECDH key derivation parameters you use should match those
        /// used during import to derive the same shared wrapping key within Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>DiffieHellmanTr31KeyBlock</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PrivateKeyIdentifier</c>: The <c>KeyArn</c> of the ECC key pair created within
        /// Amazon Web Services Payment Cryptography to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PublicKeyCertificate</c>: The public key certificate of the receiving ECC key
        /// pair in PEM format (base64 encoded) to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>keyARN</c> of the CA that
        /// signed the public key certificate of the receiving ECC key pair.
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
        /// 
        /// <returns>The response from the ImportKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ImportKey">REST API Reference for ImportKey Operation</seealso>
        ImportKeyResponse ImportKey(ImportKeyRequest request);



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
        /// Amazon Web Services Payment Cryptography supports ANSI X9 TR-34 norm, RSA unwrap,
        /// and ECDH (Elliptic Curve Diffie-Hellman) key exchange mechanisms. Asymmetric key exchange
        /// methods are typically used to establish bi-directional trust between the two parties
        /// exhanging keys and are used for initial key exchange such as Key Encryption Key (KEK)
        /// or Zone Master Key (ZMK). After which you can import working keys using symmetric
        /// method to perform various cryptographic operations within Amazon Web Services Payment
        /// Cryptography.
        /// </para>
        ///  
        /// <para>
        /// PCI requires specific minimum key strength of wrapping keys used to protect the keys
        /// being exchanged electronically. These requirements can change when PCI standards are
        /// revised. The rules specify that wrapping keys used for transport must be at least
        /// as strong as the key being protected. For more information on recommended key strength
        /// of wrapping keys and key exchange mechanism, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-importexport.html">Importing
        /// and exporting keys</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
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
        /// expires after 30 days.
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
        /// certificate expires after 30 days. 
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
        ///  <b>To import working keys using ECDH</b> 
        /// </para>
        ///  
        /// <para>
        /// You can also use ECDH key agreement to import working keys as a TR-31 keyblock, where
        /// the wrapping key is an ECDH derived key.
        /// </para>
        ///  
        /// <para>
        /// To initiate a TR-31 key import using ECDH, both sides must create an ECC key pair
        /// with key usage K3 and exchange public key certificates. In Amazon Web Services Payment
        /// Cryptography, you can do this by calling <c>CreateKey</c> and then <c>GetPublicKeyCertificate</c>
        /// to retrieve its public key certificate. Next, you can then generate a TR-31 WrappedKeyBlock
        /// using your own ECC key pair, the public certificate of the service's ECC key pair,
        /// and the key derivation parameters including key derivation function, hash algorithm,
        /// derivation data, and key algorithm. If you have not already done so, you must import
        /// the CA chain that issued the receiving public key certificate by calling <c>ImportKey</c>
        /// with input <c>RootCertificatePublicKey</c> for root CA or <c>TrustedPublicKey</c>
        /// for intermediate CA. To complete the TR-31 key import, you can use the following parameters.
        /// It is important that the ECDH key derivation parameters you use should match those
        /// used during import to derive the same shared wrapping key within Amazon Web Services
        /// Payment Cryptography.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KeyMaterial</c>: Use <c>DiffieHellmanTr31KeyBlock</c> parameters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PrivateKeyIdentifier</c>: The <c>KeyArn</c> of the ECC key pair created within
        /// Amazon Web Services Payment Cryptography to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PublicKeyCertificate</c>: The public key certificate of the receiving ECC key
        /// pair in PEM format (base64 encoded) to derive a shared KEK.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CertificateAuthorityPublicKeyIdentifier</c>: The <c>keyARN</c> of the CA that
        /// signed the public key certificate of the receiving ECC key pair.
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ImportKey">REST API Reference for ImportKey Operation</seealso>
        Task<ImportKeyResponse> ImportKeyAsync(ImportKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Lists the aliases for all keys in the caller's Amazon Web Services account and Amazon
        /// Web Services Region. You can filter the aliases by <c>keyARN</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-managealias.html">Using
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
        /// 
        /// <returns>The response from the ListAliases service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ListAliases">REST API Reference for ListAliases Operation</seealso>
        ListAliasesResponse ListAliases(ListAliasesRequest request);



        /// <summary>
        /// Lists the aliases for all keys in the caller's Amazon Web Services account and Amazon
        /// Web Services Region. You can filter the aliases by <c>keyARN</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/keys-managealias.html">Using
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the ListKeys service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveKeyReplicationRegions


        /// <summary>
        /// Removes Replication Regions from an existing Amazon Web Services Payment Cryptography
        /// key, disabling the key's availability for cryptographic operations in the specified
        /// Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// When you remove Replication Regions, the key material is securely deleted from those
        /// regions and can no longer be used for cryptographic operations there. This operation
        /// is irreversible for the specified Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// Ensure that no active cryptographic operations or applications depend on the key in
        /// the regions you're removing before performing this operation.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_AddKeyReplicationRegions.html">AddKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisableDefaultKeyReplicationRegions.html">DisableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveKeyReplicationRegions service method.</param>
        /// 
        /// <returns>The response from the RemoveKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/RemoveKeyReplicationRegions">REST API Reference for RemoveKeyReplicationRegions Operation</seealso>
        RemoveKeyReplicationRegionsResponse RemoveKeyReplicationRegions(RemoveKeyReplicationRegionsRequest request);



        /// <summary>
        /// Removes Replication Regions from an existing Amazon Web Services Payment Cryptography
        /// key, disabling the key's availability for cryptographic operations in the specified
        /// Amazon Web Services Regions.
        /// 
        ///  
        /// <para>
        /// When you remove Replication Regions, the key material is securely deleted from those
        /// regions and can no longer be used for cryptographic operations there. This operation
        /// is irreversible for the specified Amazon Web Services Regions.
        /// </para>
        ///  
        /// <para>
        /// Ensure that no active cryptographic operations or applications depend on the key in
        /// the regions you're removing before performing this operation.
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_AddKeyReplicationRegions.html">AddKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_DisableDefaultKeyReplicationRegions.html">DisableDefaultKeyReplicationRegions</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveKeyReplicationRegions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveKeyReplicationRegions service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/RemoveKeyReplicationRegions">REST API Reference for RemoveKeyReplicationRegions Operation</seealso>
        Task<RemoveKeyReplicationRegionsResponse> RemoveKeyReplicationRegionsAsync(RemoveKeyReplicationRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreKey


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
        /// 
        /// <returns>The response from the RestoreKey service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/RestoreKey">REST API Reference for RestoreKey Operation</seealso>
        RestoreKeyResponse RestoreKey(RestoreKeyRequest request);



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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        ///  <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_StopKeyUsage.html">StopKeyUsage</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartKeyUsage service method.</param>
        /// 
        /// <returns>The response from the StartKeyUsage service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the StopKeyUsage service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/StopKeyUsage">REST API Reference for StopKeyUsage Operation</seealso>
        StopKeyUsageResponse StopKeyUsage(StopKeyUsageRequest request);



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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the TagResource service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceQuotaExceededException">
        /// This request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// You have reached the maximum number of keys, aliases, or other resources allowed in
        /// your account. Review your current usage and consider deleting unused resources or
        /// requesting a quota increase.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by PaymentCryptography.</returns>
        /// <exception cref="Amazon.PaymentCryptography.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// This exception is thrown when the caller lacks the necessary IAM permissions to perform
        /// the requested operation. Verify that your IAM policy includes the required permissions
        /// for the specific Amazon Web Services Payment Cryptography action you're attempting.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ConflictException">
        /// This request can cause an inconsistent state for the resource.
        /// 
        ///  
        /// <para>
        /// The requested operation conflicts with the current state of the resource. For example,
        /// attempting to delete a key that is currently being used, or trying to create a resource
        /// that already exists.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// 
        ///  
        /// <para>
        /// This indicates a server-side error within the Amazon Web Services Payment Cryptography
        /// service. If this error persists, contact support for assistance.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ResourceNotFoundException">
        /// The request was denied due to resource not found.
        /// 
        ///  
        /// <para>
        /// The specified key, alias, or other resource does not exist in your account or region.
        /// Verify that the resource identifier is correct and that the resource exists in the
        /// expected region.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// 
        ///  
        /// <para>
        /// The Amazon Web Services Payment Cryptography service is temporarily unavailable. This
        /// is typically a temporary condition - retry your request after a brief delay.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        /// You have exceeded the rate limits for Amazon Web Services Payment Cryptography API
        /// calls. Implement exponential backoff and retry logic in your application to handle
        /// throttling gracefully.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.PaymentCryptography.Model.ValidationException">
        /// The request was denied due to an invalid request error.
        /// 
        ///  
        /// <para>
        /// One or more parameters in your request are invalid. Check the parameter values, formats,
        /// and constraints specified in the API documentation.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-2021-09-14/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}