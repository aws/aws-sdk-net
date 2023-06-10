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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PaymentCryptographyData.Model;

namespace Amazon.PaymentCryptographyData
{
    /// <summary>
    /// Interface for accessing PaymentCryptographyData
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
    public partial interface IAmazonPaymentCryptographyData : IAmazonService, IDisposable
    {




        
        #region  DecryptData


        /// <summary>
        /// Decrypts ciphertext data to plaintext using symmetric, asymmetric, or DUKPT data encryption
        /// key. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/decrypt-data.html">Decrypt
        /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use an encryption key generated within Amazon Web Services Payment Cryptography,
        /// or you can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// For this operation, the key must have <code>KeyModesOfUse</code> set to <code>Decrypt</code>.
        /// In asymmetric decryption, Amazon Web Services Payment Cryptography decrypts the ciphertext
        /// using the private component of the asymmetric encryption key pair. For data encryption
        /// outside of Amazon Web Services Payment Cryptography, you can export the public component
        /// of the asymmetric key pair by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_GetPublicKeyCertificate.html">GetPublicCertificate</a>.
        /// </para>
        ///  
        /// <para>
        /// For symmetric and DUKPT decryption, Amazon Web Services Payment Cryptography supports
        /// <code>TDES</code> and <code>AES</code> algorithms. For asymmetric decryption, Amazon
        /// Web Services Payment Cryptography supports <code>RSA</code>. When you use DUKPT, for
        /// <code>TDES</code> algorithm, the ciphertext data length must be a multiple of 16 bytes.
        /// For <code>AES</code> algorithm, the ciphertext data length must be a multiple of 32
        /// bytes.
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
        DecryptDataResponse DecryptData(DecryptDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DecryptData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DecryptData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDecryptData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/DecryptData">REST API Reference for DecryptData Operation</seealso>
        IAsyncResult BeginDecryptData(DecryptDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DecryptData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecryptData.</param>
        /// 
        /// <returns>Returns a  DecryptDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/DecryptData">REST API Reference for DecryptData Operation</seealso>
        DecryptDataResponse EndDecryptData(IAsyncResult asyncResult);

        #endregion
        
        #region  EncryptData


        /// <summary>
        /// Encrypts plaintext data to ciphertext using symmetric, asymmetric, or DUKPT data encryption
        /// key. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/encrypt-data.html">Encrypt
        /// data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can generate an encryption key within Amazon Web Services Payment Cryptography
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
        /// You can import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// For this operation, the key must have <code>KeyModesOfUse</code> set to <code>Encrypt</code>.
        /// In asymmetric encryption, plaintext is encrypted using public component. You can import
        /// the public component of an asymmetric key pair created outside Amazon Web Services
        /// Payment Cryptography by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>).
        /// 
        /// </para>
        ///  
        /// <para>
        /// for symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
        /// <code>TDES</code> and <code>AES</code> algorithms. For asymmetric encryption, Amazon
        /// Web Services Payment Cryptography supports <code>RSA</code>. To encrypt using DUKPT,
        /// you must already have a DUKPT key in your account with <code>KeyModesOfUse</code>
        /// set to <code>DeriveKey</code>, or you can generate a new DUKPT key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
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
        EncryptDataResponse EncryptData(EncryptDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EncryptData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EncryptData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEncryptData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/EncryptData">REST API Reference for EncryptData Operation</seealso>
        IAsyncResult BeginEncryptData(EncryptDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EncryptData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEncryptData.</param>
        /// 
        /// <returns>Returns a  EncryptDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/EncryptData">REST API Reference for EncryptData Operation</seealso>
        EncryptDataResponse EndEncryptData(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateCardValidationData


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
        /// to establish a CVK within Amazon Web Services Payment Cryptography. The <code>KeyModesOfUse</code>
        /// should be set to <code>Generate</code> and <code>Verify</code> for a CVK encryption
        /// key. 
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
        GenerateCardValidationDataResponse GenerateCardValidationData(GenerateCardValidationDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCardValidationData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateCardValidationData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateCardValidationData">REST API Reference for GenerateCardValidationData Operation</seealso>
        IAsyncResult BeginGenerateCardValidationData(GenerateCardValidationDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateCardValidationData.</param>
        /// 
        /// <returns>Returns a  GenerateCardValidationDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateCardValidationData">REST API Reference for GenerateCardValidationData Operation</seealso>
        GenerateCardValidationDataResponse EndGenerateCardValidationData(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateMac


        /// <summary>
        /// Generates a Message Authentication Code (MAC) cryptogram within Amazon Web Services
        /// Payment Cryptography. 
        /// 
        ///  
        /// <para>
        /// You can use this operation when keys won't be shared but mutual data is present on
        /// both ends for validation. In this case, known data values are used to generate a MAC
        /// on both ends for comparision without sending or receiving data in ciphertext or plaintext.
        /// You can use this operation to generate a DUPKT, HMAC or EMV MAC by setting generation
        /// attributes and algorithm to the associated values. The MAC generation encryption key
        /// must have valid values for <code>KeyUsage</code> such as <code>TR31_M7_HMAC_KEY</code>
        /// for HMAC generation, and they key must have <code>KeyModesOfUse</code> set to <code>Generate</code>
        /// and <code>Verify</code>.
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
        GenerateMacResponse GenerateMac(GenerateMacRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateMac operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateMac operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateMac
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateMac">REST API Reference for GenerateMac Operation</seealso>
        IAsyncResult BeginGenerateMac(GenerateMacRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateMac operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateMac.</param>
        /// 
        /// <returns>Returns a  GenerateMacResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GenerateMac">REST API Reference for GenerateMac Operation</seealso>
        GenerateMacResponse EndGenerateMac(IAsyncResult asyncResult);

        #endregion
        
        #region  GeneratePinData


        /// <summary>
        /// Generates pin-related data such as PIN, PIN Verification Value (PVV), PIN Block, and
        /// PIN Offset during new card issuance or reissuance. For more information, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/generate-pin-data.html">Generate
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// PIN data is never transmitted in clear to or from Amazon Web Services Payment Cryptography.
        /// This operation generates PIN, PVV, or PIN Offset and then encrypts it using Pin Encryption
        /// Key (PEK) to create an <code>EncryptedPinBlock</code> for transmission from Amazon
        /// Web Services Payment Cryptography. This operation uses a separate Pin Verification
        /// Key (PVK) for VISA PVV generation. 
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
        GeneratePinDataResponse GeneratePinData(GeneratePinDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GeneratePinData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GeneratePinData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGeneratePinData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GeneratePinData">REST API Reference for GeneratePinData Operation</seealso>
        IAsyncResult BeginGeneratePinData(GeneratePinDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GeneratePinData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGeneratePinData.</param>
        /// 
        /// <returns>Returns a  GeneratePinDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/GeneratePinData">REST API Reference for GeneratePinData Operation</seealso>
        GeneratePinDataResponse EndGeneratePinData(IAsyncResult asyncResult);

        #endregion
        
        #region  ReEncryptData


        /// <summary>
        /// Re-encrypt ciphertext using DUKPT, Symmetric and Asymmetric Data Encryption Keys.
        /// 
        /// 
        ///  
        /// <para>
        /// You can either generate an encryption key within Amazon Web Services Payment Cryptography
        /// by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>
        /// or import your own encryption key by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>.
        /// The <code>KeyArn</code> for use with this operation must be in a compatible key state
        /// with <code>KeyModesOfUse</code> set to <code>Encrypt</code>. In asymmetric encryption,
        /// ciphertext is encrypted using public component (imported by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_ImportKey.html">ImportKey</a>)
        /// of the asymmetric key pair created outside of Amazon Web Services Payment Cryptography.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For symmetric and DUKPT encryption, Amazon Web Services Payment Cryptography supports
        /// <code>TDES</code> and <code>AES</code> algorithms. For asymmetric encryption, Amazon
        /// Web Services Payment Cryptography supports <code>RSA</code>. To encrypt using DUKPT,
        /// a DUKPT key must already exist within your account with <code>KeyModesOfUse</code>
        /// set to <code>DeriveKey</code> or a new DUKPT can be generated by calling <a href="https://docs.aws.amazon.com/payment-cryptography/latest/APIReference/API_CreateKey.html">CreateKey</a>.
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
        ReEncryptDataResponse ReEncryptData(ReEncryptDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReEncryptData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncryptData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReEncryptData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/ReEncryptData">REST API Reference for ReEncryptData Operation</seealso>
        IAsyncResult BeginReEncryptData(ReEncryptDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReEncryptData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReEncryptData.</param>
        /// 
        /// <returns>Returns a  ReEncryptDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/ReEncryptData">REST API Reference for ReEncryptData Operation</seealso>
        ReEncryptDataResponse EndReEncryptData(IAsyncResult asyncResult);

        #endregion
        
        #region  TranslatePinData


        /// <summary>
        /// Translates encrypted PIN block from and to ISO 9564 formats 0,1,3,4. For more information,
        /// see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/translate-pin-data.html">Translate
        /// PIN data</a> in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// 
        ///  
        /// <para>
        /// PIN block translation involves changing the encrytion of PIN block from one encryption
        /// key to another encryption key and changing PIN block format from one to another without
        /// PIN block data leaving Amazon Web Services Payment Cryptography. The encryption key
        /// transformation can be from PEK (Pin Encryption Key) to BDK (Base Derivation Key) for
        /// DUKPT or from BDK for DUKPT to PEK. Amazon Web Services Payment Cryptography supports
        /// <code>TDES</code> and <code>AES</code> key derivation type for DUKPT tranlations.
        /// You can use this operation for P2PE (Point to Point Encryption) use cases where the
        /// encryption keys should change but the processing system either does not need to, or
        /// is not permitted to, decrypt the data.
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
        /// At this time, Amazon Web Services Payment Cryptography does not support translations
        /// to PIN format 4.
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
        TranslatePinDataResponse TranslatePinData(TranslatePinDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TranslatePinData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TranslatePinData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTranslatePinData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/TranslatePinData">REST API Reference for TranslatePinData Operation</seealso>
        IAsyncResult BeginTranslatePinData(TranslatePinDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TranslatePinData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTranslatePinData.</param>
        /// 
        /// <returns>Returns a  TranslatePinDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/TranslatePinData">REST API Reference for TranslatePinData Operation</seealso>
        TranslatePinDataResponse EndTranslatePinData(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifyAuthRequestCryptogram


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
        /// Response Cryptogram) response using Method 1 or Method 2. The <code>ARPC_METHOD_1</code>
        /// uses <code>AuthResponseCode</code> to generate ARPC and <code>ARPC_METHOD_2</code>
        /// uses <code>CardStatusUpdate</code> to generate ARPC. 
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
        VerifyAuthRequestCryptogramResponse VerifyAuthRequestCryptogram(VerifyAuthRequestCryptogramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyAuthRequestCryptogram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyAuthRequestCryptogram operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyAuthRequestCryptogram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyAuthRequestCryptogram">REST API Reference for VerifyAuthRequestCryptogram Operation</seealso>
        IAsyncResult BeginVerifyAuthRequestCryptogram(VerifyAuthRequestCryptogramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyAuthRequestCryptogram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyAuthRequestCryptogram.</param>
        /// 
        /// <returns>Returns a  VerifyAuthRequestCryptogramResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyAuthRequestCryptogram">REST API Reference for VerifyAuthRequestCryptogram Operation</seealso>
        VerifyAuthRequestCryptogramResponse EndVerifyAuthRequestCryptogram(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifyCardValidationData


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
        VerifyCardValidationDataResponse VerifyCardValidationData(VerifyCardValidationDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyCardValidationData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyCardValidationData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyCardValidationData">REST API Reference for VerifyCardValidationData Operation</seealso>
        IAsyncResult BeginVerifyCardValidationData(VerifyCardValidationDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyCardValidationData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyCardValidationData.</param>
        /// 
        /// <returns>Returns a  VerifyCardValidationDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyCardValidationData">REST API Reference for VerifyCardValidationData Operation</seealso>
        VerifyCardValidationDataResponse EndVerifyCardValidationData(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifyMac


        /// <summary>
        /// Verifies a Message Authentication Code (MAC). 
        /// 
        ///  
        /// <para>
        /// You can use this operation when keys won't be shared but mutual data is present on
        /// both ends for validation. In this case, known data values are used to generate a MAC
        /// on both ends for verification without sending or receiving data in ciphertext or plaintext.
        /// You can use this operation to verify a DUPKT, HMAC or EMV MAC by setting generation
        /// attributes and algorithm to the associated values. Use the same encryption key for
        /// MAC verification as you use for <a>GenerateMac</a>. 
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
        VerifyMacResponse VerifyMac(VerifyMacRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyMac operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyMac operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyMac
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyMac">REST API Reference for VerifyMac Operation</seealso>
        IAsyncResult BeginVerifyMac(VerifyMacRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyMac operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyMac.</param>
        /// 
        /// <returns>Returns a  VerifyMacResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyMac">REST API Reference for VerifyMac Operation</seealso>
        VerifyMacResponse EndVerifyMac(IAsyncResult asyncResult);

        #endregion
        
        #region  VerifyPinData


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
        /// encrypts it using PIN Encryption Key (PEK) to create an <code>EncryptedPinBlock</code>
        /// for transmission from Amazon Web Services Payment Cryptography. 
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
        VerifyPinDataResponse VerifyPinData(VerifyPinDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the VerifyPinData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the VerifyPinData operation on AmazonPaymentCryptographyDataClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndVerifyPinData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyPinData">REST API Reference for VerifyPinData Operation</seealso>
        IAsyncResult BeginVerifyPinData(VerifyPinDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  VerifyPinData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginVerifyPinData.</param>
        /// 
        /// <returns>Returns a  VerifyPinDataResult from PaymentCryptographyData.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/payment-cryptography-data-2022-02-03/VerifyPinData">REST API Reference for VerifyPinData Operation</seealso>
        VerifyPinDataResponse EndVerifyPinData(IAsyncResult asyncResult);

        #endregion
        
    }
}