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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.KeyManagementService.Model;

#pragma warning disable CS1570
namespace Amazon.KeyManagementService
{
    /// <summary>
    /// <para>Interface for accessing KeyManagementService</para>
    ///
    /// Key Management Service 
    /// <para>
    /// Key Management Service (KMS) is an encryption and key management web service. This
    /// guide describes the KMS operations that you can call programmatically. For general
    /// information about KMS, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/">
    /// <i>Key Management Service Developer Guide</i> </a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// KMS has replaced the term <i>customer master key (CMK)</i> with <i>Key Management
    /// Service key</i> and <i>KMS key</i>. The concept has not changed. To prevent breaking
    /// changes, KMS is keeping some variations of this term.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services provides SDKs that consist of libraries and sample code for various
    /// programming languages and platforms (Java, Rust, Python, Ruby, .Net, macOS, Android,
    /// etc.). The SDKs provide a convenient way to create programmatic access to KMS and
    /// other Amazon Web Services services. For example, the SDKs take care of tasks such
    /// as signing requests (see below), managing errors, and retrying requests automatically.
    /// For more information about the Amazon Web Services SDKs, including how to download
    /// and install them, see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web
    /// Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the Amazon Web Services SDKs to make programmatic API calls
    /// to KMS.
    /// </para>
    ///  
    /// <para>
    /// If you need to use FIPS 140-2 validated cryptographic modules when communicating with
    /// Amazon Web Services, use one of the FIPS endpoints in your preferred Amazon Web Services
    /// Region. If you need communicate over IPv6, use the dual-stack endpoint in your preferred
    /// Amazon Web Services Region. For more information see <a href="https://docs.aws.amazon.com/general/latest/gr/kms.html#kms_region">Service
    /// endpoints</a> in the Key Management Service topic of the <i>Amazon Web Services General
    /// Reference</i> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/ipv6-kms.html">Dual-stack
    /// endpoint support</a> in the KMS Developer Guide.
    /// </para>
    ///  
    /// <para>
    /// All KMS API calls must be signed and be transmitted using Transport Layer Security
    /// (TLS). KMS recommends you always use the latest supported TLS version. Clients must
    /// also support cipher suites with Perfect Forward Secrecy (PFS) such as Ephemeral Diffie-Hellman
    /// (DHE) or Elliptic Curve Ephemeral Diffie-Hellman (ECDHE). Most modern systems such
    /// as Java 7 and later support these modes.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// Requests must be signed using an access key ID and a secret access key. We strongly
    /// recommend that you do not use your Amazon Web Services account root access key ID
    /// and secret access key for everyday work. You can use the access key ID and secret
    /// access key for an IAM user or you can use the Security Token Service (STS) to generate
    /// temporary security credentials and use those to sign requests. 
    /// </para>
    ///  
    /// <para>
    /// All KMS requests must be signed with <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// KMS supports CloudTrail, a service that logs Amazon Web Services API calls and related
    /// events for your Amazon Web Services account and delivers them to an Amazon S3 bucket
    /// that you specify. By using the information collected by CloudTrail, you can determine
    /// what requests were made to KMS, who made the request, when it was made, and so on.
    /// To learn more about CloudTrail, including how to turn it on and find your log files,
    /// see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/">CloudTrail
    /// User Guide</a>.
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
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/aws-security-credentials.html">Amazon
    /// Web Services Security Credentials</a> - This topic provides general information about
    /// the types of credentials used to access Amazon Web Services.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp.html">Temporary
    /// Security Credentials</a> - This section of the <i>IAM User Guide</i> describes how
    /// to create and use temporary security credentials.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a> - This set of topics walks you through the process of
    /// signing a request using an access key ID and a secret access key.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Commonly Used API Operations</b> 
    /// </para>
    ///  
    /// <para>
    /// Of the API operations discussed in this guide, the following will prove the most useful
    /// for most applications. You will likely perform operations other than these, such as
    /// creating keys and assigning policies, by using the console.
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
    public partial interface IAmazonKeyManagementService : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IKeyManagementServicePaginatorFactory Paginators { get; }
#endif
                
        #region  CancelKeyDeletion


