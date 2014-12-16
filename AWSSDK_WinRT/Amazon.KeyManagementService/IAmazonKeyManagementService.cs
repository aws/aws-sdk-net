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
using System.Threading;
using System.Threading.Tasks;
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
    /// information about KMS, see (need an address here). For the KMS developer guide, see
    /// (need address here). 
    /// </para>
    ///  <note> AWS provides SDKs that consist of libraries and sample code for various programming
    /// languages and platforms (Java, Ruby, .Net, iOS, Android, etc.). The SDKs provide a
    /// convenient way to create programmatic access to KMS and AWS. For example, the SDKs
    /// take care of tasks such as signing requests (see below), managing errors, and retrying
    /// requests automatically. For more information about the AWS SDKs, including how to
    /// download and install them, see <a href="http://aws.amazon.com/tools/">Tools for Amazon
    /// Web Services</a>. </note> 
    /// <para>
    ///  We recommend that you use the AWS SDKs to make programmatic API calls to KMS. However,
    /// you can also use the KMS Query API to make to make direct calls to the KMS web service.
    /// 
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
    /// </summary>
    public partial interface IAmazonKeyManagementService : IDisposable
    {
                
        #region  CreateAlias

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGrant

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateKey

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Decrypt

        /// <summary>
        /// Initiates the asynchronous execution of the Decrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Decrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DecryptResponse> DecryptAsync(DecryptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlias

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeKey

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableKey

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableKeyRotation

        /// <summary>
        /// Initiates the asynchronous execution of the DisableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableKey

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableKeyRotation

        /// <summary>
        /// Initiates the asynchronous execution of the EnableKeyRotation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Encrypt

        /// <summary>
        /// Initiates the asynchronous execution of the Encrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Encrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<EncryptResponse> EncryptAsync(EncryptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateDataKey

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateDataKeyWithoutPlaintext

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateDataKeyWithoutPlaintext operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateRandom

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateRandom operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetKeyPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetKeyRotationStatus

        /// <summary>
        /// Initiates the asynchronous execution of the GetKeyRotationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAliases

        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGrants

        /// <summary>
        /// Initiates the asynchronous execution of the ListGrants operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGrants operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListKeyPolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeyPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListKeys

        /// <summary>
        /// Initiates the asynchronous execution of the ListKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutKeyPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutKeyPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReEncrypt

        /// <summary>
        /// Initiates the asynchronous execution of the ReEncrypt operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetireGrant

        /// <summary>
        /// Initiates the asynchronous execution of the RetireGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeGrant

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeGrant operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateKeyDescription

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateKeyDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}