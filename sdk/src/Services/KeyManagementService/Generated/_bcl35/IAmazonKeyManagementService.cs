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
using System.Collections.Generic;

using Amazon.KeyManagementService.Model;

namespace Amazon.KeyManagementService
{
    /// <summary>
    /// Interface for accessing KeyManagementService
    ///
    /// AWS Key Management Service 
    /// <para>
    ///  AWS Key Management Service (KMS) is an encryption and key management web service.
    /// This guide describes the KMS actions that you can call programmatically. For general
    /// information about KMS, see the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/overview.html">
    /// AWS Key Management Service Developer Guide </a> 
    /// </para>
    ///  <note> AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to KMS and AWS. For example, the SDKs
    /// take care of tasks such as signing requests (see below), managing errors, and retrying
    /// requests automatically. For more information about the AWS SDKs, including how to
    /// download and install them, see <a href="http://aws.amazon.com/tools/">Tools for Amazon
    /// Web Services</a>. </note> 
    /// <para>
    ///  We recommend that you use the AWS SDKs to make programmatic API calls to KMS. 
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
    /// <b>Signing Requests</b>
    /// </para>
    ///  
    /// <para>
    ///  Requests must be signed by using an access key ID and a secret access key. We strongly
    /// recommend that you do not use your AWS account access key ID and secret key for everyday
    /// work with KMS. Instead, use the access key ID and secret access key for an IAM user,
    /// or you can use the AWS Security Token Service to generate temporary security credentials
    /// that you can use to sign requests. 
    /// </para>
    ///  
    /// <para>
    ///  All KMS operations require <a href="http://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>. 
    /// </para>
    ///  
    /// <para>
    /// <b>Recording API Requests</b>
    /// </para>
    ///  
    /// <para>
    ///  KMS supports AWS CloudTrail, a service that records AWS API calls and related events
    /// for your AWS account and delivers them to an Amazon S3 bucket that you specify. By
    /// using the information collected by CloudTrail, you can determine what requests were
    /// made to KMS, who made the request, when it was made, and so on. To learn more about
    /// CloudTrail, including how to turn it on and find your log files, see the <a href="http://docs.aws.amazon.com/awscloudtrail/latest/userguide/whatiscloudtrail.html">AWS
    /// CloudTrail User Guide</a> 
    /// </para>
    ///  
    /// <para>
    /// <b>Additional Resources</b>
    /// </para>
    ///  
    /// <para>
    /// For more information about credentials and request signing, see the following:
    /// </para>
    ///  <ul> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">AWS
    /// Security Credentials</a>. This topic provides general information about the types
    /// of credentials used for accessing AWS. </li> <li> <a href="http://docs.aws.amazon.com/STS/latest/UsingSTS/">AWS
    /// Security Token Service</a>. This guide describes how to create and use temporary security
    /// credentials. </li> <li> <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a>. This set of topics walks you through the process of signing
    /// a request using an access key ID and a secret access key. </li> </ul> 
    /// <para>
    /// <b>Commonly Used APIs</b>
    /// </para>
    ///  
    /// <para>
    ///  Of the APIs discussed in this guide, the following will prove the most useful for
    /// most applications. You will likely perform actions other than these, such as creating
    /// keys and assigning policies, by using the console. <ul> <li><a>Encrypt</a></li> <li><a>Decrypt</a></li>
    /// <li><a>GenerateDataKey</a></li> <li><a>GenerateDataKeyWithoutPlaintext</a></li> </ul>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonKeyManagementService : IDisposable
    {

        
        #region  CreateAlias


        /// <summary>
        /// Creates a display name for a customer master key. An alias can be used to identify
        /// a key and should be unique. The console enforces a one-to-one mapping between the
        /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
        /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
        /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
        /// (alias/aws...) is reserved by Amazon Web Services (AWS). 
        /// 
        ///  
        /// <para>
        /// To associate an alias with a different key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        /// Note that you cannot create or update an alias that represents a key in another account.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the display name. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved. </param>
        /// <param name="targetKeyId">An identifier of the key for which you are creating the alias. This value cannot be another alias but can be a globally unique identifier or a fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        CreateAliasResponse CreateAlias(string aliasName, string targetKeyId);

        /// <summary>
        /// Creates a display name for a customer master key. An alias can be used to identify
        /// a key and should be unique. The console enforces a one-to-one mapping between the
        /// alias and a key. An alias name can contain only alphanumeric characters, forward slashes
        /// (/), underscores (_), and dashes (-). An alias must start with the word "alias" followed
        /// by a forward slash (alias/). An alias that begins with "aws" after the forward slash
        /// (alias/aws...) is reserved by Amazon Web Services (AWS). 
        /// 
        ///  
        /// <para>
        /// To associate an alias with a different key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        /// Note that you cannot create or update an alias that represents a key in another account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidAliasNameException">
        /// The request was rejected because the specified alias name is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        CreateAliasResponse CreateAlias(CreateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlias
        ///         operation.</returns>
        IAsyncResult BeginCreateAlias(CreateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlias.</param>
        /// 
        /// <returns>Returns a  CreateAliasResult from KeyManagementService.</returns>
        CreateAliasResponse EndCreateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateGrant


        /// <summary>
        /// Adds a grant to a key to specify who can access the key and under what conditions.
        /// Grants are alternate permission mechanisms to key policies. For more information about
        /// grants, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants</a>
        /// in the developer guide. If a grant is absent, access to the key is evaluated based
        /// on IAM policies attached to the user. <ol> <li><a>ListGrants</a></li> <li><a>RetireGrant</a></li>
        /// <li><a>RevokeGrant</a></li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        CreateGrantResponse CreateGrant(CreateGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGrant
        ///         operation.</returns>
        IAsyncResult BeginCreateGrant(CreateGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGrant.</param>
        /// 
        /// <returns>Returns a  CreateGrantResult from KeyManagementService.</returns>
        CreateGrantResponse EndCreateGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKey


        /// <summary>
        /// Creates a customer master key. Customer master keys can be used to encrypt small amounts
        /// of data (less than 4K) directly, but they are most commonly used to encrypt or envelope
        /// data keys that are then used to encrypt customer data. For more information about
        /// data keys, see <a>GenerateDataKey</a> and <a>GenerateDataKeyWithoutPlaintext</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported.
        /// </exception>
        CreateKeyResponse CreateKey(CreateKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKey operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKey
        ///         operation.</returns>
        IAsyncResult BeginCreateKey(CreateKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKey.</param>
        /// 
        /// <returns>Returns a  CreateKeyResult from KeyManagementService.</returns>
        CreateKeyResponse EndCreateKey(IAsyncResult asyncResult);

        #endregion
        
        #region  Decrypt


        /// <summary>
        /// Decrypts ciphertext. Ciphertext is plaintext that has been previously encrypted by
        /// using any of the following functions: <ul> <li><a>GenerateDataKey</a></li> <li><a>GenerateDataKeyWithoutPlaintext</a></li>
        /// <li><a>Encrypt</a></li> </ul> 
        /// 
        ///  
        /// <para>
        /// Note that if a caller has been granted access permissions to all keys (through, for
        /// example, IAM user policies that grant <code>Decrypt</code> permission on all resources),
        /// then ciphertext encrypted by using keys in other accounts where the key grants access
        /// to the caller can be decrypted. To remedy this, we recommend that you do not grant
        /// <code>Decrypt</code> access in an IAM user policy. Instead grant <code>Decrypt</code>
        /// access only in key policies. If you must grant <code>Decrypt</code> access in an IAM
        /// user policy, you should scope the resource to specific keys or to specific trusted
        /// accounts. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext has been corrupted or is
        /// otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was disabled, not found, or otherwise not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DecryptResponse Decrypt(DecryptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Decrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Decrypt operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDecrypt
        ///         operation.</returns>
        IAsyncResult BeginDecrypt(DecryptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Decrypt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDecrypt.</param>
        /// 
        /// <returns>Returns a  DecryptResult from KeyManagementService.</returns>
        DecryptResponse EndDecrypt(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAlias


        /// <summary>
        /// Deletes the specified alias. To associate an alias with a different key, call <a>UpdateAlias</a>.
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DeleteAliasResponse DeleteAlias(string aliasName);

        /// <summary>
        /// Deletes the specified alias. To associate an alias with a different key, call <a>UpdateAlias</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DeleteAliasResponse DeleteAlias(DeleteAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlias
        ///         operation.</returns>
        IAsyncResult BeginDeleteAlias(DeleteAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlias.</param>
        /// 
        /// <returns>Returns a  DeleteAliasResult from KeyManagementService.</returns>
        DeleteAliasResponse EndDeleteAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeKey


        /// <summary>
        /// Provides detailed information about the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier, a fully specified ARN to either an alias or a key, or an alias name prefixed by "alias/". <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Alias ARN Example - arn:aws:kms:us-east-1:123456789012:alias/MyAliasName</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> <li>Alias Name Example - alias/MyAliasName</li> </ul> </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DescribeKeyResponse DescribeKey(string keyId);

        /// <summary>
        /// Provides detailed information about the specified customer master key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DescribeKeyResponse DescribeKey(DescribeKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKey
        ///         operation.</returns>
        IAsyncResult BeginDescribeKey(DescribeKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKey.</param>
        /// 
        /// <returns>Returns a  DescribeKeyResult from KeyManagementService.</returns>
        DescribeKeyResponse EndDescribeKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableKey


        /// <summary>
        /// Marks a key as disabled, thereby preventing its use.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DisableKeyResponse DisableKey(string keyId);

        /// <summary>
        /// Marks a key as disabled, thereby preventing its use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DisableKeyResponse DisableKey(DisableKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKey operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableKey
        ///         operation.</returns>
        IAsyncResult BeginDisableKey(DisableKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableKey.</param>
        /// 
        /// <returns>Returns a  DisableKeyResult from KeyManagementService.</returns>
        DisableKeyResponse EndDisableKey(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableKeyRotation


        /// <summary>
        /// Disables rotation of the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DisableKeyRotationResponse DisableKeyRotation(string keyId);

        /// <summary>
        /// Disables rotation of the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        DisableKeyRotationResponse DisableKeyRotation(DisableKeyRotationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableKeyRotation
        ///         operation.</returns>
        IAsyncResult BeginDisableKeyRotation(DisableKeyRotationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableKeyRotation.</param>
        /// 
        /// <returns>Returns a  DisableKeyRotationResult from KeyManagementService.</returns>
        DisableKeyRotationResponse EndDisableKeyRotation(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableKey


        /// <summary>
        /// Marks a key as enabled, thereby permitting its use. You can have up to 25 enabled
        /// keys at one time.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        EnableKeyResponse EnableKey(string keyId);

        /// <summary>
        /// Marks a key as enabled, thereby permitting its use. You can have up to 25 enabled
        /// keys at one time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        EnableKeyResponse EnableKey(EnableKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKey operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableKey
        ///         operation.</returns>
        IAsyncResult BeginEnableKey(EnableKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableKey.</param>
        /// 
        /// <returns>Returns a  EnableKeyResult from KeyManagementService.</returns>
        EnableKeyResponse EndEnableKey(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableKeyRotation


        /// <summary>
        /// Enables rotation of the specified customer master key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        EnableKeyRotationResponse EnableKeyRotation(string keyId);

        /// <summary>
        /// Enables rotation of the specified customer master key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        EnableKeyRotationResponse EnableKeyRotation(EnableKeyRotationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableKeyRotation
        ///         operation.</returns>
        IAsyncResult BeginEnableKeyRotation(EnableKeyRotationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableKeyRotation.</param>
        /// 
        /// <returns>Returns a  EnableKeyRotationResult from KeyManagementService.</returns>
        EnableKeyRotationResponse EndEnableKeyRotation(IAsyncResult asyncResult);

        #endregion
        
        #region  Encrypt


        /// <summary>
        /// Encrypts plaintext into ciphertext by using a customer master key. The <code>Encrypt</code>
        /// function has two primary use cases: <ul> <li>You can encrypt up to 4 KB of arbitrary
        /// data such as an RSA key, a database password, or other sensitive customer information.</li>
        /// <li>If you are moving encrypted data from one region to another, you can use this
        /// API to encrypt in the new region the plaintext data key that was used to encrypt the
        /// data in the original region. This provides you with an encrypted copy of the data
        /// key that can be decrypted in the new region and used there to decrypt the encrypted
        /// data. </li> </ul> 
        /// 
        ///  
        /// <para>
        /// Unless you are moving encrypted data from one region to another, you don't use this
        /// function to encrypt a generated data key within a region. You retrieve data keys already
        /// encrypted by calling the <a>GenerateDataKey</a> or <a>GenerateDataKeyWithoutPlaintext</a>
        /// function. Data keys don't need to be encrypted again by calling <code>Encrypt</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you want to encrypt data locally in your application, you can use the <code>GenerateDataKey</code>
        /// function to return a plaintext data encryption key and a copy of the key encrypted
        /// under the customer master key (CMK) of your choosing. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was disabled, not found, or otherwise not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        EncryptResponse Encrypt(EncryptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Encrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Encrypt operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEncrypt
        ///         operation.</returns>
        IAsyncResult BeginEncrypt(EncryptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Encrypt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEncrypt.</param>
        /// 
        /// <returns>Returns a  EncryptResult from KeyManagementService.</returns>
        EncryptResponse EndEncrypt(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateDataKey


        /// <summary>
        /// Generates a data key that you can use in your application to locally encrypt data.
        /// This call returns a plaintext version of the key in the <code>Plaintext</code> field
        /// of the response object and an encrypted copy of the key in the <code>CiphertextBlob</code>
        /// field. The key is encrypted by using the master key specified by the <code>KeyId</code>
        /// field. To decrypt the encrypted key, pass it to the <code>Decrypt</code> API. 
        /// 
        ///  
        /// <para>
        /// We recommend that you use the following pattern to locally encrypt data: call the
        /// <code>GenerateDataKey</code> API, use the key returned in the <code>Plaintext</code>
        /// response field to locally encrypt data, and then erase the plaintext data key from
        /// memory. Store the encrypted data key (contained in the <code>CiphertextBlob</code>
        /// field) alongside of the locally encrypted data. 
        /// </para>
        ///  <note>You should not call the <code>Encrypt</code> function to re-encrypt your data
        /// keys within a region. <code>GenerateDataKey</code> always returns the data key encrypted
        /// and tied to the customer master key that will be used to decrypt it. There is no need
        /// to decrypt it twice. </note> 
        /// <para>
        /// If you decide to use the optional <code>EncryptionContext</code> parameter, you must
        /// also store the context in full or at least store enough information along with the
        /// encrypted data to be able to reconstruct the context when submitting the ciphertext
        /// to the <code>Decrypt</code> API. It is a good practice to choose a context that you
        /// can reconstruct on the fly to better secure the ciphertext. For more information about
        /// how this parameter is used, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/encrypt-context.html">Encryption
        /// Context</a>. 
        /// </para>
        ///  
        /// <para>
        /// To decrypt data, pass the encrypted data key to the <code>Decrypt</code> API. <code>Decrypt</code>
        /// uses the associated master key to decrypt the encrypted data key and returns it as
        /// plaintext. Use the plaintext data key to locally decrypt your data and then erase
        /// the key from memory. You must specify the encryption context, if any, that you specified
        /// when you generated the key. The encryption context is logged by CloudTrail, and you
        /// can use this log to help track the use of particular data. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was disabled, not found, or otherwise not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        GenerateDataKeyResponse GenerateDataKey(GenerateDataKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateDataKey
        ///         operation.</returns>
        IAsyncResult BeginGenerateDataKey(GenerateDataKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateDataKey.</param>
        /// 
        /// <returns>Returns a  GenerateDataKeyResult from KeyManagementService.</returns>
        GenerateDataKeyResponse EndGenerateDataKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateDataKeyWithoutPlaintext


        /// <summary>
        /// Returns a data key encrypted by a customer master key without the plaintext copy of
        /// that key. Otherwise, this API functions exactly like <a>GenerateDataKey</a>. You can
        /// use this API to, for example, satisfy an audit requirement that an encrypted key be
        /// made available without exposing the plaintext copy of that key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was disabled, not found, or otherwise not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        GenerateDataKeyWithoutPlaintextResponse GenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateDataKeyWithoutPlaintext
        ///         operation.</returns>
        IAsyncResult BeginGenerateDataKeyWithoutPlaintext(GenerateDataKeyWithoutPlaintextRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateDataKeyWithoutPlaintext.</param>
        /// 
        /// <returns>Returns a  GenerateDataKeyWithoutPlaintextResult from KeyManagementService.</returns>
        GenerateDataKeyWithoutPlaintextResponse EndGenerateDataKeyWithoutPlaintext(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateRandom


        /// <summary>
        /// Generates an unpredictable byte string.
        /// </summary>
        /// <param name="numberOfBytes">Integer that contains the number of bytes to generate. Common values are 128, 256, 512, 1024 and so on. The current limit is 1024 bytes. </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        GenerateRandomResponse GenerateRandom(int numberOfBytes);

        /// <summary>
        /// Generates an unpredictable byte string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        GenerateRandomResponse GenerateRandom(GenerateRandomRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateRandom
        ///         operation.</returns>
        IAsyncResult BeginGenerateRandom(GenerateRandomRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateRandom.</param>
        /// 
        /// <returns>Returns a  GenerateRandomResult from KeyManagementService.</returns>
        GenerateRandomResponse EndGenerateRandom(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKeyPolicy


        /// <summary>
        /// Retrieves a policy attached to the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// <param name="policyName">String that contains the name of the policy. Currently, this must be "default". Policy names can be discovered by calling <a>ListKeyPolicies</a>. </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        GetKeyPolicyResponse GetKeyPolicy(string keyId, string policyName);

        /// <summary>
        /// Retrieves a policy attached to the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        GetKeyPolicyResponse GetKeyPolicy(GetKeyPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetKeyPolicy(GetKeyPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyPolicy.</param>
        /// 
        /// <returns>Returns a  GetKeyPolicyResult from KeyManagementService.</returns>
        GetKeyPolicyResponse EndGetKeyPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetKeyRotationStatus


        /// <summary>
        /// Retrieves a Boolean value that indicates whether key rotation is enabled for the specified
        /// key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        GetKeyRotationStatusResponse GetKeyRotationStatus(string keyId);

        /// <summary>
        /// Retrieves a Boolean value that indicates whether key rotation is enabled for the specified
        /// key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        GetKeyRotationStatusResponse GetKeyRotationStatus(GetKeyRotationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetKeyRotationStatus
        ///         operation.</returns>
        IAsyncResult BeginGetKeyRotationStatus(GetKeyRotationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetKeyRotationStatus.</param>
        /// 
        /// <returns>Returns a  GetKeyRotationStatusResult from KeyManagementService.</returns>
        GetKeyRotationStatusResponse EndGetKeyRotationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAliases


        /// <summary>
        /// Lists all of the key aliases in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        ListAliasesResponse ListAliases(ListAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAliases
        ///         operation.</returns>
        IAsyncResult BeginListAliases(ListAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAliases.</param>
        /// 
        /// <returns>Returns a  ListAliasesResult from KeyManagementService.</returns>
        ListAliasesResponse EndListAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListGrants


        /// <summary>
        /// List the grants for a specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        ListGrantsResponse ListGrants(ListGrantsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGrants operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListGrants
        ///         operation.</returns>
        IAsyncResult BeginListGrants(ListGrantsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListGrants operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListGrants.</param>
        /// 
        /// <returns>Returns a  ListGrantsResult from KeyManagementService.</returns>
        ListGrantsResponse EndListGrants(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKeyPolicies


        /// <summary>
        /// Retrieves a list of policies attached to a key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        ListKeyPoliciesResponse ListKeyPolicies(ListKeyPoliciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeyPolicies
        ///         operation.</returns>
        IAsyncResult BeginListKeyPolicies(ListKeyPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeyPolicies.</param>
        /// 
        /// <returns>Returns a  ListKeyPoliciesResult from KeyManagementService.</returns>
        ListKeyPoliciesResponse EndListKeyPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListKeys


        /// <summary>
        /// Lists the customer master keys.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        ListKeysResponse ListKeys(ListKeysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListKeys
        ///         operation.</returns>
        IAsyncResult BeginListKeys(ListKeysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListKeys operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListKeys.</param>
        /// 
        /// <returns>Returns a  ListKeysResult from KeyManagementService.</returns>
        ListKeysResponse EndListKeys(IAsyncResult asyncResult);

        #endregion
        
        #region  PutKeyPolicy


        /// <summary>
        /// Attaches a policy to the specified key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// <param name="policy">The policy, in JSON format, to be attached to the key.</param>
        /// <param name="policyName">Name of the policy to be attached. Currently, the only supported name is "default".</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported.
        /// </exception>
        PutKeyPolicyResponse PutKeyPolicy(string keyId, string policy, string policyName);

        /// <summary>
        /// Attaches a policy to the specified key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a quota was exceeded.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported.
        /// </exception>
        PutKeyPolicyResponse PutKeyPolicy(PutKeyPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutKeyPolicy
        ///         operation.</returns>
        IAsyncResult BeginPutKeyPolicy(PutKeyPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutKeyPolicy.</param>
        /// 
        /// <returns>Returns a  PutKeyPolicyResult from KeyManagementService.</returns>
        PutKeyPolicyResponse EndPutKeyPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ReEncrypt


        /// <summary>
        /// Encrypts data on the server side with a new customer master key without exposing the
        /// plaintext of the data on the client side. The data is first decrypted and then encrypted.
        /// This operation can also be used to change the encryption context of a ciphertext.
        /// 
        /// 
        ///  
        /// <para>
        /// Unlike other actions, <code>ReEncrypt</code> is authorized twice - once as <code>ReEncryptFrom</code>
        /// on the source key and once as <code>ReEncryptTo</code> on the destination key. We
        /// therefore recommend that you include the <code>"action":"kms:ReEncrypt*"</code> statement
        /// in your key policies to permit re-encryption from or to the key. The statement is
        /// included automatically when you authorize use of the key through the console but must
        /// be included manually when you set a policy by using the <a>PutKeyPolicy</a> function.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// A request was rejected because the specified key was marked as disabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// The request was rejected because the specified ciphertext has been corrupted or is
        /// otherwise invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected because the specified KeySpec parameter is not valid. The
        /// currently supported value is ENCRYPT/DECRYPT.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the key was disabled, not found, or otherwise not
        /// available.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        ReEncryptResponse ReEncrypt(ReEncryptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReEncrypt
        ///         operation.</returns>
        IAsyncResult BeginReEncrypt(ReEncryptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReEncrypt.</param>
        /// 
        /// <returns>Returns a  ReEncryptResult from KeyManagementService.</returns>
        ReEncryptResponse EndReEncrypt(IAsyncResult asyncResult);

        #endregion
        
        #region  RetireGrant


        /// <summary>
        /// Retires a grant. You can retire a grant when you're done using it to clean up. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API: <ul> <li>The account that created the
        /// grant</li> <li>The <code>RetiringPrincipal</code>, if present</li> <li>The <code>GranteePrincipal</code>,
        /// if <code>RetireGrant</code> is a grantee operation</li> </ul> The grant to retire
        /// must be identified by its grant token or by a combination of the key ARN and the grant
        /// ID. A grant token is a unique variable-length base64-encoded string. A grant ID is
        /// a 64 character unique identifier of a grant. Both are returned by the <code>CreateGrant</code>
        /// function.
        /// </summary>
        /// <param name="grantToken">Token that identifies the grant to be retired.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        RetireGrantResponse RetireGrant(string grantToken);

        /// <summary>
        /// Retires a grant. You can retire a grant when you're done using it to clean up. You
        /// should revoke a grant when you intend to actively deny operations that depend on it.
        /// The following are permitted to call this API: <ul> <li>The account that created the
        /// grant</li> <li>The <code>RetiringPrincipal</code>, if present</li> <li>The <code>GranteePrincipal</code>,
        /// if <code>RetireGrant</code> is a grantee operation</li> </ul> The grant to retire
        /// must be identified by its grant token or by a combination of the key ARN and the grant
        /// ID. A grant token is a unique variable-length base64-encoded string. A grant ID is
        /// a 64 character unique identifier of a grant. Both are returned by the <code>CreateGrant</code>
        /// function.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// A grant token provided as part of the request is invalid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        RetireGrantResponse RetireGrant(RetireGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetireGrant
        ///         operation.</returns>
        IAsyncResult BeginRetireGrant(RetireGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetireGrant.</param>
        /// 
        /// <returns>Returns a  RetireGrantResult from KeyManagementService.</returns>
        RetireGrantResponse EndRetireGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeGrant


        /// <summary>
        /// Revokes a grant. You can revoke a grant to actively deny operations that depend on
        /// it.
        /// </summary>
        /// <param name="grantId">Identifier of the grant to be revoked.</param>
        /// <param name="keyId">A unique identifier for the customer master key associated with the grant. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        RevokeGrantResponse RevokeGrant(string grantId, string keyId);

        /// <summary>
        /// Revokes a grant. You can revoke a grant to actively deny operations that depend on
        /// it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        RevokeGrantResponse RevokeGrant(RevokeGrantRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeGrant
        ///         operation.</returns>
        IAsyncResult BeginRevokeGrant(RevokeGrantRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeGrant.</param>
        /// 
        /// <returns>Returns a  RevokeGrantResult from KeyManagementService.</returns>
        RevokeGrantResponse EndRevokeGrant(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAlias


        /// <summary>
        /// Updates an alias to associate it with a different key.
        /// 
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
        /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
        /// is reserved by Amazon Web Services (AWS). 
        /// </para>
        ///  
        /// <para>
        /// An alias is not a property of a key. Therefore, an alias can be associated with and
        /// disassociated from an existing key without changing the properties of the key. 
        /// </para>
        ///  
        /// <para>
        /// Note that you cannot create or update an alias that represents a key in another account.
        /// </para>
        /// </summary>
        /// <param name="aliasName">String that contains the name of the alias to be modifed. The name must start with the word "alias" followed by a forward slash (alias/). Aliases that begin with "alias/AWS" are reserved.</param>
        /// <param name="targetKeyId">Unique identifier of the customer master key to be associated with the alias. This value can be a globally unique identifier or the fully specified ARN of a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        UpdateAliasResponse UpdateAlias(string aliasName, string targetKeyId);

        /// <summary>
        /// Updates an alias to associate it with a different key.
        /// 
        ///  
        /// <para>
        /// An alias name can contain only alphanumeric characters, forward slashes (/), underscores
        /// (_), and dashes (-). An alias must start with the word "alias" followed by a forward
        /// slash (alias/). An alias that begins with "aws" after the forward slash (alias/aws...)
        /// is reserved by Amazon Web Services (AWS). 
        /// </para>
        ///  
        /// <para>
        /// An alias is not a property of a key. Therefore, an alias can be associated with and
        /// disassociated from an existing key without changing the properties of the key. 
        /// </para>
        ///  
        /// <para>
        /// Note that you cannot create or update an alias that represents a key in another account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        UpdateAliasResponse UpdateAlias(UpdateAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAlias
        ///         operation.</returns>
        IAsyncResult BeginUpdateAlias(UpdateAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAlias.</param>
        /// 
        /// <returns>Returns a  UpdateAliasResult from KeyManagementService.</returns>
        UpdateAliasResponse EndUpdateAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateKeyDescription


        /// <summary>
        /// Updates the description of a key.
        /// </summary>
        /// <param name="keyId">A unique identifier for the customer master key. This value can be a globally unique identifier or the fully specified ARN to a key. <ul> <li>Key ARN Example - arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012</li> <li>Globally Unique Key ID Example - 12345678-1234-1234-1234-123456789012</li> </ul> </param>
        /// <param name="description">New description for the key.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        UpdateKeyDescriptionResponse UpdateKeyDescription(string keyId, string description);

        /// <summary>
        /// Updates the description of a key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN was not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. This error can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        UpdateKeyDescriptionResponse UpdateKeyDescription(UpdateKeyDescriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription operation on AmazonKeyManagementServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateKeyDescription
        ///         operation.</returns>
        IAsyncResult BeginUpdateKeyDescription(UpdateKeyDescriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateKeyDescription.</param>
        /// 
        /// <returns>Returns a  UpdateKeyDescriptionResult from KeyManagementService.</returns>
        UpdateKeyDescriptionResponse EndUpdateKeyDescription(IAsyncResult asyncResult);

        #endregion
        
    }
}