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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ConnectCustomKeyStore operation.
    /// Connects or reconnects a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a> to its backing key store. For an CloudHSM key store, <code>ConnectCustomKeyStore</code>
    /// connects the key store to its associated CloudHSM cluster. For an external key store,
    /// <code>ConnectCustomKeyStore</code> connects the key store to the external key store
    /// proxy that communicates with your external key manager.
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
    ///  This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key stores</a> feature in KMS, which combines the convenience and extensive integration
    /// of KMS with the isolation and control of a key store that you own and manage.
    /// </para>
    ///  
    /// <para>
    /// The <code>ConnectCustomKeyStore</code> operation might fail for various reasons. To
    /// find the reason, use the <a>DescribeCustomKeyStores</a> operation and see the <code>ConnectionErrorCode</code>
    /// in the response. For help interpreting the <code>ConnectionErrorCode</code>, see <a>CustomKeyStoresListEntry</a>.
    /// </para>
    ///  
    /// <para>
    /// To fix the failure, use the <a>DisconnectCustomKeyStore</a> operation to disconnect
    /// the custom key store, correct the error, use the <a>UpdateCustomKeyStore</a> operation
    /// if necessary, and then use <code>ConnectCustomKeyStore</code> again.
    /// </para>
    ///  
    /// <para>
    ///  <b>CloudHSM key store</b> 
    /// </para>
    ///  
    /// <para>
    /// During the connection process for an CloudHSM key store, KMS finds the CloudHSM cluster
    /// that is associated with the custom key store, creates the connection infrastructure,
    /// connects to the cluster, logs into the CloudHSM client as the <code>kmsuser</code>
    /// CU, and rotates its password.
    /// </para>
    ///  
    /// <para>
    /// To connect an CloudHSM key store, its associated CloudHSM cluster must have at least
    /// one active HSM. To get the number of active HSMs in a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
    /// operation. To add HSMs to the cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm.html">CreateHsm</a>
    /// operation. Also, the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
    /// <code>kmsuser</code> crypto user</a> (CU) must not be logged into the cluster. This
    /// prevents KMS from using this account to log in.
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
    /// </summary>
    public partial class ConnectCustomKeyStoreRequest : AmazonKeyManagementServiceRequest
    {
        private string _customKeyStoreId;

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Enter the key store ID of the custom key store that you want to connect. To find the
        /// ID of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CustomKeyStoreId
        {
            get { return this._customKeyStoreId; }
            set { this._customKeyStoreId = value; }
        }

        // Check to see if CustomKeyStoreId property is set
        internal bool IsSetCustomKeyStoreId()
        {
            return this._customKeyStoreId != null;
        }

    }
}