        /// <summary>
        /// Cancels the deletion of a KMS key. When this operation succeeds, the key state of
        /// the KMS key is <c>Disabled</c>. To enable the KMS key, use <a>EnableKey</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a KMS key, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CancelKeyDeletion</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>ScheduleKeyDeletion</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key whose deletion is being canceled. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Cancels the deletion of a KMS key. When this operation succeeds, the key state of
        /// the KMS key is <c>Disabled</c>. To enable the KMS key, use <a>EnableKey</a>. 
        /// 
        ///  
        /// <para>
        /// For more information about scheduling and canceling deletion of a KMS key, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CancelKeyDeletion</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>ScheduleKeyDeletion</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelKeyDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CancelKeyDeletion">REST API Reference for CancelKeyDeletion Operation</seealso>
        Task<CancelKeyDeletionResponse> CancelKeyDeletionAsync(CancelKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ConnectCustomKeyStore



        /// <summary>
        /// Connects or reconnects a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> to its backing key store. For an CloudHSM key store, <c>ConnectCustomKeyStore</c>
        /// connects the key store to its associated CloudHSM cluster. For an external key store,
        /// <c>ConnectCustomKeyStore</c> connects the key store to the external key store proxy
        /// that communicates with your external key manager.
        /// 
        ///  
        /// <para>
        /// The custom key store must be connected before you can create KMS keys in the key store
        /// or use the KMS keys it contains. You can disconnect and reconnect a custom key store
        /// at any time.
        /// </para>
        ///  
        /// <para>
        /// The connection process for a custom key store can take an extended amount of time
        /// to complete. This operation starts the connection process, but it does not wait for
        /// it to complete. When it succeeds, this operation quickly returns an HTTP 200 response
        /// and a JSON object with no properties. However, this response does not indicate that
        /// the custom key store is connected. To get the connection state of the custom key store,
        /// use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        ///  
        /// <para>
        ///  This operation is part of the custom key stores feature in KMS, which combines the
        /// convenience and extensive integration of KMS with the isolation and control of a key
        /// store that you own and manage.
        /// </para>
        ///  
        /// <para>
        /// The <c>ConnectCustomKeyStore</c> operation might fail for various reasons. To find
        /// the reason, use the <a>DescribeCustomKeyStores</a> operation and see the <c>ConnectionErrorCode</c>
        /// in the response. For help interpreting the <c>ConnectionErrorCode</c>, see <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// To fix the failure, use the <a>DisconnectCustomKeyStore</a> operation to disconnect
        /// the custom key store, correct the error, use the <a>UpdateCustomKeyStore</a> operation
        /// if necessary, and then use <c>ConnectCustomKeyStore</c> again.
        /// </para>
        ///  
        /// <para>
        ///  <b>CloudHSM key store</b> 
        /// </para>
        ///  
        /// <para>
        /// During the connection process for an CloudHSM key store, KMS finds the CloudHSM cluster
        /// that is associated with the custom key store, creates the connection infrastructure,
        /// connects to the cluster, logs into the CloudHSM client as the <c>kmsuser</c> CU, and
        /// rotates its password.
        /// </para>
        ///  
        /// <para>
        /// To connect an CloudHSM key store, its associated CloudHSM cluster must have at least
        /// one active HSM. To get the number of active HSMs in a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation. To add HSMs to the cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation. Also, the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-cloudhsm.html#concept-kmsuser">
        /// <c>kmsuser</c> crypto user</a> (CU) must not be logged into the cluster. This prevents
        /// KMS from using this account to log in.
        /// </para>
        ///  
        /// <para>
        /// If you are having trouble connecting or disconnecting a CloudHSM key store, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// an CloudHSM key store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>External key store</b> 
        /// </para>
        ///  
        /// <para>
        /// When you connect an external key store that uses public endpoint connectivity, KMS
        /// tests its ability to communicate with your external key manager by sending a request
        /// via the external key store proxy.
        /// </para>
        ///  
        /// <para>
        /// When you connect to an external key store that uses VPC endpoint service connectivity,
        /// KMS establishes the networking elements that it needs to communicate with your external
        /// key manager via the external key store proxy. This includes creating an interface
        /// endpoint to the VPC endpoint service and a private hosted zone for traffic between
        /// KMS and the VPC endpoint service.
        /// </para>
        ///  
        /// <para>
        /// To connect an external key store, KMS must be able to connect to the external key
        /// store proxy, the external key store proxy must be able to communicate with your external
        /// key manager, and the external key manager must be available for cryptographic operations.
        /// </para>
        ///  
        /// <para>
        /// If you are having trouble connecting or disconnecting an external key store, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/xks-troubleshooting.html">Troubleshooting
        /// an external key store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ConnectCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConnectCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for an CloudHSM key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The CloudHSM cluster must be configured with private subnets in at least two different
        /// Availability Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the CloudHSM cluster.
        /// Do not delete or change them. To get information about a particular security group,
        /// use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CloudHSM cluster must contain at least as many HSMs as the operation requires.
        /// To add HSMs, use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with an CloudHSM key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster associated with the CloudHSM
        /// key store is not active. Initialize and activate the cluster and try the command again.
        /// For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <c>ConnectionState</c> of the custom key store.
        /// To get the <c>ConnectionState</c> of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>FAILED</c>. This operation
        /// is valid for all other <c>ConnectionState</c> values. To reconnect a custom key store
        /// in a <c>FAILED</c> state, disconnect it (<a>DisconnectCustomKeyStore</a>), then connect
        /// it (<c>ConnectCustomKeyStore</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
        /// This operations is valid only when the custom key store <c>ConnectionState</c> is
        /// <c>CONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
        /// with a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>DISCONNECTED</c>. This
        /// operation is valid for all other <c>ConnectionState</c> values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <c>ConnectionState</c> is <c>DISCONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
        /// not connected. This operation is valid only when the CloudHSM key store <c>ConnectionState</c>
        /// is <c>CONNECTED</c>. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ConnectCustomKeyStore">REST API Reference for ConnectCustomKeyStore Operation</seealso>
        Task<ConnectCustomKeyStoreResponse> ConnectCustomKeyStoreAsync(ConnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAlias


        /// <summary>
        /// Creates a friendly name for a KMS key. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use an alias to identify a KMS key in the KMS console, in the <a>DescribeKey</a>
        /// operation and in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a>, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. You can also change
        /// the KMS key that's associated with the alias (<a>UpdateAlias</a>) or delete the alias
        /// (<a>DeleteAlias</a>) at any time. These operations don't affect the underlying KMS
        /// key. 
        /// </para>
        ///  
        /// <para>
        /// You can associate the alias with any customer managed key in the same Amazon Web Services
        /// Region. Each alias is associated with only one KMS key at a time, but a KMS key can
        /// have multiple aliases. A valid KMS key is required. You can't create an alias without
        /// a KMS key.
        /// </para>
        ///  
        /// <para>
        /// The alias must be unique in the account and Region, but you can have aliases with
        /// the same name in different Regions. For detailed information about aliases, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">Aliases
        /// in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/alias-access.html">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
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
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">Specifies the alias name. This value must begin with <c>alias/</c> followed by a name, such as <c>alias/ExampleAlias</c>.  <important> Do not include confidential or sensitive information in this field. This field may be displayed in plaintext in CloudTrail logs and other output. </important> The <c>AliasName</c> value must be string of 1-256 characters. It can contain only alphanumeric characters, forward slashes (/), underscores (_), and dashes (-). The alias name cannot begin with <c>alias/aws/</c>. The <c>alias/aws/</c> prefix is reserved for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon Web Services managed keys</a>.</param>
        /// <param name="targetKeyId">Associates the alias with the specified <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer managed key</a>. The KMS key must be in the same Amazon Web Services Region.  A valid key ID is required. If you supply a null or empty string value, this operation returns an error. For help finding the key ID and ARN, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/find-cmk-id-arn.html">Find the key ID and key ARN</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        Task<CreateAliasResponse> CreateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Creates a friendly name for a KMS key. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use an alias to identify a KMS key in the KMS console, in the <a>DescribeKey</a>
        /// operation and in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a>, such as <a>Encrypt</a> and <a>GenerateDataKey</a>. You can also change
        /// the KMS key that's associated with the alias (<a>UpdateAlias</a>) or delete the alias
        /// (<a>DeleteAlias</a>) at any time. These operations don't affect the underlying KMS
        /// key. 
        /// </para>
        ///  
        /// <para>
        /// You can associate the alias with any customer managed key in the same Amazon Web Services
        /// Region. Each alias is associated with only one KMS key at a time, but a KMS key can
        /// have multiple aliases. A valid KMS key is required. You can't create an alias without
        /// a KMS key.
        /// </para>
        ///  
        /// <para>
        /// The alias must be unique in the account and Region, but you can have aliases with
        /// the same name in different Regions. For detailed information about aliases, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">Aliases
        /// in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return a response. To get the alias that you created, use
        /// the <a>ListAliases</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/alias-access.html">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
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
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCustomKeyStore



        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> backed by a key store that you own and manage. When you use a KMS key
        /// in a custom key store for a cryptographic operation, the cryptographic operation is
        /// actually performed in your key store using your keys. KMS supports <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-cloudhsm.html">CloudHSM
        /// key stores</a> backed by an <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/clusters.html">CloudHSM
        /// cluster</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html">external
        /// key stores</a> backed by an external key store proxy and external key manager outside
        /// of Amazon Web Services.
        /// 
        ///  
        /// <para>
        ///  This operation is part of the custom key stores feature in KMS, which combines the
        /// convenience and extensive integration of KMS with the isolation and control of a key
        /// store that you own and manage.
        /// </para>
        ///  
        /// <para>
        /// Before you create the custom key store, the required elements must be in place and
        /// operational. We recommend that you use the test tools that KMS provides to verify
        /// the configuration your external key store proxy. For details about the required elements
        /// and verification tests, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the prerequisites (for CloudHSM key stores)</a> or <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-xks-keystore.html#xks-requirements">Assemble
        /// the prerequisites (for external key stores)</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To create a custom key store, use the following parameters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create an CloudHSM key store, specify the <c>CustomKeyStoreName</c>, <c>CloudHsmClusterId</c>,
        /// <c>KeyStorePassword</c>, and <c>TrustAnchorCertificate</c>. The <c>CustomKeyStoreType</c>
        /// parameter is optional for CloudHSM key stores. If you include it, set it to the default
        /// value, <c>AWS_CLOUDHSM</c>. For help with failures, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// an CloudHSM key store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create an external key store, specify the <c>CustomKeyStoreName</c> and a <c>CustomKeyStoreType</c>
        /// of <c>EXTERNAL_KEY_STORE</c>. Also, specify values for <c>XksProxyConnectivity</c>,
        /// <c>XksProxyAuthenticationCredential</c>, <c>XksProxyUriEndpoint</c>, and <c>XksProxyUriPath</c>.
        /// If your <c>XksProxyConnectivity</c> value is <c>VPC_ENDPOINT_SERVICE</c>, specify
        /// the <c>XksProxyVpcEndpointServiceName</c> parameter. For help with failures, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/xks-troubleshooting.html">Troubleshooting
        /// an external key store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// For external key stores:
        /// </para>
        ///  
        /// <para>
        /// Some external key managers provide a simpler method for creating an external key store.
        /// For details, see your external key manager documentation.
        /// </para>
        ///  
        /// <para>
        /// When creating an external key store in the KMS console, you can upload a JSON-based
        /// proxy configuration file with the desired values. You cannot use a proxy configuration
        /// with the <c>CreateCustomKeyStore</c> operation. However, you can use the values in
        /// the file to help you determine the correct values for the <c>CreateCustomKeyStore</c>
        /// parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// When the operation completes successfully, it returns the ID of the new custom key
        /// store. Before you can use your new custom key store, you need to use the <a>ConnectCustomKeyStore</a>
        /// operation to connect a new CloudHSM key store to its CloudHSM cluster, or to connect
        /// a new external key store to the external key store proxy for your external key manager.
        /// Even if you are not going to use your custom key store immediately, you might want
        /// to connect it to verify that all settings are correct and then disconnect it until
        /// you are ready to use it.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateCustomKeyStore</a>
        /// (IAM policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInUseException">
        /// The request was rejected because the specified CloudHSM cluster is already associated
        /// with an CloudHSM key store in the account, or it shares a backup history with an CloudHSM
        /// key store in the account. Each CloudHSM key store in the account must be associated
        /// with a different CloudHSM cluster.
        /// 
        ///  
        /// <para>
        /// CloudHSM clusters that share a backup history have the same cluster certificate. To
        /// view the cluster certificate of an CloudHSM cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for an CloudHSM key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The CloudHSM cluster must be configured with private subnets in at least two different
        /// Availability Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the CloudHSM cluster.
        /// Do not delete or change them. To get information about a particular security group,
        /// use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CloudHSM cluster must contain at least as many HSMs as the operation requires.
        /// To add HSMs, use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with an CloudHSM key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster associated with the CloudHSM
        /// key store is not active. Initialize and activate the cluster and try the command again.
        /// For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because KMS cannot find the CloudHSM cluster with the specified
        /// cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectTrustAnchorException">
        /// The request was rejected because the trust anchor certificate in the request to create
        /// an CloudHSM key store is not the trust anchor certificate for the specified CloudHSM
        /// cluster.
        /// 
        ///  
        /// <para>
        /// When you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialize
        /// the CloudHSM cluster</a>, you create the trust anchor certificate and save it in the
        /// <c>customerCA.crt</c> file.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyIncorrectAuthenticationCredentialException">
        /// The request was rejected because the proxy credentials failed to authenticate to the
        /// specified external key store proxy. The specified external key store proxy rejected
        /// a status request from KMS due to invalid credentials. This can indicate an error in
        /// the credentials or in the identification of the external key store proxy.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyInvalidConfigurationException">
        /// The request was rejected because the external key store proxy is not configured correctly.
        /// To identify the cause, see the error message that accompanies the exception.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyInvalidResponseException">
        /// KMS cannot interpret the response it received from the external key store proxy. The
        /// problem might be a poorly constructed response, but it could also be a transient network
        /// issue. If you see this error repeatedly, report it to the proxy vendor.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyUriEndpointInUseException">
        /// The request was rejected because the <c>XksProxyUriEndpoint</c> is already associated
        /// with another external key store in this Amazon Web Services Region. To identify the
        /// cause, see the error message that accompanies the exception.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyUriInUseException">
        /// The request was rejected because the concatenation of the <c>XksProxyUriEndpoint</c>
        /// and <c>XksProxyUriPath</c> is already associated with another external key store in
        /// this Amazon Web Services Region. Each external key store in a Region must use a unique
        /// external key store proxy API address.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyUriUnreachableException">
        /// KMS was unable to reach the specified <c>XksProxyUriPath</c>. The path must be reachable
        /// before you create the external key store or update its settings.
        /// 
        ///  
        /// <para>
        /// This exception is also thrown when the external key store proxy response to a <c>GetHealthStatus</c>
        /// request indicates that all external key manager instances are unavailable.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyVpcEndpointServiceInUseException">
        /// The request was rejected because the specified Amazon VPC endpoint service is already
        /// associated with another external key store in this Amazon Web Services Region. Each
        /// external key store in a Region must use a different Amazon VPC endpoint service.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyVpcEndpointServiceInvalidConfigurationException">
        /// The request was rejected because the Amazon VPC endpoint service configuration does
        /// not fulfill the requirements for an external key store. To identify the cause, see
        /// the error message that accompanies the exception and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/vpc-connectivity.html#xks-vpc-requirements">review
        /// the requirements</a> for Amazon VPC endpoint service connectivity for an external
        /// key store.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyVpcEndpointServiceNotFoundException">
        /// The request was rejected because KMS could not find the specified VPC endpoint service.
        /// Use <a>DescribeCustomKeyStores</a> to verify the VPC endpoint service name for the
        /// external key store. Also, confirm that the <c>Allow principals</c> list for the VPC
        /// endpoint service includes the KMS service principal for the Region, such as <c>cks.kms.us-east-1.amazonaws.com</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateCustomKeyStore">REST API Reference for CreateCustomKeyStore Operation</seealso>
        Task<CreateCustomKeyStoreResponse> CreateCustomKeyStoreAsync(CreateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGrant



        /// <summary>
        /// Adds a grant to a KMS key. 
        /// 
        ///  
        /// <para>
        /// A <i>grant</i> is a policy instrument that allows Amazon Web Services principals to
        /// use KMS keys in cryptographic operations. It also can allow them to view a KMS key
        /// (<a>DescribeKey</a>) and create and manage grants. When authorizing access to a KMS
        /// key, grants are considered along with key policies and IAM policies. Grants are often
        /// used for temporary permissions because you can create one, use its permissions, and
        /// delete it without changing your key policies or IAM policies. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        /// The <c>CreateGrant</c> operation returns a <c>GrantToken</c> and a <c>GrantId</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. Once the grant has achieved eventual consistency,
        /// the grantee principal can use the permissions in the grant without identifying the
        /// grant. 
        /// </para>
        ///  
        /// <para>
        /// However, to use the permissions in the grant immediately, use the <c>GrantToken</c>
        /// that <c>CreateGrant</c> returns. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/using-grant-token.html">Using
        /// a grant token</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>CreateGrant</c> operation also returns a <c>GrantId</c>. You can use the <c>GrantId</c>
        /// and a key identifier to identify the grant in the <a>RetireGrant</a> and <a>RevokeGrant</a>
        /// operations. To find the grant ID, use the <a>ListGrants</a> or <a>ListRetirableGrants</a>
        /// operations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <c>KeyId</c>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateGrant</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateGrant">REST API Reference for CreateGrant Operation</seealso>
        Task<CreateGrantResponse> CreateGrantAsync(CreateGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateKey



        /// <summary>
        /// Creates a unique customer managed <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms-keys">KMS
        /// key</a> in your Amazon Web Services account and Region. You can use a KMS key in cryptographic
        /// operations, such as encryption and signing. Some Amazon Web Services services let
        /// you use KMS keys that you create and manage to protect your service resources.
        /// 
        ///  
        /// <para>
        /// A KMS key is a logical representation of a cryptographic key. In addition to the key
        /// material used in cryptographic operations, a KMS key includes metadata, such as the
        /// key ID, key policy, creation date, description, and key state. 
        /// </para>
        ///  
        /// <para>
        /// Use the parameters of <c>CreateKey</c> to specify the type of KMS key, the source
        /// of its key material, its key policy, description, tags, and other properties.
        /// </para>
        ///  <note> 
        /// <para>
        /// KMS has replaced the term <i>customer master key (CMK)</i> with <i>Key Management
        /// Service key</i> and <i>KMS key</i>. The concept has not changed. To prevent breaking
        /// changes, KMS is keeping some variations of this term.
        /// </para>
        ///  </note> 
        /// <para>
        /// To create different types of KMS keys, use the following guidance:
        /// </para>
        ///  <dl> <dt>Symmetric encryption KMS key</dt> <dd> 
        /// <para>
        /// By default, <c>CreateKey</c> creates a symmetric encryption KMS key with key material
        /// that KMS generates. This is the basic and most widely used type of KMS key, and provides
        /// the best performance.
        /// </para>
        ///  
        /// <para>
        /// To create a symmetric encryption KMS key, you don't need to specify any parameters.
        /// The default value for <c>KeySpec</c>, <c>SYMMETRIC_DEFAULT</c>, the default value
        /// for <c>KeyUsage</c>, <c>ENCRYPT_DECRYPT</c>, and the default value for <c>Origin</c>,
        /// <c>AWS_KMS</c>, create a symmetric encryption KMS key with KMS key material.
        /// </para>
        ///  
        /// <para>
        /// If you need a key for basic encryption and decryption or you are creating a KMS key
        /// to protect your resources in an Amazon Web Services service, create a symmetric encryption
        /// KMS key. The key material in a symmetric encryption key never leaves KMS unencrypted.
        /// You can use a symmetric encryption KMS key to encrypt and decrypt data up to 4,096
        /// bytes, but they are typically used to generate data keys and data keys pairs. For
        /// details, see <a>GenerateDataKey</a> and <a>GenerateDataKeyPair</a>.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Asymmetric KMS keys</dt> <dd> 
        /// <para>
        /// To create an asymmetric KMS key, use the <c>KeySpec</c> parameter to specify the type
        /// of key material in the KMS key. Then, use the <c>KeyUsage</c> parameter to determine
        /// whether the KMS key will be used to encrypt and decrypt or sign and verify. You can't
        /// change these properties after the KMS key is created.
        /// </para>
        ///  
        /// <para>
        /// Asymmetric KMS keys contain an RSA key pair, Elliptic Curve (ECC) key pair, ML-DSA
        /// key pair or an SM2 key pair (China Regions only). The private key in an asymmetric
        /// KMS key never leaves KMS unencrypted. However, you can use the <a>GetPublicKey</a>
        /// operation to download the public key so it can be used outside of KMS. Each KMS key
        /// can have only one key usage. KMS keys with RSA key pairs can be used to encrypt and
        /// decrypt data or sign and verify messages (but not both). KMS keys with NIST-recommended
        /// ECC key pairs can be used to sign and verify messages or derive shared secrets (but
        /// not both). KMS keys with <c>ECC_SECG_P256K1</c> can be used only to sign and verify
        /// messages. KMS keys with ML-DSA key pairs can be used to sign and verify messages.
        /// KMS keys with SM2 key pairs (China Regions only) can be used to either encrypt and
        /// decrypt data, sign and verify messages, or derive shared secrets (you must choose
        /// one key usage type). For information about asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>HMAC KMS key</dt> <dd> 
        /// <para>
        /// To create an HMAC KMS key, set the <c>KeySpec</c> parameter to a key spec value for
        /// HMAC KMS keys. Then set the <c>KeyUsage</c> parameter to <c>GENERATE_VERIFY_MAC</c>.
        /// You must set the key usage even though <c>GENERATE_VERIFY_MAC</c> is the only valid
        /// key usage value for HMAC KMS keys. You can't change these properties after the KMS
        /// key is created.
        /// </para>
        ///  
        /// <para>
        /// HMAC KMS keys are symmetric keys that never leave KMS unencrypted. You can use HMAC
        /// keys to generate (<a>GenerateMac</a>) and verify (<a>VerifyMac</a>) HMAC codes for
        /// messages up to 4096 bytes.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Multi-Region primary keys</dt> <dt>Imported key material</dt> <dd> 
        /// <para>
        /// To create a multi-Region <i>primary key</i> in the local Amazon Web Services Region,
        /// use the <c>MultiRegion</c> parameter with a value of <c>True</c>. To create a multi-Region
        /// <i>replica key</i>, that is, a KMS key with the same key ID and key material as a
        /// primary key, but in a different Amazon Web Services Region, use the <a>ReplicateKey</a>
        /// operation. To change a replica key to a primary key, and its primary key to a replica
        /// key, use the <a>UpdatePrimaryRegion</a> operation.
        /// </para>
        ///  
        /// <para>
        /// You can create multi-Region KMS keys for all supported KMS key types: symmetric encryption
        /// KMS keys, HMAC KMS keys, asymmetric encryption KMS keys, and asymmetric signing KMS
        /// keys. You can also create multi-Region keys with imported key material. However, you
        /// can't create multi-Region keys in a custom key store.
        /// </para>
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Multi-Region
        /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dd> 
        /// <para>
        /// To import your own key material into a KMS key, begin by creating a KMS key with no
        /// key material. To do this, use the <c>Origin</c> parameter of <c>CreateKey</c> with
        /// a value of <c>EXTERNAL</c>. Next, use <a>GetParametersForImport</a> operation to get
        /// a public key and import token. Use the wrapping public key to encrypt your key material.
        /// Then, use <a>ImportKeyMaterial</a> with your import token to import the key material.
        /// For step-by-step instructions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        /// You can import key material into KMS keys of all supported KMS key types: symmetric
        /// encryption KMS keys, HMAC KMS keys, asymmetric encryption KMS keys, and asymmetric
        /// signing KMS keys. You can also create multi-Region keys with imported key material.
        /// However, you can't import key material into a KMS key in a custom key store.
        /// </para>
        ///  
        /// <para>
        /// To create a multi-Region primary key with imported key material, use the <c>Origin</c>
        /// parameter of <c>CreateKey</c> with a value of <c>EXTERNAL</c> and the <c>MultiRegion</c>
        /// parameter with a value of <c>True</c>. To create replicas of the multi-Region primary
        /// key, use the <a>ReplicateKey</a> operation. For instructions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-create-cmk.html
        /// ">Importing key material step 1</a>. For more information about multi-Region keys,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Multi-Region
        /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  </dd> <dt>Custom key store</dt> <dd> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> lets you protect your Amazon Web Services resources using keys in a
        /// backing key store that you own and manage. When you request a cryptographic operation
        /// with a KMS key in a custom key store, the operation is performed in the backing key
        /// store using its cryptographic keys.
        /// </para>
        ///  
        /// <para>
        /// KMS supports <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-cloudhsm.html">CloudHSM
        /// key stores</a> backed by an CloudHSM cluster and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html">external
        /// key stores</a> backed by an external key manager outside of Amazon Web Services. When
        /// you create a KMS key in an CloudHSM key store, KMS generates an encryption key in
        /// the CloudHSM cluster and associates it with the KMS key. When you create a KMS key
        /// in an external key store, you specify an existing encryption key in the external key
        /// manager.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some external key managers provide a simpler method for creating a KMS key in an external
        /// key store. For details, see your external key manager documentation.
        /// </para>
        ///  </note> 
        /// <para>
        /// Before you create a KMS key in a custom key store, the <c>ConnectionState</c> of the
        /// key store must be <c>CONNECTED</c>. To connect the custom key store, use the <a>ConnectCustomKeyStore</a>
        /// operation. To find the <c>ConnectionState</c>, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// To create a KMS key in a custom key store, use the <c>CustomKeyStoreId</c>. Use the
        /// default <c>KeySpec</c> value, <c>SYMMETRIC_DEFAULT</c>, and the default <c>KeyUsage</c>
        /// value, <c>ENCRYPT_DECRYPT</c> to create a symmetric encryption key. No other key type
        /// is supported in a custom key store.
        /// </para>
        ///  
        /// <para>
        /// To create a KMS key in an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-cmk-keystore.html">CloudHSM
        /// key store</a>, use the <c>Origin</c> parameter with a value of <c>AWS_CLOUDHSM</c>.
        /// The CloudHSM cluster that is associated with the custom key store must have at least
        /// two active HSMs in different Availability Zones in the Amazon Web Services Region.
        /// </para>
        ///  
        /// <para>
        /// To create a KMS key in an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-xks-keys.html">external
        /// key store</a>, use the <c>Origin</c> parameter with a value of <c>EXTERNAL_KEY_STORE</c>
        /// and an <c>XksKeyId</c> parameter that identifies an existing external key.
        /// </para>
        ///  <note> 
        /// <para>
        /// Some external key managers provide a simpler method for creating a KMS key in an external
        /// key store. For details, see your external key manager documentation.
        /// </para>
        ///  </note> </dd> </dl> 
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation to create a KMS key in
        /// a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateKey</a>
        /// (IAM policy). To use the <c>Tags</c> parameter, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
        /// (IAM policy). For examples and information about related permissions, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/customer-managed-policies.html#iam-policy-example-create-key">Allow
        /// a user to create KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ScheduleKeyDeletion</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for an CloudHSM key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The CloudHSM cluster must be configured with private subnets in at least two different
        /// Availability Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the CloudHSM cluster.
        /// Do not delete or change them. To get information about a particular security group,
        /// use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CloudHSM cluster must contain at least as many HSMs as the operation requires.
        /// To add HSMs, use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with an CloudHSM key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <c>ConnectionState</c> of the custom key store.
        /// To get the <c>ConnectionState</c> of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>FAILED</c>. This operation
        /// is valid for all other <c>ConnectionState</c> values. To reconnect a custom key store
        /// in a <c>FAILED</c> state, disconnect it (<a>DisconnectCustomKeyStore</a>), then connect
        /// it (<c>ConnectCustomKeyStore</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
        /// This operations is valid only when the custom key store <c>ConnectionState</c> is
        /// <c>CONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
        /// with a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>DISCONNECTED</c>. This
        /// operation is valid for all other <c>ConnectionState</c> values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <c>ConnectionState</c> is <c>DISCONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
        /// not connected. This operation is valid only when the CloudHSM key store <c>ConnectionState</c>
        /// is <c>CONNECTED</c>. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksKeyAlreadyInUseException">
        /// The request was rejected because the (<c>XksKeyId</c>) is already associated with
        /// another KMS key in this external key store. Each KMS key in an external key store
        /// must be associated with a different external key.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksKeyInvalidConfigurationException">
        /// The request was rejected because the external key specified by the <c>XksKeyId</c>
        /// parameter did not meet the configuration requirements for an external key store.
        /// 
        ///  
        /// <para>
        /// The external key must be an AES-256 symmetric key that is enabled and performs encryption
        /// and decryption.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksKeyNotFoundException">
        /// The request was rejected because the external key store proxy could not find the external
        /// key. This exception is thrown when the value of the <c>XksKeyId</c> parameter doesn't
        /// identify a key in the external key manager associated with the external key proxy.
        /// 
        ///  
        /// <para>
        /// Verify that the <c>XksKeyId</c> represents an existing key in the external key manager.
        /// Use the key identifier that the external key store proxy uses to identify the key.
        /// For details, see the documentation provided with your external key store proxy or
        /// key manager.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/CreateKey">REST API Reference for CreateKey Operation</seealso>
        Task<CreateKeyResponse> CreateKeyAsync(CreateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Decrypt



        /// <summary>
        /// Decrypts ciphertext that was encrypted by a KMS key using any of the following operations:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use this operation to decrypt ciphertext that was encrypted under a symmetric
        /// encryption KMS key or an asymmetric encryption KMS key. When the KMS key is asymmetric,
        /// you must specify the KMS key and the encryption algorithm that was used to encrypt
        /// the ciphertext. For information about asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <c>Decrypt</c> operation also decrypts ciphertext that was encrypted outside of
        /// KMS by the public key in an KMS asymmetric KMS key. However, it cannot decrypt symmetric
        /// ciphertext produced by other libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
        /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with KMS.
        /// </para>
        ///  
        /// <para>
        /// If the ciphertext was encrypted under a symmetric encryption KMS key, the <c>KeyId</c>
        /// parameter is optional. KMS can get this information from metadata that it adds to
        /// the symmetric ciphertext blob. This feature adds durability to your implementation
        /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
        /// even if they've lost track of the key ID. However, specifying the KMS key is always
        /// recommended as a best practice. When you use the <c>KeyId</c> parameter to specify
        /// a KMS key, KMS only uses the KMS key you specify. If the ciphertext was encrypted
        /// under a different KMS key, the <c>Decrypt</c> operation fails. This practice ensures
        /// that you use the KMS key that you intend.
        /// </para>
        ///  
        /// <para>
        /// Whenever possible, use key policies to give users permission to call the <c>Decrypt</c>
        /// operation on a particular KMS key, instead of using IAM policies. Otherwise, you might
        /// create an IAM policy that gives the user <c>Decrypt</c> permission on all KMS keys.
        /// This user could decrypt ciphertext that was encrypted by KMS keys in other accounts
        /// if the key policy for the cross-account KMS key permits it. If you must use an IAM
        /// policy for <c>Decrypt</c> permissions, limit the user to particular KMS keys or particular
        /// trusted accounts. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/iam-policies.html#iam-policies-best-practices">Best
        /// practices for IAM policies</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>Decrypt</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
        /// Web Services Nitro Enclaves</a> and NitroTPM, which provide attested environments
        /// in Amazon EC2. To call <c>Decrypt</c> for a Nitro enclave or NitroTPM, use the <a
        /// href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
        /// parameter to provide the attestation document for the attested environment. Instead
        /// of the plaintext data, the response includes the plaintext data encrypted with the
        /// public key from the attestation document (<c>CiphertextForRecipient</c>). For information
        /// about the interaction between KMS and Amazon Web Services Nitro Enclaves or Amazon
        /// Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. If you use the <c>KeyId</c> parameter to identify
        /// a KMS key in a different Amazon Web Services account, specify the key ARN or the alias
        /// ARN of the KMS key.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Decrypt</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReEncrypt</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Decrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Decrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified KMS key cannot decrypt the data. The
        /// <c>KeyId</c> in a <a>Decrypt</a> request and the <c>SourceKeyId</c> in a <a>ReEncrypt</a>
        /// request must identify the same KMS key that was used to encrypt the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Decrypt">REST API Reference for Decrypt Operation</seealso>
        Task<DecryptResponse> DecryptAsync(DecryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlias


        /// <summary>
        /// Deletes the specified alias. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Because an alias is not a property of a KMS key, you can delete and change the aliases
        /// of a KMS key without affecting the KMS key. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all KMS keys, use the
        /// <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// Each KMS key can have multiple aliases. To change the alias of a KMS key, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different KMS key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
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
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">The alias to be deleted. The alias name must begin with <c>alias/</c> followed by the alias name, such as <c>alias/ExampleAlias</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(string aliasName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes the specified alias. 
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Because an alias is not a property of a KMS key, you can delete and change the aliases
        /// of a KMS key without affecting the KMS key. Also, aliases do not appear in the response
        /// from the <a>DescribeKey</a> operation. To get the aliases of all KMS keys, use the
        /// <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// Each KMS key can have multiple aliases. To change the alias of a KMS key, use <a>DeleteAlias</a>
        /// to delete the current alias and <a>CreateAlias</a> to create a new alias. To associate
        /// an existing alias with a different KMS key, call <a>UpdateAlias</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on an alias in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteAlias</a>
        /// on the KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
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
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCustomKeyStore



        /// <summary>
        /// Deletes a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. This operation does not affect any backing elements of the custom key
        /// store. It does not delete the CloudHSM cluster that is associated with an CloudHSM
        /// key store, or affect any users or keys in the cluster. For an external key store,
        /// it does not affect the external key store proxy, external key manager, or any external
        /// keys.
        /// 
        ///  
        /// <para>
        ///  This operation is part of the custom key stores feature in KMS, which combines the
        /// convenience and extensive integration of KMS with the isolation and control of a key
        /// store that you own and manage.
        /// </para>
        ///  
        /// <para>
        /// The custom key store that you delete cannot contain any <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms_keys">KMS
        /// keys</a>. Before deleting the key store, verify that you will never need to use any
        /// of the KMS keys in the key store for any <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a>. Then, use <a>ScheduleKeyDeletion</a> to delete the KMS keys from the
        /// key store. After the required waiting period expires and all KMS keys are deleted
        /// from the custom key store, use <a>DisconnectCustomKeyStore</a> to disconnect the key
        /// store from KMS. Then, you can delete the custom key store.
        /// </para>
        ///  
        /// <para>
        /// For keys in an CloudHSM key store, the <c>ScheduleKeyDeletion</c> operation makes
        /// a best effort to delete the key material from the associated cluster. However, you
        /// might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups. KMS never creates,
        /// manages, or deletes cryptographic keys in the external key manager associated with
        /// an external key store. You must manage them using your external key manager tools.
        /// </para>
        ///  
        /// <para>
        /// Instead of deleting the custom key store, consider using the <a>DisconnectCustomKeyStore</a>
        /// operation to disconnect the custom key store from its backing key store. While the
        /// key store is disconnected, you cannot create or use the KMS keys in the key store.
        /// But, you do not need to delete KMS keys and you can reconnect a disconnected custom
        /// key store at any time.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreHasCMKsException">
        /// The request was rejected because the custom key store contains KMS keys. After verifying
        /// that you do not need to use the KMS keys, use the <a>ScheduleKeyDeletion</a> operation
        /// to delete the KMS keys. After they are deleted, you can delete the custom key store.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <c>ConnectionState</c> of the custom key store.
        /// To get the <c>ConnectionState</c> of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>FAILED</c>. This operation
        /// is valid for all other <c>ConnectionState</c> values. To reconnect a custom key store
        /// in a <c>FAILED</c> state, disconnect it (<a>DisconnectCustomKeyStore</a>), then connect
        /// it (<c>ConnectCustomKeyStore</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
        /// This operations is valid only when the custom key store <c>ConnectionState</c> is
        /// <c>CONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
        /// with a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>DISCONNECTED</c>. This
        /// operation is valid for all other <c>ConnectionState</c> values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <c>ConnectionState</c> is <c>DISCONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
        /// not connected. This operation is valid only when the CloudHSM key store <c>ConnectionState</c>
        /// is <c>CONNECTED</c>. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteCustomKeyStore">REST API Reference for DeleteCustomKeyStore Operation</seealso>
        Task<DeleteCustomKeyStoreResponse> DeleteCustomKeyStoreAsync(DeleteCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteImportedKeyMaterial



        /// <summary>
        /// Deletes key material that was previously imported. This operation makes the specified
        /// KMS key temporarily unusable. To restore the usability of the KMS key, reimport the
        /// same key material. For more information about importing key material into KMS, see
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// When the specified KMS key is in the <c>PendingDeletion</c> state, this operation
        /// does not change the KMS key's state. Otherwise, it changes the KMS key's state to
        /// <c>PendingImport</c>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeleteImportedKeyMaterial</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteImportedKeyMaterial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteImportedKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeleteImportedKeyMaterial">REST API Reference for DeleteImportedKeyMaterial Operation</seealso>
        Task<DeleteImportedKeyMaterialResponse> DeleteImportedKeyMaterialAsync(DeleteImportedKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeriveSharedSecret



        /// <summary>
        /// Derives a shared secret using a key agreement algorithm.
        /// 
        ///  <note> 
        /// <para>
        /// You must use an asymmetric NIST-recommended elliptic curve (ECC) or SM2 (China Regions
        /// only) KMS key pair with a <c>KeyUsage</c> value of <c>KEY_AGREEMENT</c> to call DeriveSharedSecret.
        /// </para>
        ///  </note> 
        /// <para>
        /// DeriveSharedSecret uses the <a href="https://nvlpubs.nist.gov/nistpubs/SpecialPublications/NIST.SP.800-56Ar3.pdf#page=60">Elliptic
        /// Curve Cryptography Cofactor Diffie-Hellman Primitive</a> (ECDH) to establish a key
        /// agreement between two peers by deriving a shared secret from their elliptic curve
        /// public-private key pairs. You can use the raw shared secret that DeriveSharedSecret
        /// returns to derive a symmetric key that can encrypt and decrypt data that is sent between
        /// the two peers, or that can generate and verify HMACs. KMS recommends that you follow
        /// <a href="https://nvlpubs.nist.gov/nistpubs/SpecialPublications/NIST.SP.800-56Cr2.pdf">NIST
        /// recommendations for key derivation</a> when using the raw shared secret to derive
        /// a symmetric key.
        /// </para>
        ///  
        /// <para>
        /// The following workflow demonstrates how to establish key agreement over an insecure
        /// communication channel using DeriveSharedSecret.
        /// </para>
        ///  <ol> <li> 
        /// <para>
        ///  <b>Alice</b> calls <a>CreateKey</a> to create an asymmetric KMS key pair with a <c>KeyUsage</c>
        /// value of <c>KEY_AGREEMENT</c>.
        /// </para>
        ///  
        /// <para>
        /// The asymmetric KMS key must use a NIST-recommended elliptic curve (ECC) or SM2 (China
        /// Regions only) key spec.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Bob</b> creates an elliptic curve key pair.
        /// </para>
        ///  
        /// <para>
        /// Bob can call <a>CreateKey</a> to create an asymmetric KMS key pair or generate a key
        /// pair outside of KMS. Bob's key pair must use the same NIST-recommended elliptic curve
        /// (ECC) or SM2 (China Regions ony) curve as Alice.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alice and Bob <b>exchange their public keys</b> through an insecure communication
        /// channel (like the internet).
        /// </para>
        ///  
        /// <para>
        /// Use <a>GetPublicKey</a> to download the public key of your asymmetric KMS key pair.
        /// </para>
        ///  <note> 
        /// <para>
        /// KMS strongly recommends verifying that the public key you receive came from the expected
        /// party before using it to derive a shared secret.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <b>Alice</b> calls DeriveSharedSecret.
        /// </para>
        ///  
        /// <para>
        /// KMS uses the private key from the KMS key pair generated in <b>Step 1</b>, Bob's public
        /// key, and the Elliptic Curve Cryptography Cofactor Diffie-Hellman Primitive to derive
        /// the shared secret. The private key in your KMS key pair never leaves KMS unencrypted.
        /// DeriveSharedSecret returns the raw shared secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Bob</b> uses the Elliptic Curve Cryptography Cofactor Diffie-Hellman Primitive
        /// to calculate the same raw secret using his private key and Alice's public key.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To derive a shared secret you must provide a key agreement algorithm, the private
        /// key of the caller's asymmetric NIST-recommended elliptic curve or SM2 (China Regions
        /// only) KMS key pair, and the public key from your peer's NIST-recommended elliptic
        /// curve or SM2 (China Regions only) key pair. The public key can be from another asymmetric
        /// KMS key pair or from a key pair generated outside of KMS, but both key pairs must
        /// be on the same elliptic curve.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DeriveSharedSecret</a>
        /// (key policy)
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
        ///  <a>GetPublicKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeriveSharedSecret service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeriveSharedSecret service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DeriveSharedSecret">REST API Reference for DeriveSharedSecret Operation</seealso>
        Task<DeriveSharedSecretResponse> DeriveSharedSecretAsync(DeriveSharedSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCustomKeyStores



        /// <summary>
        /// Gets information about <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key stores</a> in the account and Region.
        /// 
        ///  
        /// <para>
        ///  This operation is part of the custom key stores feature in KMS, which combines the
        /// convenience and extensive integration of KMS with the isolation and control of a key
        /// store that you own and manage.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation returns information about all custom key stores in the
        /// account and Region. To get only information about a particular custom key store, use
        /// either the <c>CustomKeyStoreName</c> or <c>CustomKeyStoreId</c> parameter (but not
        /// both).
        /// </para>
        ///  
        /// <para>
        /// To determine whether the custom key store is connected to its CloudHSM cluster or
        /// external key store proxy, use the <c>ConnectionState</c> element in the response.
        /// If an attempt to connect the custom key store failed, the <c>ConnectionState</c> value
        /// is <c>FAILED</c> and the <c>ConnectionErrorCode</c> element in the response indicates
        /// the cause of the failure. For help interpreting the <c>ConnectionErrorCode</c>, see
        /// <a>CustomKeyStoresListEntry</a>.
        /// </para>
        ///  
        /// <para>
        /// Custom key stores have a <c>DISCONNECTED</c> connection state if the key store has
        /// never been connected or you used the <a>DisconnectCustomKeyStore</a> operation to
        /// disconnect it. Otherwise, the connection state is CONNECTED. If your custom key store
        /// connection state is <c>CONNECTED</c> but you are having trouble using it, verify that
        /// the backing store is active and available. For an CloudHSM key store, verify that
        /// the associated CloudHSM cluster is active and contains the minimum number of HSMs
        /// required for the operation, if any. For an external key store, verify that the external
        /// key store proxy and its associated external key manager are reachable and enabled.
        /// </para>
        ///  
        /// <para>
        ///  For help repairing your CloudHSM key store, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// CloudHSM key stores</a>. For help repairing your external key store, see the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/xks-troubleshooting.html">Troubleshooting
        /// external key stores</a>. Both topics are in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeCustomKeyStores</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomKeyStores service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomKeyStores service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeCustomKeyStores">REST API Reference for DescribeCustomKeyStores Operation</seealso>
        Task<DescribeCustomKeyStoresResponse> DescribeCustomKeyStoresAsync(DescribeCustomKeyStoresRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeKey


        /// <summary>
        /// Provides detailed information about a KMS key. You can run <c>DescribeKey</c> on a
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed key</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed key</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. It includes fields, like <c>KeySpec</c>, that help you distinguish different
        /// types of KMS keys. It also displays the key usage (encryption, signing, or generating
        /// and verifying MACs) and the algorithms that the KMS key supports. 
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">multi-Region
        /// keys</a>, <c>DescribeKey</c> displays the primary key and all related replica keys.
        /// For KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-cloudhsm.html">CloudHSM
        /// key stores</a>, it includes information about the key store, such as the key store
        /// ID and the CloudHSM cluster ID. For KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html">external
        /// key stores</a>, it includes the custom key store ID and the ID of the external key.
        /// </para>
        ///  
        /// <para>
        ///  <c>DescribeKey</c> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the KMS key. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the KMS key. To get this information,
        /// use <a>GetKeyRotationStatus</a>. Also, some key states prevent a KMS key from being
        /// automatically rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// key rotation works</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the KMS key. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the KMS key. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In general, <c>DescribeKey</c> is a non-mutating operation. It returns data about
        /// KMS keys, but doesn't change them. However, Amazon Web Services services use <c>DescribeKey</c>
        /// to create <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed keys</a> from a <i>predefined Amazon Web Services alias</i> with
        /// no key ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Describes the specified KMS key.  If you specify a predefined Amazon Web Services alias (an Amazon Web Services alias with no key ID), KMS associates the alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon Web Services managed key</a> and returns its <c>KeyId</c> and <c>Arn</c> in the response. To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using an alias name, prefix it with <c>"alias/"</c>. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN or alias ARN. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Alias name: <c>alias/ExampleAlias</c>  </li> <li> Alias ARN: <c>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. To get the alias name and alias ARN, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        Task<DescribeKeyResponse> DescribeKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Provides detailed information about a KMS key. You can run <c>DescribeKey</c> on a
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed key</a> or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed key</a>.
        /// 
        ///  
        /// <para>
        /// This detailed information includes the key ARN, creation date (and deletion date,
        /// if applicable), the key state, and the origin and expiration date (if any) of the
        /// key material. It includes fields, like <c>KeySpec</c>, that help you distinguish different
        /// types of KMS keys. It also displays the key usage (encryption, signing, or generating
        /// and verifying MACs) and the algorithms that the KMS key supports. 
        /// </para>
        ///  
        /// <para>
        /// For <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">multi-Region
        /// keys</a>, <c>DescribeKey</c> displays the primary key and all related replica keys.
        /// For KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-cloudhsm.html">CloudHSM
        /// key stores</a>, it includes information about the key store, such as the key store
        /// ID and the CloudHSM cluster ID. For KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html">external
        /// key stores</a>, it includes the custom key store ID and the ID of the external key.
        /// </para>
        ///  
        /// <para>
        ///  <c>DescribeKey</c> does not return the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Aliases associated with the KMS key. To get this information, use <a>ListAliases</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether automatic key rotation is enabled on the KMS key. To get this information,
        /// use <a>GetKeyRotationStatus</a>. Also, some key states prevent a KMS key from being
        /// automatically rotated. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotate-keys-how-it-works">How
        /// key rotation works</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags on the KMS key. To get this information, use <a>ListResourceTags</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key policies and grants on the KMS key. To get this information, use <a>GetKeyPolicy</a>
        /// and <a>ListGrants</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In general, <c>DescribeKey</c> is a non-mutating operation. It returns data about
        /// KMS keys, but doesn't change them. However, Amazon Web Services services use <c>DescribeKey</c>
        /// to create <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed keys</a> from a <i>predefined Amazon Web Services alias</i> with
        /// no key ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DescribeKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeys</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DescribeKey">REST API Reference for DescribeKey Operation</seealso>
        Task<DescribeKeyResponse> DescribeKeyAsync(DescribeKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableKey


        /// <summary>
        /// Sets the state of a KMS key to disabled. This change temporarily prevents use of the
        /// KMS key for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>EnableKey</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key to disable. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        Task<DisableKeyResponse> DisableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Sets the state of a KMS key to disabled. This change temporarily prevents use of the
        /// KMS key for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// more information about how key state affects the use of a KMS key, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>EnableKey</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKey">REST API Reference for DisableKey Operation</seealso>
        Task<DisableKeyResponse> DisableKeyAsync(DisableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableKeyRotation


        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// rotation of the key material</a> of the specified symmetric encryption KMS key.
        /// 
        ///  
        /// <para>
        /// Automatic key rotation is supported only on symmetric encryption KMS keys. You cannot
        /// enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// You can enable (<a>EnableKeyRotation</a>) and disable automatic rotation of the key
        /// material in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed KMS keys</a>. Key material rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed KMS keys</a> is not configurable. KMS always rotates the key
        /// material for every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
        /// Web Services owned KMS keys</a> varies.
        /// </para>
        ///  <note> 
        /// <para>
        /// In May 2022, KMS changed the rotation schedule for Amazon Web Services managed keys
        /// from every three years to every year. For details, see <a>EnableKeyRotation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric encryption KMS key. You cannot enable or disable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html#asymmetric-cmks">asymmetric KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom key store</a>. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        Task<DisableKeyRotationResponse> DisableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Disables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// rotation of the key material</a> of the specified symmetric encryption KMS key.
        /// 
        ///  
        /// <para>
        /// Automatic key rotation is supported only on symmetric encryption KMS keys. You cannot
        /// enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// You can enable (<a>EnableKeyRotation</a>) and disable automatic rotation of the key
        /// material in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed KMS keys</a>. Key material rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed KMS keys</a> is not configurable. KMS always rotates the key
        /// material for every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
        /// Web Services owned KMS keys</a> varies.
        /// </para>
        ///  <note> 
        /// <para>
        /// In May 2022, KMS changed the rotation schedule for Amazon Web Services managed keys
        /// from every three years to every year. For details, see <a>EnableKeyRotation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableKeyRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisableKeyRotation">REST API Reference for DisableKeyRotation Operation</seealso>
        Task<DisableKeyRotationResponse> DisableKeyRotationAsync(DisableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisconnectCustomKeyStore



        /// <summary>
        /// Disconnects the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a> from its backing key store. This operation disconnects an CloudHSM key
        /// store from its associated CloudHSM cluster or disconnects an external key store from
        /// the external key store proxy that communicates with your external key manager.
        /// 
        ///  
        /// <para>
        ///  This operation is part of the custom key stores feature in KMS, which combines the
        /// convenience and extensive integration of KMS with the isolation and control of a key
        /// store that you own and manage.
        /// </para>
        ///  
        /// <para>
        /// While a custom key store is disconnected, you can manage the custom key store and
        /// its KMS keys, but you cannot create or use its KMS keys. You can reconnect the custom
        /// key store at any time.
        /// </para>
        ///  <note> 
        /// <para>
        /// While a custom key store is disconnected, all attempts to create KMS keys in the custom
        /// key store or to use existing KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a> will fail. This action can prevent users from storing and accessing
        /// sensitive data.
        /// </para>
        ///  </note> 
        /// <para>
        /// When you disconnect a custom key store, its <c>ConnectionState</c> changes to <c>Disconnected</c>.
        /// To find the connection state of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation. To reconnect a custom key store, use the <a>ConnectCustomKeyStore</a> operation.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:DisconnectCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisconnectCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisconnectCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <c>ConnectionState</c> of the custom key store.
        /// To get the <c>ConnectionState</c> of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>FAILED</c>. This operation
        /// is valid for all other <c>ConnectionState</c> values. To reconnect a custom key store
        /// in a <c>FAILED</c> state, disconnect it (<a>DisconnectCustomKeyStore</a>), then connect
        /// it (<c>ConnectCustomKeyStore</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
        /// This operations is valid only when the custom key store <c>ConnectionState</c> is
        /// <c>CONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
        /// with a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>DISCONNECTED</c>. This
        /// operation is valid for all other <c>ConnectionState</c> values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <c>ConnectionState</c> is <c>DISCONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
        /// not connected. This operation is valid only when the CloudHSM key store <c>ConnectionState</c>
        /// is <c>CONNECTED</c>. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/DisconnectCustomKeyStore">REST API Reference for DisconnectCustomKeyStore Operation</seealso>
        Task<DisconnectCustomKeyStoreResponse> DisconnectCustomKeyStoreAsync(DisconnectCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableKey


        /// <summary>
        /// Sets the key state of a KMS key to enabled. This allows you to use the KMS key for
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>DisableKey</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies the KMS key to enable. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        Task<EnableKeyResponse> EnableKeyAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Sets the key state of a KMS key to enabled. This allows you to use the KMS key for
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#cryptographic-operations">cryptographic
        /// operations</a>. 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>DisableKey</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKey">REST API Reference for EnableKey Operation</seealso>
        Task<EnableKeyResponse> EnableKeyAsync(EnableKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableKeyRotation


        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// rotation of the key material</a> of the specified symmetric encryption KMS key. 
        /// 
        ///  
        /// <para>
        /// By default, when you enable automatic rotation of a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed KMS key</a>, KMS rotates the key material of the KMS key one year (approximately
        /// 365 days) from the enable date and every year thereafter. You can use the optional
        /// <c>RotationPeriodInDays</c> parameter to specify a custom rotation period when you
        /// enable key rotation, or you can use <c>RotationPeriodInDays</c> to modify the rotation
        /// period of a key that you previously enabled automatic key rotation on.
        /// </para>
        ///  
        /// <para>
        /// You can monitor rotation of the key material for your KMS keys in CloudTrail and Amazon
        /// CloudWatch. To disable rotation of the key material in a customer managed KMS key,
        /// use the <a>DisableKeyRotation</a> operation. You can use the <a>GetKeyRotationStatus</a>
        /// operation to identify any in progress rotations. You can use the <a>ListKeyRotations</a>
        /// operation to view the details of completed rotations.
        /// </para>
        ///  
        /// <para>
        /// Automatic key rotation is supported only on symmetric encryption KMS keys. You cannot
        /// enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, set the property on the primary key. 
        /// </para>
        ///  
        /// <para>
        /// You cannot enable or disable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed KMS keys</a>. KMS always rotates the key material of Amazon Web
        /// Services managed keys every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
        /// Web Services owned KMS keys</a> is managed by the Amazon Web Services service that
        /// owns the key.
        /// </para>
        ///  <note> 
        /// <para>
        /// In May 2022, KMS changed the rotation schedule for Amazon Web Services managed keys
        /// from every three years (approximately 1,095 days) to every year (approximately 365
        /// days).
        /// </para>
        ///  
        /// <para>
        /// New Amazon Web Services managed keys are automatically rotated one year after they
        /// are created, and approximately every year thereafter. 
        /// </para>
        ///  
        /// <para>
        /// Existing Amazon Web Services managed keys are automatically rotated one year after
        /// their most recent rotation, and every year thereafter.
        /// </para>
        ///  </note> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can perform on-demand (<a>RotateKeyOnDemand</a>) rotation of the key material
        /// in customer managed KMS keys, regardless of whether or not automatic key rotation
        /// is enabled.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Identifies a symmetric encryption KMS key. You cannot enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region keys</a>, set the property on the primary key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        Task<EnableKeyRotationResponse> EnableKeyRotationAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Enables <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// rotation of the key material</a> of the specified symmetric encryption KMS key. 
        /// 
        ///  
        /// <para>
        /// By default, when you enable automatic rotation of a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed KMS key</a>, KMS rotates the key material of the KMS key one year (approximately
        /// 365 days) from the enable date and every year thereafter. You can use the optional
        /// <c>RotationPeriodInDays</c> parameter to specify a custom rotation period when you
        /// enable key rotation, or you can use <c>RotationPeriodInDays</c> to modify the rotation
        /// period of a key that you previously enabled automatic key rotation on.
        /// </para>
        ///  
        /// <para>
        /// You can monitor rotation of the key material for your KMS keys in CloudTrail and Amazon
        /// CloudWatch. To disable rotation of the key material in a customer managed KMS key,
        /// use the <a>DisableKeyRotation</a> operation. You can use the <a>GetKeyRotationStatus</a>
        /// operation to identify any in progress rotations. You can use the <a>ListKeyRotations</a>
        /// operation to view the details of completed rotations.
        /// </para>
        ///  
        /// <para>
        /// Automatic key rotation is supported only on symmetric encryption KMS keys. You cannot
        /// enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, set the property on the primary key. 
        /// </para>
        ///  
        /// <para>
        /// You cannot enable or disable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed KMS keys</a>. KMS always rotates the key material of Amazon Web
        /// Services managed keys every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
        /// Web Services owned KMS keys</a> is managed by the Amazon Web Services service that
        /// owns the key.
        /// </para>
        ///  <note> 
        /// <para>
        /// In May 2022, KMS changed the rotation schedule for Amazon Web Services managed keys
        /// from every three years (approximately 1,095 days) to every year (approximately 365
        /// days).
        /// </para>
        ///  
        /// <para>
        /// New Amazon Web Services managed keys are automatically rotated one year after they
        /// are created, and approximately every year thereafter. 
        /// </para>
        ///  
        /// <para>
        /// Existing Amazon Web Services managed keys are automatically rotated one year after
        /// their most recent rotation, and every year thereafter.
        /// </para>
        ///  </note> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:EnableKeyRotation</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can perform on-demand (<a>RotateKeyOnDemand</a>) rotation of the key material
        /// in customer managed KMS keys, regardless of whether or not automatic key rotation
        /// is enabled.
        /// </para>
        ///  </note> </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableKeyRotation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableKeyRotation service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/EnableKeyRotation">REST API Reference for EnableKeyRotation Operation</seealso>
        Task<EnableKeyRotationResponse> EnableKeyRotationAsync(EnableKeyRotationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Encrypt



        /// <summary>
        /// Encrypts plaintext of up to 4,096 bytes using a KMS key. You can use a symmetric or
        /// asymmetric KMS key with a <c>KeyUsage</c> of <c>ENCRYPT_DECRYPT</c>.
        /// 
        ///  
        /// <para>
        /// You can use this operation to encrypt small amounts of arbitrary data, such as a personal
        /// identifier or database password, or other sensitive information. You don't need to
        /// use the <c>Encrypt</c> operation to encrypt a data key. The <a>GenerateDataKey</a>
        /// and <a>GenerateDataKeyPair</a> operations return a plaintext data key and an encrypted
        /// copy of that data key.
        /// </para>
        ///  
        /// <para>
        /// If you use a symmetric encryption KMS key, you can use an encryption context to add
        /// additional security to your encryption operation. If you specify an <c>EncryptionContext</c>
        /// when encrypting data, you must specify the same encryption context (a case-sensitive
        /// exact match) when decrypting the data. Otherwise, the request to decrypt fails with
        /// an <c>InvalidCiphertextException</c>. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify an asymmetric KMS key, you must also specify the encryption algorithm.
        /// The algorithm must be compatible with the KMS key spec.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric KMS key to encrypt or reencrypt data, be sure to record
        /// the KMS key and encryption algorithm that you choose. You will be required to provide
        /// the same KMS key and encryption algorithm when you decrypt the data. If the KMS key
        /// and algorithm do not match the values used to encrypt the data, the decrypt operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the key ID and encryption algorithm when you decrypt
        /// with symmetric encryption KMS keys because KMS stores this information in the ciphertext
        /// blob. KMS cannot store metadata in ciphertext generated with asymmetric keys. The
        /// standard format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> 
        /// <para>
        /// The maximum size of the data that you can encrypt varies with the type of KMS key
        /// and the encryption algorithm that you choose.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Symmetric encryption KMS keys
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SYMMETRIC_DEFAULT</c>: 4096 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RSA_2048</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RSAES_OAEP_SHA_1</c>: 214 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RSAES_OAEP_SHA_256</c>: 190 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RSA_3072</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RSAES_OAEP_SHA_1</c>: 342 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RSAES_OAEP_SHA_256</c>: 318 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>RSA_4096</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RSAES_OAEP_SHA_1</c>: 470 bytes
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RSAES_OAEP_SHA_256</c>: 446 bytes
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>SM2PKE</c>: 1024 bytes (China Regions only)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Encrypt</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Encrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Encrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Encrypt">REST API Reference for Encrypt Operation</seealso>
        Task<EncryptResponse> EncryptAsync(EncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateDataKey



        /// <summary>
        /// Returns a unique symmetric data key for use outside of KMS. This operation returns
        /// a plaintext copy of the data key and a copy that is encrypted under a symmetric encryption
        /// KMS key that you specify. The bytes in the plaintext key are random; they are not
        /// related to the caller or the KMS key. You can use the plaintext key to encrypt your
        /// data outside of KMS and store the encrypted data key with the encrypted data.
        /// 
        ///  
        /// <para>
        /// To generate a data key, specify the symmetric encryption KMS key that will be used
        /// to encrypt the data key. You cannot use an asymmetric KMS key to encrypt data keys.
        /// To get the type of your KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// You must also specify the length of the data key. Use either the <c>KeySpec</c> or
        /// <c>NumberOfBytes</c> parameters (but not both). For 128-bit and 256-bit data keys,
        /// use the <c>KeySpec</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// To generate a 128-bit SM4 data key (China Regions only), specify a <c>KeySpec</c>
        /// value of <c>AES_128</c> or a <c>NumberOfBytes</c> value of <c>16</c>. The symmetric
        /// encryption key used in China Regions to encrypt your data key is an SM4 encryption
        /// key.
        /// </para>
        ///  
        /// <para>
        /// To get only an encrypted copy of the data key, use <a>GenerateDataKeyWithoutPlaintext</a>.
        /// To generate an asymmetric data key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. To get a cryptographically secure random byte string, use <a>GenerateRandom</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use an optional encryption context to add additional security to the encryption
        /// operation. If you specify an <c>EncryptionContext</c>, you must specify the same encryption
        /// context (a case-sensitive exact match) when decrypting the encrypted data key. Otherwise,
        /// the request to decrypt fails with an <c>InvalidCiphertextException</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GenerateDataKey</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
        /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
        /// Amazon EC2. To call <c>GenerateDataKey</c> for an Amazon Web Services Nitro enclave
        /// or NitroTPM, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
        /// parameter to provide the attestation document for the attested environment. <c>GenerateDataKey</c>
        /// returns a copy of the data key encrypted under the specified KMS key, as usual. But
        /// instead of a plaintext copy of the data key, the response includes a copy of the data
        /// key encrypted under the public key from the attestation document (<c>CiphertextForRecipient</c>).
        /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves
        /// or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>How to use your data key</b> 
        /// </para>
        ///  
        /// <para>
        /// We recommend that you use the following pattern to encrypt data locally in your application.
        /// You can write your own code or use a client-side encryption library, such as the <a
        /// href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon Web
        /// Services Encryption SDK</a>, the <a href="https://docs.aws.amazon.com/dynamodb-encryption-client/latest/devguide/">Amazon
        /// DynamoDB Encryption Client</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a> to do these tasks for you.
        /// </para>
        ///  
        /// <para>
        /// To encrypt data outside of KMS:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <c>GenerateDataKey</c> operation to get a data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key (in the <c>Plaintext</c> field of the response) to encrypt
        /// your data outside of KMS. Then erase the plaintext data key from memory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Store the encrypted data key (in the <c>CiphertextBlob</c> field of the response)
        /// with the encrypted data.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// To decrypt data outside of KMS:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Use the <a>Decrypt</a> operation to decrypt the encrypted data key. The operation
        /// returns a plaintext copy of the data key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the plaintext data key to decrypt data outside of KMS, then erase the plaintext
        /// data key from memory.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKey">REST API Reference for GenerateDataKey Operation</seealso>
        Task<GenerateDataKeyResponse> GenerateDataKeyAsync(GenerateDataKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateDataKeyPair



        /// <summary>
        /// Returns a unique asymmetric data key pair for use outside of KMS. This operation returns
        /// a plaintext public key, a plaintext private key, and a copy of the private key that
        /// is encrypted under the symmetric encryption KMS key you specify. You can use the data
        /// key pair to perform asymmetric cryptography and implement digital signatures outside
        /// of KMS. The bytes in the keys are random; they are not related to the caller or to
        /// the KMS key that is used to encrypt the private key. 
        /// 
        ///  
        /// <para>
        /// You can use the public key that <c>GenerateDataKeyPair</c> returns to encrypt data
        /// or verify a signature outside of KMS. Then, store the encrypted private key with the
        /// data. When you are ready to decrypt data or sign a message, you can use the <a>Decrypt</a>
        /// operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric encryption KMS key to encrypt
        /// the private key in a data key pair. You cannot use an asymmetric KMS key or a KMS
        /// key in a custom key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Use the <c>KeyPairSpec</c> parameter to choose an RSA or Elliptic Curve (ECC) data
        /// key pair. In China Regions, you can also choose an SM2 data key pair. KMS recommends
        /// that you use ECC key pairs for signing, and use RSA and SM2 key pairs for either encryption
        /// or signing, but not both. However, KMS cannot enforce any restrictions on the use
        /// of data key pairs outside of KMS.
        /// </para>
        ///  
        /// <para>
        /// If you are using the data key pair to encrypt data, or for any operation where you
        /// don't immediately need a private key, consider using the <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operation. <c>GenerateDataKeyPairWithoutPlaintext</c> returns a plaintext public key
        /// and an encrypted private key, but omits the plaintext private key that you need only
        /// to decrypt ciphertext or sign a message. Later, when you need to decrypt the data
        /// or sign a message, use the <a>Decrypt</a> operation to decrypt the encrypted private
        /// key in the data key pair.
        /// </para>
        ///  
        /// <para>
        ///  <c>GenerateDataKeyPair</c> returns a unique data key pair for each request. The bytes
        /// in the keys are random; they are not related to the caller or the KMS key that is
        /// used to encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
        /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>. The private
        /// key is a DER-encoded PKCS8 PrivateKeyInfo, as specified in <a href="https://tools.ietf.org/html/rfc5958">RFC
        /// 5958</a>.
        /// </para>
        ///  
        /// <para>
        ///  <c>GenerateDataKeyPair</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
        /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
        /// Amazon EC2. To call <c>GenerateDataKeyPair</c> for an Amazon Web Services Nitro enclave
        /// or NitroTPM, use the <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
        /// parameter to provide the attestation document for the attested environment. <c>GenerateDataKeyPair</c>
        /// returns the public data key and a copy of the private data key encrypted under the
        /// specified KMS key, as usual. But instead of a plaintext copy of the private data key
        /// (<c>PrivateKeyPlaintext</c>), the response includes a copy of the private data key
        /// encrypted under the public key from the attestation document (<c>CiphertextForRecipient</c>).
        /// For information about the interaction between KMS and Amazon Web Services Nitro Enclaves
        /// or Amazon Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can use an optional encryption context to add additional security to the encryption
        /// operation. If you specify an <c>EncryptionContext</c>, you must specify the same encryption
        /// context (a case-sensitive exact match) when decrypting the encrypted data key. Otherwise,
        /// the request to decrypt fails with an <c>InvalidCiphertextException</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPair</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPair service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyPair service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPair">REST API Reference for GenerateDataKeyPair Operation</seealso>
        Task<GenerateDataKeyPairResponse> GenerateDataKeyPairAsync(GenerateDataKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateDataKeyPairWithoutPlaintext



        /// <summary>
        /// Returns a unique asymmetric data key pair for use outside of KMS. This operation returns
        /// a plaintext public key and a copy of the private key that is encrypted under the symmetric
        /// encryption KMS key you specify. Unlike <a>GenerateDataKeyPair</a>, this operation
        /// does not return a plaintext private key. The bytes in the keys are random; they are
        /// not related to the caller or to the KMS key that is used to encrypt the private key.
        /// 
        /// 
        ///  
        /// <para>
        /// You can use the public key that <c>GenerateDataKeyPairWithoutPlaintext</c> returns
        /// to encrypt data or verify a signature outside of KMS. Then, store the encrypted private
        /// key with the data. When you are ready to decrypt data or sign a message, you can use
        /// the <a>Decrypt</a> operation to decrypt the encrypted private key.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key pair, you must specify a symmetric encryption KMS key to encrypt
        /// the private key in a data key pair. You cannot use an asymmetric KMS key or a KMS
        /// key in a custom key store. To get the type and origin of your KMS key, use the <a>DescribeKey</a>
        /// operation. 
        /// </para>
        ///  
        /// <para>
        /// Use the <c>KeyPairSpec</c> parameter to choose an RSA or Elliptic Curve (ECC) data
        /// key pair. In China Regions, you can also choose an SM2 data key pair. KMS recommends
        /// that you use ECC key pairs for signing, and use RSA and SM2 key pairs for either encryption
        /// or signing, but not both. However, KMS cannot enforce any restrictions on the use
        /// of data key pairs outside of KMS.
        /// </para>
        ///  
        /// <para>
        ///  <c>GenerateDataKeyPairWithoutPlaintext</c> returns a unique data key pair for each
        /// request. The bytes in the key are not related to the caller or KMS key that is used
        /// to encrypt the private key. The public key is a DER-encoded X.509 SubjectPublicKeyInfo,
        /// as specified in <a href="https://tools.ietf.org/html/rfc5280">RFC 5280</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use an optional encryption context to add additional security to the encryption
        /// operation. If you specify an <c>EncryptionContext</c>, you must specify the same encryption
        /// context (a case-sensitive exact match) when decrypting the encrypted data key. Otherwise,
        /// the request to decrypt fails with an <c>InvalidCiphertextException</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyPairWithoutPlaintext</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyPairWithoutPlaintext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyPairWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyPairWithoutPlaintext">REST API Reference for GenerateDataKeyPairWithoutPlaintext Operation</seealso>
        Task<GenerateDataKeyPairWithoutPlaintextResponse> GenerateDataKeyPairWithoutPlaintextAsync(GenerateDataKeyPairWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateDataKeyWithoutPlaintext



        /// <summary>
        /// Returns a unique symmetric data key for use outside of KMS. This operation returns
        /// a data key that is encrypted under a symmetric encryption KMS key that you specify.
        /// The bytes in the key are random; they are not related to the caller or to the KMS
        /// key.
        /// 
        ///  
        /// <para>
        ///  <c>GenerateDataKeyWithoutPlaintext</c> is identical to the <a>GenerateDataKey</a>
        /// operation except that it does not return a plaintext copy of the data key. 
        /// </para>
        ///  
        /// <para>
        /// This operation is useful for systems that need to encrypt data at some point, but
        /// not immediately. When you need to encrypt the data, you call the <a>Decrypt</a> operation
        /// on the encrypted copy of the key.
        /// </para>
        ///  
        /// <para>
        /// It's also useful in distributed systems with different levels of trust. For example,
        /// you might store encrypted data in containers. One component of your system creates
        /// new containers and stores an encrypted data key with each container. Then, a different
        /// component puts the data into the containers. That component first decrypts the data
        /// key, uses the plaintext data key to encrypt data, puts the encrypted data into the
        /// container, and then destroys the plaintext data key. In this system, the component
        /// that creates the containers never sees the plaintext data key.
        /// </para>
        ///  
        /// <para>
        /// To request an asymmetric data key pair, use the <a>GenerateDataKeyPair</a> or <a>GenerateDataKeyPairWithoutPlaintext</a>
        /// operations.
        /// </para>
        ///  
        /// <para>
        /// To generate a data key, you must specify the symmetric encryption KMS key that is
        /// used to encrypt the data key. You cannot use an asymmetric KMS key or a key in a custom
        /// key store to generate a data key. To get the type of your KMS key, use the <a>DescribeKey</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// You must also specify the length of the data key. Use either the <c>KeySpec</c> or
        /// <c>NumberOfBytes</c> parameters (but not both). For 128-bit and 256-bit data keys,
        /// use the <c>KeySpec</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// To generate an SM4 data key (China Regions only), specify a <c>KeySpec</c> value of
        /// <c>AES_128</c> or <c>NumberOfBytes</c> value of <c>16</c>. The symmetric encryption
        /// key used in China Regions to encrypt your data key is an SM4 encryption key.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, you will find the encrypted copy of the data key in the
        /// <c>CiphertextBlob</c> field.
        /// </para>
        ///  
        /// <para>
        /// You can use an optional encryption context to add additional security to the encryption
        /// operation. If you specify an <c>EncryptionContext</c>, you must specify the same encryption
        /// context (a case-sensitive exact match) when decrypting the encrypted data key. Otherwise,
        /// the request to decrypt fails with an <c>InvalidCiphertextException</c>. For more information,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">Encryption
        /// Context</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateDataKeyWithoutPlaintext</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPairWithoutPlaintext</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateDataKeyWithoutPlaintext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateDataKeyWithoutPlaintext service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateDataKeyWithoutPlaintext">REST API Reference for GenerateDataKeyWithoutPlaintext Operation</seealso>
        Task<GenerateDataKeyWithoutPlaintextResponse> GenerateDataKeyWithoutPlaintextAsync(GenerateDataKeyWithoutPlaintextRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateMac



        /// <summary>
        /// Generates a hash-based message authentication code (HMAC) for a message using an HMAC
        /// KMS key and a MAC algorithm that the key supports. HMAC KMS keys and the HMAC algorithms
        /// that KMS uses conform to industry standards defined in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC
        /// 2104</a>.
        /// 
        ///  
        /// <para>
        /// You can use value that GenerateMac returns in the <a>VerifyMac</a> operation to demonstrate
        /// that the original message has not changed. Also, because a secret key is used to create
        /// the hash, you can verify that the party that generated the hash has the required secret
        /// key. You can also use the raw result to implement HMAC-based algorithms such as key
        /// derivation functions. This operation is part of KMS support for HMAC KMS keys. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// keys in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Best practices recommend that you limit the time during which any signing mechanism,
        /// including an HMAC, is effective. This deters an attack where the actor uses a signed
        /// message to establish validity repeatedly or long after the message is superseded.
        /// HMAC tags do not include a timestamp, but you can include a timestamp in the token
        /// or message to help you detect when its time to refresh the HMAC. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateMac</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>VerifyMac</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMac service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateMac service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateMac">REST API Reference for GenerateMac Operation</seealso>
        Task<GenerateMacResponse> GenerateMacAsync(GenerateMacRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GenerateRandom


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// You must use the <c>NumberOfBytes</c> parameter to specify the length of the random
        /// byte string. There is no default value for string length.
        /// </para>
        ///  
        /// <para>
        /// By default, the random byte string is generated in KMS. To generate the byte string
        /// in the CloudHSM cluster associated with an CloudHSM key store, use the <c>CustomKeyStoreId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <c>GenerateRandom</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
        /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
        /// Amazon EC2. To call <c>GenerateRandom</c> for a Nitro enclave or NitroTPM, use the
        /// <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
        /// parameter to provide the attestation document for the attested environment. Instead
        /// of plaintext bytes, the response includes the plaintext bytes encrypted under the
        /// public key from the attestation document (<c>CiphertextForRecipient</c>). For information
        /// about the interaction between KMS and Amazon Web Services Nitro Enclaves or Amazon
        /// Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#entropy-and-random-numbers">Entropy
        /// and random number generation</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Not applicable. <c>GenerateRandom</c> does not use any
        /// account-specific resources, such as KMS keys.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="numberOfBytes">The length of the random byte string. This parameter is required.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <c>ConnectionState</c> of the custom key store.
        /// To get the <c>ConnectionState</c> of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>FAILED</c>. This operation
        /// is valid for all other <c>ConnectionState</c> values. To reconnect a custom key store
        /// in a <c>FAILED</c> state, disconnect it (<a>DisconnectCustomKeyStore</a>), then connect
        /// it (<c>ConnectCustomKeyStore</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
        /// This operations is valid only when the custom key store <c>ConnectionState</c> is
        /// <c>CONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
        /// with a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>DISCONNECTED</c>. This
        /// operation is valid for all other <c>ConnectionState</c> values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <c>ConnectionState</c> is <c>DISCONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
        /// not connected. This operation is valid only when the CloudHSM key store <c>ConnectionState</c>
        /// is <c>CONNECTED</c>. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        Task<GenerateRandomResponse> GenerateRandomAsync(int? numberOfBytes, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns a random byte string that is cryptographically secure.
        /// 
        ///  
        /// <para>
        /// You must use the <c>NumberOfBytes</c> parameter to specify the length of the random
        /// byte string. There is no default value for string length.
        /// </para>
        ///  
        /// <para>
        /// By default, the random byte string is generated in KMS. To generate the byte string
        /// in the CloudHSM cluster associated with an CloudHSM key store, use the <c>CustomKeyStoreId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <c>GenerateRandom</c> also supports <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitro-enclave.html">Amazon
        /// Web Services Nitro Enclaves</a>, which provide an isolated compute environment in
        /// Amazon EC2. To call <c>GenerateRandom</c> for a Nitro enclave or NitroTPM, use the
        /// <a href="https://docs.aws.amazon.com/enclaves/latest/user/developing-applications.html#sdk">Amazon
        /// Web Services Nitro Enclaves SDK</a> or any Amazon Web Services SDK. Use the <c>Recipient</c>
        /// parameter to provide the attestation document for the attested environment. Instead
        /// of plaintext bytes, the response includes the plaintext bytes encrypted under the
        /// public key from the attestation document (<c>CiphertextForRecipient</c>). For information
        /// about the interaction between KMS and Amazon Web Services Nitro Enclaves or Amazon
        /// Web Services NitroTPM, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/cryptographic-attestation.html">Cryptographic
        /// attestation support in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about entropy and random number generation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-cryptography.html#entropy-and-random-numbers">Entropy
        /// and random number generation</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Not applicable. <c>GenerateRandom</c> does not use any
        /// account-specific resources, such as KMS keys.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GenerateRandom</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateRandom service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GenerateRandom service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <c>ConnectionState</c> of the custom key store.
        /// To get the <c>ConnectionState</c> of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>FAILED</c>. This operation
        /// is valid for all other <c>ConnectionState</c> values. To reconnect a custom key store
        /// in a <c>FAILED</c> state, disconnect it (<a>DisconnectCustomKeyStore</a>), then connect
        /// it (<c>ConnectCustomKeyStore</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
        /// This operations is valid only when the custom key store <c>ConnectionState</c> is
        /// <c>CONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
        /// with a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>DISCONNECTED</c>. This
        /// operation is valid for all other <c>ConnectionState</c> values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <c>ConnectionState</c> is <c>DISCONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
        /// not connected. This operation is valid only when the CloudHSM key store <c>ConnectionState</c>
        /// is <c>CONNECTED</c>. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GenerateRandom">REST API Reference for GenerateRandom Operation</seealso>
        Task<GenerateRandomResponse> GenerateRandomAsync(GenerateRandomRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetKeyPolicy


        /// <summary>
        /// Gets a key policy attached to the specified KMS key.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_PutKeyPolicy.html">PutKeyPolicy</a>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Gets the key policy for the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policyName">Specifies the name of the key policy. If no policy name is specified, the default value is <c>default</c>. The only valid name is <c>default</c>. To get the names of key policies, use <a>ListKeyPolicies</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        Task<GetKeyPolicyResponse> GetKeyPolicyAsync(string keyId, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Gets a key policy attached to the specified KMS key.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_PutKeyPolicy.html">PutKeyPolicy</a>
        /// 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyPolicy">REST API Reference for GetKeyPolicy Operation</seealso>
        Task<GetKeyPolicyResponse> GetKeyPolicyAsync(GetKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetKeyRotationStatus


        /// <summary>
        /// Provides detailed information about the rotation status for a KMS key, including whether
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// rotation of the key material</a> is enabled for the specified KMS key, the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotation-period">rotation
        /// period</a>, and the next scheduled rotation date.
        /// 
        ///  
        /// <para>
        /// Automatic key rotation is supported only on symmetric encryption KMS keys. You cannot
        /// enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// You can enable (<a>EnableKeyRotation</a>) and disable automatic rotation (<a>DisableKeyRotation</a>)
        /// of the key material in customer managed KMS keys. Key material rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed KMS keys</a> is not configurable. KMS always rotates the key
        /// material in Amazon Web Services managed KMS keys every year. The key rotation status
        /// for Amazon Web Services managed KMS keys is always <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You can perform on-demand (<a>RotateKeyOnDemand</a>) rotation of the key material
        /// in customer managed KMS keys, regardless of whether or not automatic key rotation
        /// is enabled. You can use GetKeyRotationStatus to identify the date and time that an
        /// in progress on-demand rotation was initiated. You can use <a>ListKeyRotations</a>
        /// to view the details of completed rotations.
        /// </para>
        ///  <note> 
        /// <para>
        /// In May 2022, KMS changed the rotation schedule for Amazon Web Services managed keys
        /// from every three years to every year. For details, see <a>EnableKeyRotation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a KMS key. However,
        /// while the KMS key is disabled, KMS does not rotate the key material. When you re-enable
        /// the KMS key, rotation resumes. If the key material in the re-enabled KMS key hasn't
        /// been rotated in one year, KMS rotates it immediately, and every year thereafter. If
        /// it's been less than a year since the key material in the re-enabled KMS key was rotated,
        /// the KMS key resumes its prior rotation schedule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a KMS key is pending deletion, its key rotation status is
        /// <c>false</c> and KMS does not rotate the key material. If you cancel the deletion,
        /// the original key rotation status returns to <c>true</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <c>KeyId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyRotationStatus</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Gets the rotation status for the specified KMS key. Specify the key ID or key ARN of the KMS key. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Provides detailed information about the rotation status for a KMS key, including whether
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// rotation of the key material</a> is enabled for the specified KMS key, the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#rotation-period">rotation
        /// period</a>, and the next scheduled rotation date.
        /// 
        ///  
        /// <para>
        /// Automatic key rotation is supported only on symmetric encryption KMS keys. You cannot
        /// enable automatic rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. To enable or disable automatic rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, set the property on the primary key.
        /// </para>
        ///  
        /// <para>
        /// You can enable (<a>EnableKeyRotation</a>) and disable automatic rotation (<a>DisableKeyRotation</a>)
        /// of the key material in customer managed KMS keys. Key material rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed KMS keys</a> is not configurable. KMS always rotates the key
        /// material in Amazon Web Services managed KMS keys every year. The key rotation status
        /// for Amazon Web Services managed KMS keys is always <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You can perform on-demand (<a>RotateKeyOnDemand</a>) rotation of the key material
        /// in customer managed KMS keys, regardless of whether or not automatic key rotation
        /// is enabled. You can use GetKeyRotationStatus to identify the date and time that an
        /// in progress on-demand rotation was initiated. You can use <a>ListKeyRotations</a>
        /// to view the details of completed rotations.
        /// </para>
        ///  <note> 
        /// <para>
        /// In May 2022, KMS changed the rotation schedule for Amazon Web Services managed keys
        /// from every three years to every year. For details, see <a>EnableKeyRotation</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Disabled: The key rotation status does not change when you disable a KMS key. However,
        /// while the KMS key is disabled, KMS does not rotate the key material. When you re-enable
        /// the KMS key, rotation resumes. If the key material in the re-enabled KMS key hasn't
        /// been rotated in one year, KMS rotates it immediately, and every year thereafter. If
        /// it's been less than a year since the key material in the re-enabled KMS key was rotated,
        /// the KMS key resumes its prior rotation schedule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Pending deletion: While a KMS key is pending deletion, its key rotation status is
        /// <c>false</c> and KMS does not rotate the key material. If you cancel the deletion,
        /// the original key rotation status returns to <c>true</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <c>KeyId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetKeyRotationStatus</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetKeyRotationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetKeyRotationStatus service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetKeyRotationStatus">REST API Reference for GetKeyRotationStatus Operation</seealso>
        Task<GetKeyRotationStatusResponse> GetKeyRotationStatusAsync(GetKeyRotationStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetParametersForImport



        /// <summary>
        /// Returns the public key and an import token you need to import or reimport key material
        /// for a KMS key. 
        /// 
        ///  
        /// <para>
        /// By default, KMS keys are created with key material that KMS generates. This operation
        /// supports <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// key material</a>, an advanced feature that lets you generate and import the cryptographic
        /// key material for a KMS key.
        /// </para>
        ///  
        /// <para>
        /// Before calling <c>GetParametersForImport</c>, use the <a>CreateKey</a> operation with
        /// an <c>Origin</c> value of <c>EXTERNAL</c> to create a KMS key with no key material.
        /// You can import key material for a symmetric encryption KMS key, HMAC KMS key, asymmetric
        /// encryption KMS key, or asymmetric signing KMS key. You can also import key material
        /// into a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">multi-Region
        /// key</a> of any supported type. However, you can't import key material into a KMS key
        /// in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. You can also use <c>GetParametersForImport</c> to get a public key
        /// and import token to <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#reimport-key-material">reimport
        /// the original key material</a> into a KMS key whose key material expired or was deleted.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetParametersForImport</c> returns the items that you need to import your key
        /// material.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The public key (or "wrapping key") of an RSA key pair that KMS generates.
        /// </para>
        ///  
        /// <para>
        /// You will use this public key to encrypt ("wrap") your key material while it's in transit
        /// to KMS. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A import token that ensures that KMS can decrypt your key material and associate it
        /// with the correct KMS key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The public key and its import token are permanently linked and must be used together.
        /// Each public key and import token set is valid for 24 hours. The expiration date and
        /// time appear in the <c>ParametersValidTo</c> field in the <c>GetParametersForImport</c>
        /// response. You cannot use an expired public key or import token in an <a>ImportKeyMaterial</a>
        /// request. If your key and token expire, send another <c>GetParametersForImport</c>
        /// request.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetParametersForImport</c> requires the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key ID of the KMS key for which you are importing the key material.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The key spec of the public key ("wrapping key") that you will use to encrypt your
        /// key material during import.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The wrapping algorithm that you will use with the public key to encrypt your key material.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use the same or a different public key spec and wrapping algorithm each time
        /// you import or reimport the same key material. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetParametersForImport</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteImportedKeyMaterial</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetParametersForImport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetParametersForImport service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetParametersForImport">REST API Reference for GetParametersForImport Operation</seealso>
        Task<GetParametersForImportResponse> GetParametersForImportAsync(GetParametersForImportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPublicKey



        /// <summary>
        /// Returns the public key of an asymmetric KMS key. Unlike the private key of a asymmetric
        /// KMS key, which never leaves KMS unencrypted, callers with <c>kms:GetPublicKey</c>
        /// permission can download the public key of an asymmetric KMS key. You can share the
        /// public key to allow others to encrypt messages and verify signatures outside of KMS.
        /// For information about asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You do not need to download the public key. Instead, you can use the public key within
        /// KMS by calling the <a>Encrypt</a>, <a>ReEncrypt</a>, or <a>Verify</a> operations with
        /// the identifier of an asymmetric KMS key. When you use the public key within KMS, you
        /// benefit from the authentication, authorization, and logging that are part of every
        /// KMS operation. You also reduce of risk of encrypting data that cannot be decrypted.
        /// These features are not effective outside of KMS.
        /// </para>
        ///  
        /// <para>
        /// To help you use the public key safely outside of KMS, <c>GetPublicKey</c> returns
        /// important information about the public key in the response, including:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeySpec">KeySpec</a>:
        /// The type of key material in the public key, such as <c>RSA_4096</c> or <c>ECC_NIST_P521</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeyUsage">KeyUsage</a>:
        /// Whether the key is used for encryption, signing, or deriving a shared secret.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-EncryptionAlgorithms">EncryptionAlgorithms</a>,
        /// <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-KeyAgreementAlgorithms">KeyAgreementAlgorithms</a>,
        /// or <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_GetPublicKey.html#KMS-GetPublicKey-response-SigningAlgorithms">SigningAlgorithms</a>:
        /// A list of the encryption algorithms, key agreement algorithms, or signing algorithms
        /// for the key.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Although KMS cannot enforce these restrictions on external operations, it is crucial
        /// that you use this information to prevent the public key from being used improperly.
        /// For example, you can prevent a public signing key from being used encrypt data, or
        /// prevent a public key from being used with an encryption algorithm that is not supported
        /// by KMS. You can also avoid errors, such as using the wrong signing algorithm in a
        /// verification operation.
        /// </para>
        ///  
        /// <para>
        /// To verify a signature outside of KMS with an SM2 public key (China Regions only),
        /// you must specify the distinguishing ID. By default, KMS uses <c>1234567812345678</c>
        /// as the distinguishing ID. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/offline-operations.html#key-spec-sm-offline-verification">Offline
        /// verification with SM2 key pairs</a>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:GetPublicKey</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>CreateKey</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPublicKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/GetPublicKey">REST API Reference for GetPublicKey Operation</seealso>
        Task<GetPublicKeyResponse> GetPublicKeyAsync(GetPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportKeyMaterial



        /// <summary>
        /// Imports or reimports key material into an existing KMS key that was created without
        /// key material. You can also use this operation to set or update the expiration model
        /// and expiration date of the imported key material.
        /// 
        ///  
        /// <para>
        /// By default, KMS creates KMS keys with key material that it generates. You can also
        /// generate and import your own key material. For more information about importing key
        /// material, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// key material</a>.
        /// </para>
        ///  
        /// <para>
        /// For asymmetric, HMAC and multi-Region keys, you cannot change the key material after
        /// the initial import. You can import multiple key materials into single-Region, symmetric
        /// encryption keys and rotate the key material on demand using <c>RotateKeyOnDemand</c>.
        /// </para>
        ///  
        /// <para>
        /// After you import key material, you can <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#reimport-key-material">reimport
        /// the same key material</a> into that KMS key or, if the key supports on-demand rotation,
        /// import new key material. You can use the <c>ImportType</c> parameter to indicate whether
        /// you are importing new key material or re-importing previously imported key material.
        /// You might reimport key material to replace key material that expired or key material
        /// that you deleted. You might also reimport key material to change the expiration model
        /// or expiration date of the key material.
        /// </para>
        ///  
        /// <para>
        /// Each time you import key material into KMS, you can determine whether (<c>ExpirationModel</c>)
        /// and when (<c>ValidTo</c>) the key material expires. To change the expiration of your
        /// key material, you must import it again, either by calling <c>ImportKeyMaterial</c>
        /// or using the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#importing-keys-import-key-material-console">import
        /// features</a> of the KMS console.
        /// </para>
        ///  
        /// <para>
        /// Before you call <c>ImportKeyMaterial</c>, complete these steps:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create or identify a KMS key with <c>EXTERNAL</c> origin, which indicates that the
        /// KMS key is designed for imported key material. 
        /// </para>
        ///  
        /// <para>
        /// To create a new KMS key for imported key material, call the <a>CreateKey</a> operation
        /// with an <c>Origin</c> value of <c>EXTERNAL</c>. You can create a symmetric encryption
        /// KMS key, HMAC KMS key, asymmetric encryption KMS key, asymmetric key agreement key,
        /// or asymmetric signing KMS key. You can also import key material into a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">multi-Region
        /// key</a> of any supported type. However, you can't import key material into a KMS key
        /// in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Call the <a>GetParametersForImport</a> operation to get a public key and import token
        /// set for importing key material. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the public key in the <a>GetParametersForImport</a> response to encrypt your key
        /// material.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Then, in an <c>ImportKeyMaterial</c> request, you submit your encrypted key material
        /// and import token. When calling this operation, you must specify the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key ID or key ARN of the KMS key to associate with the imported key material.
        /// Its <c>Origin</c> must be <c>EXTERNAL</c> and its <c>KeyState</c> must be <c>PendingImport</c>.
        /// You cannot perform this operation on a KMS key in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, or on a KMS key in a different Amazon Web Services account. To get
        /// the <c>Origin</c> and <c>KeyState</c> of a KMS key, call <a>DescribeKey</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encrypted key material. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The import token that <a>GetParametersForImport</a> returned. You must use a public
        /// key and token from the same <c>GetParametersForImport</c> response.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Whether the key material expires (<c>ExpirationModel</c>) and, if so, when (<c>ValidTo</c>).
        /// For help with this choice, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html#importing-keys-expiration">Setting
        /// an expiration time</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you set an expiration date, KMS deletes the key material from the KMS key on the
        /// specified date, making the KMS key unusable. To use the KMS key in cryptographic operations
        /// again, you must reimport the same key material. However, you can delete and reimport
        /// the key material at any time, including before the key material expires. Each time
        /// you reimport, you can eliminate or reset the expiration time.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When this operation is successful, the key state of the KMS key changes from <c>PendingImport</c>
        /// to <c>Enabled</c>, and you can use the KMS key in cryptographic operations. For single-Region,
        /// symmetric encryption keys, you will need to import all of the key materials associated
        /// with the KMS key to change its state to <c>Enabled</c>. Use the <c>ListKeyRotations</c>
        /// operation to list the ID and import state of each key material associated with a KMS
        /// key.
        /// </para>
        ///  
        /// <para>
        /// If this operation fails, use the exception to help determine the problem. If the error
        /// is related to the key material, the import token, or wrapping key, use <a>GetParametersForImport</a>
        /// to get a new public key and import token for the KMS key and repeat the import procedure.
        /// For help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-conceptual.html">Create
        /// a KMS key with imported key material</a> in the <i>Key Management Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ImportKeyMaterial</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteImportedKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetParametersForImport</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyMaterial service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportKeyMaterial service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.ExpiredImportTokenException">
        /// The request was rejected because the specified import token is expired. Use <a>GetParametersForImport</a>
        /// to get a new import token and public key, use the new public key to encrypt the key
        /// material, and then try the request again.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyMaterialException">
        /// The request was rejected because the key material in the request is, expired, invalid,
        /// or does not meet expectations. For example, it is not the same key material that was
        /// previously imported or KMS expected new key material but the key material being imported
        /// is already associated with the KMS key.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidImportTokenException">
        /// The request was rejected because the provided import token is invalid or is associated
        /// with a different KMS key.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ImportKeyMaterial">REST API Reference for ImportKeyMaterial Operation</seealso>
        Task<ImportKeyMaterialResponse> ImportKeyMaterialAsync(ImportKeyMaterialRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAliases



        /// <summary>
        /// Gets a list of aliases in the caller's Amazon Web Services account and region. For
        /// more information about aliases, see <a>CreateAlias</a>.
        /// 
        ///  
        /// <para>
        /// By default, the <c>ListAliases</c> operation returns all aliases in the account and
        /// region. To get only the aliases associated with a particular KMS key, use the <c>KeyId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// The <c>ListAliases</c> response can include aliases that you created and associated
        /// with your customer managed keys, and aliases that Amazon Web Services created and
        /// associated with Amazon Web Services managed keys in your account. You can recognize
        /// Amazon Web Services aliases because their names have the format <c>aws/&lt;service-name&gt;</c>,
        /// such as <c>aws/dynamodb</c>.
        /// </para>
        ///  
        /// <para>
        /// The response might also include aliases that have no <c>TargetKeyId</c> field. These
        /// are predefined aliases that Amazon Web Services has created but has not yet associated
        /// with a KMS key. Aliases that Amazon Web Services creates in your account, including
        /// predefined aliases, do not count against your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/resource-limits.html#aliases-per-key">KMS
        /// aliases quota</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. <c>ListAliases</c> does not return aliases in other
        /// Amazon Web Services accounts.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListAliases</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/alias-access.html">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
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
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAliases service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListGrants



        /// <summary>
        /// Gets a list of all grants for the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// You must specify the KMS key in all requests. You can filter the grant list by grant
        /// ID or grantee principal.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>GranteePrincipal</c> field in the <c>ListGrants</c> response usually contains
        /// the user or role designated as the grantee principal in the grant. However, when the
        /// grantee principal in the grant is an Amazon Web Services service, the <c>GranteePrincipal</c>
        /// field contains the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_principal.html#principal-services">service
        /// principal</a>, which might represent several different grantee principals.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <c>KeyId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListGrants</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <c>GrantId</c> is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListGrants">REST API Reference for ListGrants Operation</seealso>
        Task<ListGrantsResponse> ListGrantsAsync(ListGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListKeyPolicies



        /// <summary>
        /// Gets the names of the key policies that are attached to a KMS key. This operation
        /// is designed to get policy names that you can use in a <a>GetKeyPolicy</a> operation.
        /// However, the only valid policy name is <c>default</c>. 
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeyPolicies</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetKeyPolicy</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_PutKeyPolicy.html">PutKeyPolicy</a>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyPolicies service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyPolicies">REST API Reference for ListKeyPolicies Operation</seealso>
        Task<ListKeyPoliciesResponse> ListKeyPoliciesAsync(ListKeyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListKeyRotations



        /// <summary>
        /// Returns information about the key materials associated with the specified KMS key.
        /// You can use the optional <c>IncludeKeyMaterial</c> parameter to control which key
        /// materials are included in the response.
        /// 
        ///  
        /// <para>
        /// You must specify the KMS key in all requests. You can refine the key rotations list
        /// by limiting the number of rotations returned.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about automatic and on-demand key rotations, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">Rotate
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeyRotations</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteImportedKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RotateKeyOnDemand</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeyRotations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeyRotations service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeyRotations">REST API Reference for ListKeyRotations Operation</seealso>
        Task<ListKeyRotationsResponse> ListKeyRotationsAsync(ListKeyRotationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListKeys



        /// <summary>
        /// Gets a list of all KMS keys in the caller's Amazon Web Services account and Region.
        /// 
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListKeys</a>
        /// (IAM policy)
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
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListKeys service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListKeys service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidMarkerException">
        /// The request was rejected because the marker that specifies where pagination should
        /// next begin is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListKeys">REST API Reference for ListKeys Operation</seealso>
        Task<ListKeysResponse> ListKeysAsync(ListKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListResourceTags



        /// <summary>
        /// Returns all tags on the specified KMS key.
        /// 
        ///  
        /// <para>
        /// For general information about tags, including the format and syntax, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tags
        /// in KMS</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListResourceTags</a>
        /// (key policy)
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
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceTags service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ListResourceTags">REST API Reference for ListResourceTags Operation</seealso>
        Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRetirableGrants


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. This operation returns a list of grants where the retiring principal specified
        /// in the <c>ListRetirableGrants</c> request is the same retiring principal on the grant.
        /// This can include grants on KMS keys owned by other Amazon Web Services accounts, but
        /// you do not need <c>kms:ListRetirableGrants</c> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  <note> 
        /// <para>
        /// KMS authorizes <c>ListRetirableGrants</c> requests by evaluating the caller account's
        /// kms:ListRetirableGrants permissions. The authorized resource in <c>ListRetirableGrants</c>
        /// calls is the retiring principal specified in the request. KMS does not evaluate the
        /// caller's permissions to verify their access to any KMS keys or grants that might be
        /// returned by the <c>ListRetirableGrants</c> call.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="retiringPrincipal">The retiring principal for which to list grants. Enter a principal in your Amazon Web Services account. To specify the retiring principal, use the <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Name (ARN)</a> of an Amazon Web Services principal. Valid principals include Amazon Web Services accounts, IAM users, IAM roles, federated users, and assumed role users. For help with the ARN syntax for a principal, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html#identifiers-arns">IAM ARNs</a> in the <i> <i>Identity and Access Management User Guide</i> </i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(string retiringPrincipal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. This operation returns a list of grants where the retiring principal specified
        /// in the <c>ListRetirableGrants</c> request is the same retiring principal on the grant.
        /// This can include grants on KMS keys owned by other Amazon Web Services accounts, but
        /// you do not need <c>kms:ListRetirableGrants</c> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  <note> 
        /// <para>
        /// KMS authorizes <c>ListRetirableGrants</c> requests by evaluating the caller account's
        /// kms:ListRetirableGrants permissions. The authorized resource in <c>ListRetirableGrants</c>
        /// calls is the retiring principal specified in the request. KMS does not evaluate the
        /// caller's permissions to verify their access to any KMS keys or grants that might be
        /// returned by the <c>ListRetirableGrants</c> call.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Returns information about all grants in the Amazon Web Services account and Region
        /// that have the specified retiring principal. 
        /// 
        ///  
        /// <para>
        /// You can specify any principal in your Amazon Web Services account. The grants that
        /// are returned include grants for KMS keys in your Amazon Web Services account and other
        /// Amazon Web Services accounts. You might use this operation to determine which grants
        /// you may retire. To retire a grant, use the <a>RetireGrant</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: You must specify a principal in your Amazon Web Services
        /// account. This operation returns a list of grants where the retiring principal specified
        /// in the <c>ListRetirableGrants</c> request is the same retiring principal on the grant.
        /// This can include grants on KMS keys owned by other Amazon Web Services accounts, but
        /// you do not need <c>kms:ListRetirableGrants</c> permission (or any other additional
        /// permission) in any Amazon Web Services account other than your own.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ListRetirableGrants</a>
        /// (IAM policy) in your Amazon Web Services account.
        /// </para>
        ///  <note> 
        /// <para>
        /// KMS authorizes <c>ListRetirableGrants</c> requests by evaluating the caller account's
        /// kms:ListRetirableGrants permissions. The authorized resource in <c>ListRetirableGrants</c>
        /// calls is the retiring principal specified in the request. KMS does not evaluate the
        /// caller's permissions to verify their access to any KMS keys or grants that might be
        /// returned by the <c>ListRetirableGrants</c> call.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRetirableGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRetirableGrants service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        Task<ListRetirableGrantsResponse> ListRetirableGrantsAsync(ListRetirableGrantsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutKeyPolicy


        /// <summary>
        /// Attaches a key policy to the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>Key Management Service Developer Guide</i>. For help writing
        /// and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
        /// </i>. For examples of adding a key policy in multiple programming languages, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_PutKeyPolicy_section.html">Use
        /// PutKeyPolicy with an Amazon Web Services SDK or CLI</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:PutKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>GetKeyPolicy</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Sets the key policy on the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="policy">The key policy to attach to the KMS key. The key policy must meet the following criteria: <ul> <li> The key policy must allow the calling principal to make a subsequent <c>PutKeyPolicy</c> request on the KMS key. This reduces the risk that the KMS key becomes unmanageable. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policy-default.html#prevent-unmanageable-key">Default key policy</a> in the <i>Key Management Service Developer Guide</i>. (To omit this condition, set <c>BypassPolicyLockoutSafetyCheck</c> to true.) </li> <li> Each statement in the key policy must contain one or more principals. The principals in the key policy must exist and be visible to KMS. When you create a new Amazon Web Services principal, you might need to enforce a delay before including the new principal in a key policy because the new principal might not be immediately visible to KMS. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes that I make are not always immediately visible</a> in the <i>Amazon Web Services Identity and Access Management User Guide</i>. </li> </ul> <note> If either of the required <c>Resource</c> or <c>Action</c> elements are missing from a key policy statement, the policy statement has no effect. When a key policy statement is missing one of these elements, the KMS console correctly reports an error, but the <c>PutKeyPolicy</c> API request succeeds, even though the policy statement is ineffective. For more information on required key policy elements, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policy-overview.html#key-policy-elements">Elements in a key policy</a> in the <i>Key Management Service Developer Guide</i>. </note> A key policy document can include only the following characters: <ul> <li> Printable ASCII characters from the space character (<c>\u0020</c>) through the end of the ASCII character range. </li> <li> Printable characters in the Basic Latin and Latin-1 Supplement character set (through <c>\u00FF</c>). </li> <li> The tab (<c>\u0009</c>), line feed (<c>\u000A</c>), and carriage return (<c>\u000D</c>) special characters </li> </ul> <note> If the key policy exceeds the length constraint, KMS returns a <c>LimitExceededException</c>. </note> For information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key policies in KMS</a> in the <i>Key Management Service Developer Guide</i>.For help writing and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i> </i>.</param>
        /// <param name="policyName">The name of the key policy. If no policy name is specified, the default value is <c>default</c>. The only valid value is <c>default</c>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
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
        Task<PutKeyPolicyResponse> PutKeyPolicyAsync(string keyId, string policy, string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Attaches a key policy to the specified KMS key. 
        /// 
        ///  
        /// <para>
        /// For more information about key policies, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">Key
        /// Policies</a> in the <i>Key Management Service Developer Guide</i>. For help writing
        /// and formatting a JSON policy document, see the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i> <i>Identity and Access Management User Guide</i>
        /// </i>. For examples of adding a key policy in multiple programming languages, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_PutKeyPolicy_section.html">Use
        /// PutKeyPolicy with an Amazon Web Services SDK or CLI</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:PutKeyPolicy</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>GetKeyPolicy</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyPolicy service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
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
        Task<PutKeyPolicyResponse> PutKeyPolicyAsync(PutKeyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReEncrypt



        /// <summary>
        /// Decrypts ciphertext and then reencrypts it entirely within KMS. You can use this operation
        /// to change the KMS key under which data is encrypted, such as when you <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys-manually.html">manually
        /// rotate</a> a KMS key or change the KMS key that protects a ciphertext. You can also
        /// use it to reencrypt ciphertext under the same KMS key, such as to change the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/encrypt_context.html">encryption
        /// context</a> of a ciphertext.
        /// 
        ///  
        /// <para>
        /// The <c>ReEncrypt</c> operation can decrypt ciphertext that was encrypted by using
        /// a KMS key in an KMS operation, such as <a>Encrypt</a> or <a>GenerateDataKey</a>. It
        /// can also decrypt ciphertext that was encrypted by using the public key of an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS key</a> outside of KMS. However, it cannot decrypt ciphertext produced by other
        /// libraries, such as the <a href="https://docs.aws.amazon.com/encryption-sdk/latest/developer-guide/">Amazon
        /// Web Services Encryption SDK</a> or <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingClientSideEncryption.html">Amazon
        /// S3 client-side encryption</a>. These libraries return a ciphertext format that is
        /// incompatible with KMS.
        /// </para>
        ///  
        /// <para>
        /// When you use the <c>ReEncrypt</c> operation, you need to provide information for the
        /// decrypt operation and the subsequent encrypt operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If your ciphertext was encrypted under an asymmetric KMS key, you must use the <c>SourceKeyId</c>
        /// parameter to identify the KMS key that encrypted the ciphertext. You must also supply
        /// the encryption algorithm that was used. This information is required to decrypt the
        /// data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your ciphertext was encrypted under a symmetric encryption KMS key, the <c>SourceKeyId</c>
        /// parameter is optional. KMS can get this information from metadata that it adds to
        /// the symmetric ciphertext blob. This feature adds durability to your implementation
        /// by ensuring that authorized users can decrypt ciphertext decades after it was encrypted,
        /// even if they've lost track of the key ID. However, specifying the source KMS key is
        /// always recommended as a best practice. When you use the <c>SourceKeyId</c> parameter
        /// to specify a KMS key, KMS uses only the KMS key you specify. If the ciphertext was
        /// encrypted under a different KMS key, the <c>ReEncrypt</c> operation fails. This practice
        /// ensures that you use the KMS key that you intend.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To reencrypt the data, you must use the <c>DestinationKeyId</c> parameter to specify
        /// the KMS key that re-encrypts the data after it is decrypted. If the destination KMS
        /// key is an asymmetric KMS key, you must also provide the encryption algorithm. The
        /// algorithm that you choose must be compatible with the KMS key.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you use an asymmetric KMS key to encrypt or reencrypt data, be sure to record
        /// the KMS key and encryption algorithm that you choose. You will be required to provide
        /// the same KMS key and encryption algorithm when you decrypt the data. If the KMS key
        /// and algorithm do not match the values used to encrypt the data, the decrypt operation
        /// fails.
        /// </para>
        ///  
        /// <para>
        /// You are not required to supply the key ID and encryption algorithm when you decrypt
        /// with symmetric encryption KMS keys because KMS stores this information in the ciphertext
        /// blob. KMS cannot store metadata in ciphertext generated with asymmetric keys. The
        /// standard format for asymmetric key ciphertext does not include configurable fields.
        /// </para>
        ///  </important> </li> </ul> 
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. The source KMS key and destination KMS key can be
        /// in different Amazon Web Services accounts. Either or both KMS keys can be in a different
        /// account than the caller. To specify a KMS key in a different account, you must use
        /// its key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptFrom</a>
        /// permission on the source KMS key (key policy)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:ReEncryptTo</a>
        /// permission on the destination KMS key (key policy)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To permit reencryption from or to a KMS key, include the <c>"kms:ReEncrypt*"</c> permission
        /// in your <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policy</a>. This permission is automatically included in the key policy when you use
        /// the console to create a KMS key. But you must include it manually when you create
        /// a KMS key programmatically or when you use the <a>PutKeyPolicy</a> operation to set
        /// a key policy.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>Decrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>Encrypt</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GenerateDataKeyPair</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReEncrypt service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReEncrypt service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.IncorrectKeyException">
        /// The request was rejected because the specified KMS key cannot decrypt the data. The
        /// <c>KeyId</c> in a <a>Decrypt</a> request and the <c>SourceKeyId</c> in a <a>ReEncrypt</a>
        /// request must identify the same KMS key that was used to encrypt the ciphertext.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidCiphertextException">
        /// From the <a>Decrypt</a> or <a>ReEncrypt</a> operation, the request was rejected because
        /// the specified ciphertext, or additional authenticated data incorporated into the ciphertext,
        /// such as the encryption context, is corrupted, missing, or otherwise invalid.
        /// 
        ///  
        /// <para>
        /// From the <a>ImportKeyMaterial</a> operation, the request was rejected because KMS
        /// could not decrypt the encrypted (wrapped) key material. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReEncrypt">REST API Reference for ReEncrypt Operation</seealso>
        Task<ReEncryptResponse> ReEncryptAsync(ReEncryptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ReplicateKey



        /// <summary>
        /// Replicates a multi-Region key into the specified Region. This operation creates a
        /// multi-Region replica key based on a multi-Region primary key in a different Region
        /// of the same Amazon Web Services partition. You can create multiple replicas of a primary
        /// key, but each must be in a different Region. To create a multi-Region primary key,
        /// use the <a>CreateKey</a> operation.
        /// 
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Multi-Region
        /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A <i>replica key</i> is a fully-functional KMS key that can be used independently
        /// of its primary and peer replica keys. A primary key and its replica keys share properties
        /// that make them interoperable. They have the same <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">key
        /// ID</a> and key material. They also have the same key spec, key usage, key material
        /// origin, and automatic key rotation status. KMS automatically synchronizes these shared
        /// properties among related multi-Region keys. All other properties of a replica key
        /// can differ, including its <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html">key
        /// policy</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">tags</a>,
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">aliases</a>,
        /// and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">key
        /// state</a>. KMS pricing and quotas for KMS keys apply to each primary key and replica
        /// key.
        /// </para>
        ///  
        /// <para>
        /// When this operation completes, the new replica key has a transient key state of <c>Creating</c>.
        /// This key state changes to <c>Enabled</c> (or <c>PendingImport</c>) after a few seconds
        /// when the process of creating the new replica key is complete. While the key state
        /// is <c>Creating</c>, you can manage key, but you cannot yet use it in cryptographic
        /// operations. If you are creating and using the replica key programmatically, retry
        /// on <c>KMSInvalidStateException</c> or call <c>DescribeKey</c> to check its <c>KeyState</c>
        /// value before using it. For details about the <c>Creating</c> key state, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You cannot create more than one replica of a primary key in any Region. If the Region
        /// already includes a replica of the key you're trying to replicate, <c>ReplicateKey</c>
        /// returns an <c>AlreadyExistsException</c> error. If the key state of the existing replica
        /// is <c>PendingDeletion</c>, you can cancel the scheduled key deletion (<a>CancelKeyDeletion</a>)
        /// or wait for the key to be deleted. The new replica key you create will have the same
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html#mrk-sync-properties">shared
        /// properties</a> as the original replica key.
        /// </para>
        ///  
        /// <para>
        /// The CloudTrail log of a <c>ReplicateKey</c> operation records a <c>ReplicateKey</c>
        /// operation in the primary key's Region and a <a>CreateKey</a> operation in the replica
        /// key's Region.
        /// </para>
        ///  
        /// <para>
        /// If you replicate a multi-Region primary key with imported key material, the replica
        /// key is created with no key material. You must import the same key material that you
        /// imported into the primary key.
        /// </para>
        ///  
        /// <para>
        /// To convert a replica key to a primary key, use the <a>UpdatePrimaryRegion</a> operation.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>ReplicateKey</c> uses different default values for the <c>KeyPolicy</c> and <c>Tags</c>
        /// parameters than those used in the KMS console. For details, see the parameter descriptions.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation to create a replica key
        /// in a different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>kms:ReplicateKey</c> on the primary key (in the primary key's Region). Include
        /// this permission in the primary key's key policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kms:CreateKey</c> in an IAM policy in the replica Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To use the <c>Tags</c> parameter, <c>kms:TagResource</c> in an IAM policy in the replica
        /// Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdatePrimaryRegion</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplicateKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReplicateKey service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.AlreadyExistsException">
        /// The request was rejected because it attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the specified policy is not syntactically or semantically
        /// correct.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ReplicateKey">REST API Reference for ReplicateKey Operation</seealso>
        Task<ReplicateKeyResponse> ReplicateKeyAsync(ReplicateKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RetireGrant


        /// <summary>
        /// Deletes a grant. Typically, you retire a grant when you no longer need its permissions.
        /// To identify the grant to retire, use a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">grant
        /// token</a>, or both the grant ID and a key identifier (key ID or key ARN) of the KMS
        /// key. The <a>CreateGrant</a> operation returns both values.
        /// 
        ///  
        /// <para>
        /// This operation can be called by the <i>retiring principal</i> for a grant, by the
        /// <i>grantee principal</i> if the grant allows the <c>RetireGrant</c> operation, and
        /// by the Amazon Web Services account in which the grant is created. It can also be called
        /// by principals to whom permission for retiring a grant is delegated.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. You can retire a grant on a KMS key in a different
        /// Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: Permission to retire a grant is determined primarily
        /// by the grant. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-delete.html">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="grantToken">Identifies the grant to be retired. You can use a grant token to identify a new grant even before it has achieved eventual consistency. Only the <a>CreateGrant</a> operation returns a grant token. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual consistency</a> in the <i>Key Management Service Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <c>GrantId</c> is not valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        Task<RetireGrantResponse> RetireGrantAsync(string grantToken, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes a grant. Typically, you retire a grant when you no longer need its permissions.
        /// To identify the grant to retire, use a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">grant
        /// token</a>, or both the grant ID and a key identifier (key ID or key ARN) of the KMS
        /// key. The <a>CreateGrant</a> operation returns both values.
        /// 
        ///  
        /// <para>
        /// This operation can be called by the <i>retiring principal</i> for a grant, by the
        /// <i>grantee principal</i> if the grant allows the <c>RetireGrant</c> operation, and
        /// by the Amazon Web Services account in which the grant is created. It can also be called
        /// by principals to whom permission for retiring a grant is delegated.
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. You can retire a grant on a KMS key in a different
        /// Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: Permission to retire a grant is determined primarily
        /// by the grant. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-delete.html">Retiring
        /// and revoking grants</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RevokeGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetireGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetireGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <c>GrantId</c> is not valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RetireGrant">REST API Reference for RetireGrant Operation</seealso>
        Task<RetireGrantResponse> RetireGrantAsync(RetireGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeGrant


        /// <summary>
        /// Deletes the specified grant. You revoke a grant to terminate the permissions that
        /// the grant allows. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-delete.html">Retiring
        /// and revoking grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// 
        ///  
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual
        /// consistency</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <c>KeyId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RevokeGrant</a>
        /// (key policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="grantId">Identifies the grant to revoke. To get the grant ID, use <a>CreateGrant</a>, <a>ListGrants</a>, or <a>ListRetirableGrants</a>.</param>
        /// <param name="keyId">A unique identifier for the KMS key associated with the grant. To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. Specify the key ID or key ARN of the KMS key. To specify a KMS key in a different Amazon Web Services account, you must use the key ARN. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <c>GrantId</c> is not valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        Task<RevokeGrantResponse> RevokeGrantAsync(string grantId, string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Deletes the specified grant. You revoke a grant to terminate the permissions that
        /// the grant allows. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-delete.html">Retiring
        /// and revoking grants</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// 
        ///  
        /// <para>
        /// When you create, retire, or revoke a grant, there might be a brief delay, usually
        /// less than five minutes, until the grant is available throughout KMS. This state is
        /// known as <i>eventual consistency</i>. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#terms-eventual-consistency">Eventual
        /// consistency</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. 
        /// </para>
        ///  
        /// <para>
        /// For detailed information about grants, including grant terminology, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html">Grants
        /// in KMS</a> in the <i> <i>Key Management Service Developer Guide</i> </i>. For examples
        /// of creating grants in several programming languages, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/example_kms_CreateGrant_section.html">Use
        /// CreateGrant with an Amazon Web Services SDK or CLI</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation on a KMS key in a different
        /// Amazon Web Services account, specify the key ARN in the value of the <c>KeyId</c>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RevokeGrant</a>
        /// (key policy).
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateGrant</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListRetirableGrants</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RetireGrant</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeGrant service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantIdException">
        /// The request was rejected because the specified <c>GrantId</c> is not valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RevokeGrant">REST API Reference for RevokeGrant Operation</seealso>
        Task<RevokeGrantResponse> RevokeGrantAsync(RevokeGrantRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RotateKeyOnDemand



        /// <summary>
        /// Immediately initiates rotation of the key material of the specified symmetric encryption
        /// KMS key.
        /// 
        ///  
        /// <para>
        /// You can perform <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-on-demand.html">on-demand
        /// rotation</a> of the key material in customer managed KMS keys, regardless of whether
        /// or not <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotating-keys-enable-disable.html">automatic
        /// key rotation</a> is enabled. On-demand rotations do not change existing automatic
        /// rotation schedules. For example, consider a KMS key that has automatic key rotation
        /// enabled with a rotation period of 730 days. If the key is scheduled to automatically
        /// rotate on April 14, 2024, and you perform an on-demand rotation on April 10, 2024,
        /// the key will automatically rotate, as scheduled, on April 14, 2024 and every 730 days
        /// thereafter.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can perform on-demand key rotation a <b>maximum of 10 times</b> per KMS key. You
        /// can use the KMS console to view the number of remaining on-demand rotations available
        /// for a KMS key.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use <a>GetKeyRotationStatus</a> to identify any in progress on-demand rotations.
        /// You can use <a>ListKeyRotations</a> to identify the date that completed on-demand
        /// rotations were performed. You can monitor rotation of the key material for your KMS
        /// keys in CloudTrail and Amazon CloudWatch.
        /// </para>
        ///  
        /// <para>
        /// On-demand key rotation is supported only on symmetric encryption KMS keys. You cannot
        /// perform on-demand rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">asymmetric
        /// KMS keys</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// KMS keys</a>, multi-Region KMS keys with <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">imported
        /// key material</a>, or KMS keys in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>. When you initiate on-demand key rotation on a symmetric encryption
        /// KMS key with imported key material, you must have already imported <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys-import-key-material.html">new
        /// key material</a> and that key material's state should be <c>PENDING_ROTATION</c>.
        /// Use the <c>ListKeyRotations</c> operation to check the state of all key materials
        /// associated with a KMS key. To perform on-demand rotation of a set of related <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html#multi-region-rotate">multi-Region
        /// keys</a>, invoke the on-demand rotation on the primary key.
        /// </para>
        ///  
        /// <para>
        /// You cannot initiate on-demand rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed KMS keys</a>. KMS always rotates the key material of Amazon Web
        /// Services managed keys every year. Rotation of <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
        /// Web Services owned KMS keys</a> is managed by the Amazon Web Services service that
        /// owns the key.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:RotateKeyOnDemand</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>EnableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKeyRotation</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetKeyRotationStatus</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ImportKeyMaterial</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListKeyRotations</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateKeyOnDemand service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RotateKeyOnDemand service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.ConflictException">
        /// The request was rejected because an automatic rotation of this key is currently in
        /// progress or scheduled to begin within the next 20 minutes.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/RotateKeyOnDemand">REST API Reference for RotateKeyOnDemand Operation</seealso>
        Task<RotateKeyOnDemandResponse> RotateKeyOnDemandAsync(RotateKeyOnDemandRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ScheduleKeyDeletion


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <c>PendingDeletion</c> and the key can't be
        /// used in any cryptographic operations. It remains in this state for the duration of
        /// the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">multi-Region
        /// replica key</a>, or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#import-delete-key">asymmetric
        /// or HMAC KMS key with imported key material</a>.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <c>PendingReplicaDeletion</c> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <c>PendingDeletion</c>
        /// and its waiting period (<c>PendingWindowInDays</c>) begins. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#deleting-mrks">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#delete-cmk-keystore">deletes
        /// a KMS key from an CloudHSM key store</a>, it makes a best effort to delete the associated
        /// key material from the associated CloudHSM cluster. However, you might need to manually
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups. <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#delete-xks-key">Deleting
        /// a KMS key from an external key store</a> has no effect on the associated external
        /// key. However, for both types of custom key stores, deleting a KMS key is destructive
        /// and irreversible. You cannot decrypt ciphertext encrypted under the KMS key by using
        /// only its associated external key or CloudHSM key. Also, you cannot recreate a KMS
        /// key in an external key store by creating a new KMS key with the same key material.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the KMS key to delete. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <c>PendingDeletion</c> and the key can't be
        /// used in any cryptographic operations. It remains in this state for the duration of
        /// the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">multi-Region
        /// replica key</a>, or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#import-delete-key">asymmetric
        /// or HMAC KMS key with imported key material</a>.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <c>PendingReplicaDeletion</c> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <c>PendingDeletion</c>
        /// and its waiting period (<c>PendingWindowInDays</c>) begins. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#deleting-mrks">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#delete-cmk-keystore">deletes
        /// a KMS key from an CloudHSM key store</a>, it makes a best effort to delete the associated
        /// key material from the associated CloudHSM cluster. However, you might need to manually
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups. <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#delete-xks-key">Deleting
        /// a KMS key from an external key store</a> has no effect on the associated external
        /// key. However, for both types of custom key stores, deleting a KMS key is destructive
        /// and irreversible. You cannot decrypt ciphertext encrypted under the KMS key by using
        /// only its associated external key or CloudHSM key. Also, you cannot recreate a KMS
        /// key in an external key store by creating a new KMS key with the same key material.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">The unique identifier of the KMS key to delete. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="pendingWindowInDays">The waiting period, specified in number of days. After the waiting period ends, KMS deletes the KMS key. If the KMS key is a multi-Region primary key with replica keys, the waiting period begins when the last of its replica keys is deleted. Otherwise, the waiting period begins immediately. This value is optional. If you include a value, it must be between 7 and 30, inclusive. If you do not include a value, it defaults to 30. You can use the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/conditions-kms.html#conditions-kms-schedule-key-deletion-pending-window-in-days"> <c>kms:ScheduleKeyDeletionPendingWindowInDays</c> </a> condition key to further constrain the values that principals can specify in the <c>PendingWindowInDays</c> parameter.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(string keyId, int? pendingWindowInDays, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Schedules the deletion of a KMS key. By default, KMS applies a waiting period of 30
        /// days, but you can specify a waiting period of 7-30 days. When this operation is successful,
        /// the key state of the KMS key changes to <c>PendingDeletion</c> and the key can't be
        /// used in any cryptographic operations. It remains in this state for the duration of
        /// the waiting period. Before the waiting period ends, you can use <a>CancelKeyDeletion</a>
        /// to cancel the deletion of the KMS key. After the waiting period ends, KMS deletes
        /// the KMS key, its key material, and all KMS data associated with it, including all
        /// aliases that refer to it.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a KMS key is a destructive and potentially dangerous operation. When a KMS
        /// key is deleted, all data that was encrypted under the KMS key is unrecoverable. (The
        /// only exception is a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-delete.html">multi-Region
        /// replica key</a>, or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#import-delete-key">asymmetric
        /// or HMAC KMS key with imported key material</a>.) To prevent the use of a KMS key without
        /// deleting it, use <a>DisableKey</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// You can schedule the deletion of a multi-Region primary key and its replica keys at
        /// any time. However, KMS will not delete a multi-Region primary key with existing replica
        /// keys. If you schedule the deletion of a primary key with replicas, its key state changes
        /// to <c>PendingReplicaDeletion</c> and it cannot be replicated or used in cryptographic
        /// operations. This status can continue indefinitely. When the last of its replicas keys
        /// is deleted (not just scheduled), the key state of the primary key changes to <c>PendingDeletion</c>
        /// and its waiting period (<c>PendingWindowInDays</c>) begins. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#deleting-mrks">Deleting
        /// multi-Region keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#delete-cmk-keystore">deletes
        /// a KMS key from an CloudHSM key store</a>, it makes a best effort to delete the associated
        /// key material from the associated CloudHSM cluster. However, you might need to manually
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
        /// the orphaned key material</a> from the cluster and its backups. <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html#delete-xks-key">Deleting
        /// a KMS key from an external key store</a> has no effect on the associated external
        /// key. However, for both types of custom key stores, deleting a KMS key is destructive
        /// and irreversible. You cannot decrypt ciphertext encrypted under the KMS key by using
        /// only its associated external key or CloudHSM key. Also, you cannot recreate a KMS
        /// key in an external key store by creating a new KMS key with the same key material.
        /// </para>
        ///  
        /// <para>
        /// For more information about scheduling a KMS key for deletion, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/deleting-keys.html">Deleting
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: kms:ScheduleKeyDeletion (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CancelKeyDeletion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisableKey</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ScheduleKeyDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ScheduleKeyDeletion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/ScheduleKeyDeletion">REST API Reference for ScheduleKeyDeletion Operation</seealso>
        Task<ScheduleKeyDeletionResponse> ScheduleKeyDeletionAsync(ScheduleKeyDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Sign



        /// <summary>
        /// Creates a <a href="https://en.wikipedia.org/wiki/Digital_signature">digital signature</a>
        /// for a message or message digest by using the private key in an asymmetric signing
        /// KMS key. To verify the signature, use the <a>Verify</a> operation, or use the public
        /// key in the same asymmetric KMS key outside of KMS. For information about asymmetric
        /// KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Digital signatures are generated and verified by using asymmetric key pair, such as
        /// an RSA, ECC, or ML-DSA pair that is represented by an asymmetric KMS key. The key
        /// owner (or an authorized user) uses their private key to sign a message. Anyone with
        /// the public key can verify that the message was signed with that particular private
        /// key and that the message hasn't changed since it was signed. 
        /// </para>
        ///  
        /// <para>
        /// To use the <c>Sign</c> operation, provide the following information:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use the <c>KeyId</c> parameter to identify an asymmetric KMS key with a <c>KeyUsage</c>
        /// value of <c>SIGN_VERIFY</c>. To get the <c>KeyUsage</c> value of a KMS key, use the
        /// <a>DescribeKey</a> operation. The caller must have <c>kms:Sign</c> permission on the
        /// KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use the <c>Message</c> parameter to specify the message or message digest to sign.
        /// You can submit messages of up to 4096 bytes. To sign a larger message, generate a
        /// hash digest of the message, and then provide the hash digest in the <c>Message</c>
        /// parameter. To indicate whether the message is a full message, a digest, or an ML-DSA
        /// EXTERNAL_MU, use the <c>MessageType</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Choose a signing algorithm that is compatible with the KMS key. 
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// When signing a message, be sure to record the KMS key and the signing algorithm. This
        /// information is required to verify the signature.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// Best practices recommend that you limit the time during which any signature is effective.
        /// This deters an attack where the actor uses a signed message to establish validity
        /// repeatedly or long after the message is superseded. Signatures do not include a timestamp,
        /// but you can include a timestamp in the signed message to help you detect when its
        /// time to refresh the signature. 
        /// </para>
        ///  </note> 
        /// <para>
        /// To verify the signature that this operation generates, use the <a>Verify</a> operation.
        /// Or use the <a>GetPublicKey</a> operation to download the public key and then use the
        /// public key to verify the signature outside of KMS. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Sign</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>Verify</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Sign service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Sign service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Sign">REST API Reference for Sign Operation</seealso>
        Task<SignResponse> SignAsync(SignRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or edits tags on a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed key</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each tag consists of a tag key and a tag value, both of which are case-sensitive strings.
        /// The tag value can be an empty (null) string. To add a tag, specify a new tag key and
        /// a tag value. To edit a tag, specify an existing tag key and a new tag value.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation to tag a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed key</a>, but you cannot tag an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon
        /// Web Services managed key</a>, an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-owned-key">Amazon
        /// Web Services owned key</a>, a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
        /// key store</a>, or an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html">alias</a>.
        /// </para>
        ///  
        /// <para>
        /// You can also add tags to a KMS key while creating it (<a>CreateKey</a>) or replicating
        /// it (<a>ReplicateKey</a>).
        /// </para>
        ///  
        /// <para>
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>. For general information about tags, including the format and syntax, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:TagResource</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UntagResource</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Deletes tags from a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer
        /// managed key</a>. To delete a tag, specify the tag key and the KMS key.
        /// 
        ///  <note> 
        /// <para>
        /// Tagging or untagging a KMS key can allow or deny permission to the KMS key. For details,
        /// see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When it succeeds, the <c>UntagResource</c> operation doesn't return any output. Also,
        /// if the specified tag key isn't found on the KMS key, it doesn't throw an exception
        /// or return a response. To confirm that the operation worked, use the <a>ListResourceTags</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For information about using tags in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/tagging-keys.html">Tagging
        /// keys</a>. For general information about tags, including the format and syntax, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging Amazon
        /// Web Services resources</a> in the <i>Amazon Web Services General Reference</i>. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UntagResource</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListResourceTags</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>TagResource</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.TagException">
        /// The request was rejected because one or more tags are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAlias


        /// <summary>
        /// Associates an existing KMS alias with a different KMS key. Each alias is associated
        /// with only one KMS key at a time, although a KMS key can have multiple aliases. The
        /// alias and the KMS key must be in the same Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The current and new KMS key must be the same type (both symmetric or both asymmetric
        /// or both HMAC), and they must have the same key usage. This restriction prevents errors
        /// in code that uses aliases. If you must assign an alias to a different type of KMS
        /// key, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <c>UpdateAlias</c> to change an alias name. To change an alias name,
        /// use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create a
        /// new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a KMS key, you can create, update, and delete
        /// the aliases of a KMS key without affecting the KMS key. Also, aliases do not appear
        /// in the response from the <a>DescribeKey</a> operation. To get the aliases of all KMS
        /// keys in the account, use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the current KMS key (key policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the new KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
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
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="aliasName">Identifies the alias that is changing its KMS key. This value must begin with <c>alias/</c> followed by the alias name, such as <c>alias/ExampleAlias</c>. You cannot use <c>UpdateAlias</c> to change the alias name. <important> Do not include confidential or sensitive information in this field. This field may be displayed in plaintext in CloudTrail logs and other output. </important></param>
        /// <param name="targetKeyId">Identifies the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-mgn-key">customer managed key</a> to associate with the alias. You don't have permission to associate an alias with an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-key">Amazon Web Services managed key</a>. The KMS key must be in the same Amazon Web Services account and Region as the alias. Also, the new target KMS key must be the same type as the current target KMS key (both symmetric or both asymmetric or both HMAC) and they must have the same key usage.  Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>. To verify that the alias is mapped to the correct KMS key, use <a>ListAliases</a>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        Task<UpdateAliasResponse> UpdateAliasAsync(string aliasName, string targetKeyId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Associates an existing KMS alias with a different KMS key. Each alias is associated
        /// with only one KMS key at a time, although a KMS key can have multiple aliases. The
        /// alias and the KMS key must be in the same Amazon Web Services account and Region.
        /// 
        ///  <note> 
        /// <para>
        /// Adding, deleting, or updating an alias can allow or deny permission to the KMS key.
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/abac.html">ABAC
        /// for KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The current and new KMS key must be the same type (both symmetric or both asymmetric
        /// or both HMAC), and they must have the same key usage. This restriction prevents errors
        /// in code that uses aliases. If you must assign an alias to a different type of KMS
        /// key, use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create
        /// a new alias.
        /// </para>
        ///  
        /// <para>
        /// You cannot use <c>UpdateAlias</c> to change an alias name. To change an alias name,
        /// use <a>DeleteAlias</a> to delete the old alias and <a>CreateAlias</a> to create a
        /// new alias.
        /// </para>
        ///  
        /// <para>
        /// Because an alias is not a property of a KMS key, you can create, update, and delete
        /// the aliases of a KMS key without affecting the KMS key. Also, aliases do not appear
        /// in the response from the <a>DescribeKey</a> operation. To get the aliases of all KMS
        /// keys in the account, use the <a>ListAliases</a> operation. 
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the alias (IAM policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the current KMS key (key policy).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateAlias</a>
        /// on the new KMS key (key policy).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-alias.html#alias-access">Controlling
        /// access to aliases</a> in the <i>Key Management Service Developer Guide</i>.
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
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAlias service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.LimitExceededException">
        /// The request was rejected because a length constraint or quota was exceeded. For more
        /// information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/limits.html">Quotas</a>
        /// in the <i>Key Management Service Developer Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCustomKeyStore



        /// <summary>
        /// Changes the properties of a custom key store. You can use this operation to change
        /// the properties of an CloudHSM key store or an external key store.
        /// 
        ///  
        /// <para>
        /// Use the required <c>CustomKeyStoreId</c> parameter to identify the custom key store.
        /// Use the remaining optional parameters to change its properties. This operation does
        /// not return any property values. To verify the updated property values, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        ///  This operation is part of the custom key stores feature in KMS, which combines the
        /// convenience and extensive integration of KMS with the isolation and control of a key
        /// store that you own and manage.
        /// </para>
        ///  <important> 
        /// <para>
        /// When updating the properties of an external key store, verify that the updated settings
        /// connect your key store, via the external key store proxy, to the same external key
        /// manager as the previous settings, or to a backup or snapshot of the external key manager
        /// with the same cryptographic keys. If the updated connection settings fail, you can
        /// fix them and retry, although an extended delay might disrupt Amazon Web Services services.
        /// However, if KMS permanently loses its access to cryptographic keys, ciphertext encrypted
        /// under those keys is unrecoverable.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// For external key stores:
        /// </para>
        ///  
        /// <para>
        /// Some external key managers provide a simpler method for updating an external key store.
        /// For details, see your external key manager documentation.
        /// </para>
        ///  
        /// <para>
        /// When updating an external key store in the KMS console, you can upload a JSON-based
        /// proxy configuration file with the desired values. You cannot upload the proxy configuration
        /// file to the <c>UpdateCustomKeyStore</c> operation. However, you can use the file to
        /// help you determine the correct values for the <c>UpdateCustomKeyStore</c> parameters.
        /// </para>
        ///  </note> 
        /// <para>
        /// For an CloudHSM key store, you can use this operation to change the custom key store
        /// friendly name (<c>NewCustomKeyStoreName</c>), to tell KMS about a change to the <c>kmsuser</c>
        /// crypto user password (<c>KeyStorePassword</c>), or to associate the custom key store
        /// with a different, but related, CloudHSM cluster (<c>CloudHsmClusterId</c>). To update
        /// any property of an CloudHSM key store, the <c>ConnectionState</c> of the CloudHSM
        /// key store must be <c>DISCONNECTED</c>. 
        /// </para>
        ///  
        /// <para>
        /// For an external key store, you can use this operation to change the custom key store
        /// friendly name (<c>NewCustomKeyStoreName</c>), or to tell KMS about a change to the
        /// external key store proxy authentication credentials (<c>XksProxyAuthenticationCredential</c>),
        /// connection method (<c>XksProxyConnectivity</c>), external proxy endpoint (<c>XksProxyUriEndpoint</c>)
        /// and path (<c>XksProxyUriPath</c>). For external key stores with an <c>XksProxyConnectivity</c>
        /// of <c>VPC_ENDPOINT_SERVICE</c>, you can also update the Amazon VPC endpoint service
        /// name (<c>XksProxyVpcEndpointServiceName</c>). To update most properties of an external
        /// key store, the <c>ConnectionState</c> of the external key store must be <c>DISCONNECTED</c>.
        /// However, you can update the <c>CustomKeyStoreName</c>, <c>XksProxyAuthenticationCredential</c>,
        /// and <c>XksProxyUriPath</c> of an external key store when it is in the CONNECTED or
        /// DISCONNECTED state. 
        /// </para>
        ///  
        /// <para>
        /// If your update requires a <c>DISCONNECTED</c> state, before using <c>UpdateCustomKeyStore</c>,
        /// use the <a>DisconnectCustomKeyStore</a> operation to disconnect the custom key store.
        /// After the <c>UpdateCustomKeyStore</c> operation completes, use the <a>ConnectCustomKeyStore</a>
        /// to reconnect the custom key store. To find the <c>ConnectionState</c> of the custom
        /// key store, use the <a>DescribeCustomKeyStores</a> operation. 
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        /// Before updating the custom key store, verify that the new values allow KMS to connect
        /// the custom key store to its backing key store. For example, before you change the
        /// <c>XksProxyUriPath</c> value, verify that the external key store proxy is reachable
        /// at the new path.
        /// </para>
        ///  
        /// <para>
        /// If the operation succeeds, it returns a JSON object with no properties.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
        /// in a different Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateCustomKeyStore</a>
        /// (IAM policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ConnectCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteCustomKeyStore</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeCustomKeyStores</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DisconnectCustomKeyStore</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomKeyStore service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomKeyStore service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterInvalidConfigurationException">
        /// The request was rejected because the associated CloudHSM cluster did not meet the
        /// configuration requirements for an CloudHSM key store.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The CloudHSM cluster must be configured with private subnets in at least two different
        /// Availability Zones in the Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">security
        /// group for the cluster</a> (cloudhsm-cluster-<i>&lt;cluster-id&gt;</i>-sg) must include
        /// inbound rules and outbound rules that allow TCP traffic on ports 2223-2225. The <b>Source</b>
        /// in the inbound rules and the <b>Destination</b> in the outbound rules must match the
        /// security group ID. These rules are set by default when you create the CloudHSM cluster.
        /// Do not delete or change them. To get information about a particular security group,
        /// use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeSecurityGroups.html">DescribeSecurityGroups</a>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The CloudHSM cluster must contain at least as many HSMs as the operation requires.
        /// To add HSMs, use the CloudHSM <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For the <a>CreateCustomKeyStore</a>, <a>UpdateCustomKeyStore</a>, and <a>CreateKey</a>
        /// operations, the CloudHSM cluster must have at least two active HSMs, each in a different
        /// Availability Zone. For the <a>ConnectCustomKeyStore</a> operation, the CloudHSM must
        /// contain at least one active HSM.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For information about the requirements for an CloudHSM cluster that is associated
        /// with an CloudHSM key store, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
        /// the Prerequisites</a> in the <i>Key Management Service Developer Guide</i>. For information
        /// about creating a private subnet for an CloudHSM cluster, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/create-subnets.html">Create
        /// a Private Subnet</a> in the <i>CloudHSM User Guide</i>. For information about cluster
        /// security groups, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/configure-sg.html">Configure
        /// a Default Security Group</a> in the <i> <i>CloudHSM User Guide</i> </i>. 
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotActiveException">
        /// The request was rejected because the CloudHSM cluster associated with the CloudHSM
        /// key store is not active. Initialize and activate the cluster and try the command again.
        /// For detailed instructions, see <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/getting-started.html">Getting
        /// Started</a> in the <i>CloudHSM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotFoundException">
        /// The request was rejected because KMS cannot find the CloudHSM cluster with the specified
        /// cluster ID. Retry the request with a different cluster ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CloudHsmClusterNotRelatedException">
        /// The request was rejected because the specified CloudHSM cluster has a different cluster
        /// certificate than the original cluster. You cannot use the operation to specify an
        /// unrelated cluster for an CloudHSM key store.
        /// 
        ///  
        /// <para>
        /// Specify an CloudHSM cluster that shares a backup history with the original cluster.
        /// This includes clusters that were created from a backup of the current cluster, and
        /// clusters that were created from the same backup that produced the current cluster.
        /// </para>
        ///  
        /// <para>
        /// CloudHSM clusters that share a backup history have the same cluster certificate. To
        /// view the cluster certificate of an CloudHSM cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreInvalidStateException">
        /// The request was rejected because of the <c>ConnectionState</c> of the custom key store.
        /// To get the <c>ConnectionState</c> of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// 
        ///  
        /// <para>
        /// This exception is thrown under the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You requested the <a>ConnectCustomKeyStore</a> operation on a custom key store with
        /// a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>FAILED</c>. This operation
        /// is valid for all other <c>ConnectionState</c> values. To reconnect a custom key store
        /// in a <c>FAILED</c> state, disconnect it (<a>DisconnectCustomKeyStore</a>), then connect
        /// it (<c>ConnectCustomKeyStore</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>CreateKey</a> operation in a custom key store that is not connected.
        /// This operations is valid only when the custom key store <c>ConnectionState</c> is
        /// <c>CONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>DisconnectCustomKeyStore</a> operation on a custom key store
        /// with a <c>ConnectionState</c> of <c>DISCONNECTING</c> or <c>DISCONNECTED</c>. This
        /// operation is valid for all other <c>ConnectionState</c> values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>UpdateCustomKeyStore</a> or <a>DeleteCustomKeyStore</a> operation
        /// on a custom key store that is not disconnected. This operation is valid only when
        /// the custom key store <c>ConnectionState</c> is <c>DISCONNECTED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You requested the <a>GenerateRandom</a> operation in an CloudHSM key store that is
        /// not connected. This operation is valid only when the CloudHSM key store <c>ConnectionState</c>
        /// is <c>CONNECTED</c>. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNameInUseException">
        /// The request was rejected because the specified custom key store name is already assigned
        /// to another custom key store in the account. Try again with a custom key store name
        /// that is unique in the account.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.CustomKeyStoreNotFoundException">
        /// The request was rejected because KMS cannot find a custom key store with the specified
        /// key store name or ID.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyIncorrectAuthenticationCredentialException">
        /// The request was rejected because the proxy credentials failed to authenticate to the
        /// specified external key store proxy. The specified external key store proxy rejected
        /// a status request from KMS due to invalid credentials. This can indicate an error in
        /// the credentials or in the identification of the external key store proxy.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyInvalidConfigurationException">
        /// The request was rejected because the external key store proxy is not configured correctly.
        /// To identify the cause, see the error message that accompanies the exception.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyInvalidResponseException">
        /// KMS cannot interpret the response it received from the external key store proxy. The
        /// problem might be a poorly constructed response, but it could also be a transient network
        /// issue. If you see this error repeatedly, report it to the proxy vendor.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyUriEndpointInUseException">
        /// The request was rejected because the <c>XksProxyUriEndpoint</c> is already associated
        /// with another external key store in this Amazon Web Services Region. To identify the
        /// cause, see the error message that accompanies the exception.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyUriInUseException">
        /// The request was rejected because the concatenation of the <c>XksProxyUriEndpoint</c>
        /// and <c>XksProxyUriPath</c> is already associated with another external key store in
        /// this Amazon Web Services Region. Each external key store in a Region must use a unique
        /// external key store proxy API address.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyUriUnreachableException">
        /// KMS was unable to reach the specified <c>XksProxyUriPath</c>. The path must be reachable
        /// before you create the external key store or update its settings.
        /// 
        ///  
        /// <para>
        /// This exception is also thrown when the external key store proxy response to a <c>GetHealthStatus</c>
        /// request indicates that all external key manager instances are unavailable.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyVpcEndpointServiceInUseException">
        /// The request was rejected because the specified Amazon VPC endpoint service is already
        /// associated with another external key store in this Amazon Web Services Region. Each
        /// external key store in a Region must use a different Amazon VPC endpoint service.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyVpcEndpointServiceInvalidConfigurationException">
        /// The request was rejected because the Amazon VPC endpoint service configuration does
        /// not fulfill the requirements for an external key store. To identify the cause, see
        /// the error message that accompanies the exception and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/vpc-connectivity.html#xks-vpc-requirements">review
        /// the requirements</a> for Amazon VPC endpoint service connectivity for an external
        /// key store.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.XksProxyVpcEndpointServiceNotFoundException">
        /// The request was rejected because KMS could not find the specified VPC endpoint service.
        /// Use <a>DescribeCustomKeyStores</a> to verify the VPC endpoint service name for the
        /// external key store. Also, confirm that the <c>Allow principals</c> list for the VPC
        /// endpoint service includes the KMS service principal for the Region, such as <c>cks.kms.us-east-1.amazonaws.com</c>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateCustomKeyStore">REST API Reference for UpdateCustomKeyStore Operation</seealso>
        Task<UpdateCustomKeyStoreResponse> UpdateCustomKeyStoreAsync(UpdateCustomKeyStoreRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateKeyDescription


        /// <summary>
        /// Updates the description of a KMS key. To see the description of a KMS key, use <a>DescribeKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateKeyDescription</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="keyId">Updates the description of the specified KMS key. Specify the key ID or key ARN of the KMS key. For example: <ul> <li> Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> <li> Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>  </li> </ul> To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.</param>
        /// <param name="description">New description for the KMS key. <important> Do not include confidential or sensitive information in this field. This field may be displayed in plaintext in CloudTrail logs and other output. </important></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(string keyId, string description, System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Updates the description of a KMS key. To see the description of a KMS key, use <a>DescribeKey</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot perform this operation on a KMS key in a
        /// different Amazon Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateKeyDescription</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeKey</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateKeyDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateKeyDescription service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdateKeyDescription">REST API Reference for UpdateKeyDescription Operation</seealso>
        Task<UpdateKeyDescriptionResponse> UpdateKeyDescriptionAsync(UpdateKeyDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePrimaryRegion



        /// <summary>
        /// Changes the primary key of a multi-Region key. 
        /// 
        ///  
        /// <para>
        /// This operation changes the replica key in the specified Region to a primary key and
        /// changes the former primary key to a replica key. For example, suppose you have a primary
        /// key in <c>us-east-1</c> and a replica key in <c>eu-west-2</c>. If you run <c>UpdatePrimaryRegion</c>
        /// with a <c>PrimaryRegion</c> value of <c>eu-west-2</c>, the primary key is now the
        /// key in <c>eu-west-2</c>, and the key in <c>us-east-1</c> becomes a replica key. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-update.html">Change
        /// the primary key in a set of multi-Region keys</a> in the <i>Key Management Service
        /// Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation supports <i>multi-Region keys</i>, an KMS feature that lets you create
        /// multiple interoperable KMS keys in different Amazon Web Services Regions. Because
        /// these KMS keys have the same key ID, key material, and other metadata, you can use
        /// them interchangeably to encrypt data in one Amazon Web Services Region and decrypt
        /// it in a different Amazon Web Services Region without re-encrypting the data or making
        /// a cross-Region call. For more information about multi-Region keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/multi-region-keys-overview.html">Multi-Region
        /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <i>primary key</i> of a multi-Region key is the source for properties that are
        /// always shared by primary and replica keys, including the key material, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id-key-id">key
        /// ID</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-spec">key
        /// spec</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-usage">key
        /// usage</a>, <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-origin">key
        /// material origin</a>, and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/rotate-keys.html">automatic
        /// key rotation</a>. It's the only key that can be replicated. You cannot <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_ScheduleKeyDeletion.html">delete
        /// the primary key</a> until all replica keys are deleted.
        /// </para>
        ///  
        /// <para>
        /// The key ID and primary Region that you specify uniquely identify the replica key that
        /// will become the primary key. The primary Region must already have a replica key. This
        /// operation does not create a KMS key in the specified Region. To find the replica keys,
        /// use the <a>DescribeKey</a> operation on the primary key or any replica key. To create
        /// a replica key, use the <a>ReplicateKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// You can run this operation while using the affected multi-Region keys in cryptographic
        /// operations. This operation should not delay, interrupt, or cause failures in cryptographic
        /// operations. 
        /// </para>
        ///  
        /// <para>
        /// Even after this operation completes, the process of updating the primary Region might
        /// still be in progress for a few more seconds. Operations such as <c>DescribeKey</c>
        /// might display both the old and new primary keys as replicas. The old and new primary
        /// keys have a transient key state of <c>Updating</c>. The original key state is restored
        /// when the update is complete. While the key state is <c>Updating</c>, you can use the
        /// keys in cryptographic operations, but you cannot replicate the new primary key or
        /// perform certain management operations, such as enabling or disabling these keys. For
        /// details about the <c>Updating</c> key state, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This operation does not return any output. To verify that primary key is changed,
        /// use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: No. You cannot use this operation in a different Amazon
        /// Web Services account. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>kms:UpdatePrimaryRegion</c> on the current primary key (in the primary key's Region).
        /// Include this permission primary key's key policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kms:UpdatePrimaryRegion</c> on the current replica key (in the replica key's Region).
        /// Include this permission in the replica key's key policy.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateKey</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ReplicateKey</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrimaryRegion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrimaryRegion service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidArnException">
        /// The request was rejected because a specified ARN, or an ARN in a key policy, is not
        /// valid.
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
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.UnsupportedOperationException">
        /// The request was rejected because a specified parameter is not supported or a specified
        /// resource is not valid for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/UpdatePrimaryRegion">REST API Reference for UpdatePrimaryRegion Operation</seealso>
        Task<UpdatePrimaryRegionResponse> UpdatePrimaryRegionAsync(UpdatePrimaryRegionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Verify



        /// <summary>
        /// Verifies a digital signature that was generated by the <a>Sign</a> operation. 
        /// 
        ///   
        /// <para>
        /// Verification confirms that an authorized user signed the message with the specified
        /// KMS key and signing algorithm, and the message hasn't changed since it was signed.
        /// If the signature is verified, the value of the <c>SignatureValid</c> field in the
        /// response is <c>True</c>. If the signature verification fails, the <c>Verify</c> operation
        /// fails with an <c>KMSInvalidSignatureException</c> exception.
        /// </para>
        ///  
        /// <para>
        /// A digital signature is generated by using the private key in an asymmetric KMS key.
        /// The signature is verified by using the public key in the same asymmetric KMS key.
        /// For information about asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Asymmetric
        /// KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use the <c>Verify</c> operation, specify the same asymmetric KMS key, message,
        /// and signing algorithm that were used to produce the signature. The message type does
        /// not need to be the same as the one used for signing, but it must indicate whether
        /// the value of the <c>Message</c> parameter should be hashed as part of the verification
        /// process.
        /// </para>
        ///  
        /// <para>
        /// You can also verify the digital signature by using the public key of the KMS key outside
        /// of KMS. Use the <a>GetPublicKey</a> operation to download the public key in the asymmetric
        /// KMS key and then use the public key to verify the signature outside of KMS. The advantage
        /// of using the <c>Verify</c> operation is that it is performed within KMS. As a result,
        /// it's easy to call, the operation is performed within the FIPS boundary, it is logged
        /// in CloudTrail, and you can use key policy and IAM policy to determine who is authorized
        /// to use the KMS key to verify signatures.
        /// </para>
        ///  
        /// <para>
        /// To verify a signature outside of KMS with an SM2 public key (China Regions only),
        /// you must specify the distinguishing ID. By default, KMS uses <c>1234567812345678</c>
        /// as the distinguishing ID. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/offline-operations.html#key-spec-sm-offline-verification">Offline
        /// verification with SM2 key pairs</a>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Verify</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>Sign</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Verify service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Verify service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DependencyTimeoutException">
        /// The system timed out while trying to fulfill the request. You can retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidSignatureException">
        /// The request was rejected because the signature verification failed. Signature verification
        /// fails when it cannot confirm that signature was produced by signing the specified
        /// message with the specified KMS key and signing algorithm.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/Verify">REST API Reference for Verify Operation</seealso>
        Task<VerifyResponse> VerifyAsync(VerifyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VerifyMac



        /// <summary>
        /// Verifies the hash-based message authentication code (HMAC) for a specified message,
        /// HMAC KMS key, and MAC algorithm. To verify the HMAC, <c>VerifyMac</c> computes an
        /// HMAC using the message, HMAC KMS key, and MAC algorithm that you specify, and compares
        /// the computed HMAC to the HMAC that you specify. If the HMACs are identical, the verification
        /// succeeds; otherwise, it fails. Verification indicates that the message hasn't changed
        /// since the HMAC was calculated, and the specified key was used to generate and verify
        /// the HMAC.
        /// 
        ///  
        /// <para>
        /// HMAC KMS keys and the HMAC algorithms that KMS uses conform to industry standards
        /// defined in <a href="https://datatracker.ietf.org/doc/html/rfc2104">RFC 2104</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of KMS support for HMAC KMS keys. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/hmac.html">HMAC
        /// keys in KMS</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The KMS key that you use for this operation must be in a compatible key state. For
        /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
        /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
        /// <c>KeyId</c> parameter. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:VerifyMac</a>
        /// (key policy)
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b>: <a>GenerateMac</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
        /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
        /// eventual consistency</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyMac service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyMac service method, as returned by KeyManagementService.</returns>
        /// <exception cref="Amazon.KeyManagementService.Model.DisabledException">
        /// The request was rejected because the specified KMS key is not enabled.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.DryRunOperationException">
        /// The request was rejected because the DryRun parameter was specified.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidGrantTokenException">
        /// The request was rejected because the specified grant token is not valid.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.InvalidKeyUsageException">
        /// The request was rejected for one of the following reasons: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The <c>KeyUsage</c> value of the KMS key is incompatible with the API operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The encryption algorithm or signing algorithm specified for the operation is incompatible
        /// with the type of key material in the KMS key <c>(KeySpec</c>).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For encrypting, decrypting, re-encrypting, and generating data keys, the <c>KeyUsage</c>
        /// must be <c>ENCRYPT_DECRYPT</c>. For signing and verifying messages, the <c>KeyUsage</c>
        /// must be <c>SIGN_VERIFY</c>. For generating and verifying message authentication codes
        /// (MACs), the <c>KeyUsage</c> must be <c>GENERATE_VERIFY_MAC</c>. For deriving key agreement
        /// secrets, the <c>KeyUsage</c> must be <c>KEY_AGREEMENT</c>. To find the <c>KeyUsage</c>
        /// of a KMS key, use the <a>DescribeKey</a> operation.
        /// </para>
        ///  
        /// <para>
        /// To find the encryption or signing algorithms supported for a particular KMS key, use
        /// the <a>DescribeKey</a> operation.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KeyUnavailableException">
        /// The request was rejected because the specified KMS key was not available. You can
        /// retry the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInternalException">
        /// The request was rejected because an internal exception occurred. The request can be
        /// retried.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidMacException">
        /// The request was rejected because the HMAC verification failed. HMAC verification fails
        /// when the HMAC computed by using the specified message, HMAC KMS key, and MAC algorithm
        /// does not match the HMAC specified in the request.
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.KMSInvalidStateException">
        /// The request was rejected because the state of the specified resource is not valid
        /// for this request.
        /// 
        ///  
        /// <para>
        /// This exceptions means one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The key state of the KMS key is not compatible with the operation. 
        /// </para>
        ///  
        /// <para>
        /// To find the key state, use the <a>DescribeKey</a> operation. For more information
        /// about which key states are compatible with each KMS operation, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
        /// states of KMS keys</a> in the <i> <i>Key Management Service Developer Guide</i> </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For cryptographic operations on KMS keys in custom key stores, this exception represents
        /// a general failure with many possible causes. To identify the cause, see the error
        /// message that accompanies the exception.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.KeyManagementService.Model.NotFoundException">
        /// The request was rejected because the specified entity or resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/kms-2014-11-01/VerifyMac">REST API Reference for VerifyMac Operation</seealso>
        Task<VerifyMacResponse> VerifyMacAsync(VerifyMacRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonKeyManagementServiceConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonKeyManagementServiceConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonKeyManagementServiceConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonKeyManagementServiceConfig to create AmazonKeyManagementServiceClient");
            }

            return awsCredentials == null ? 
                    new AmazonKeyManagementServiceClient(serviceClientConfig) :
                    new AmazonKeyManagementServiceClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}