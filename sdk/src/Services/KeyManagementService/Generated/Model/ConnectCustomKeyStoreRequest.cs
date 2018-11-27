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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the ConnectCustomKeyStore operation.
    /// Connects or reconnects a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a> to its associated AWS CloudHSM cluster.
    /// 
    ///  
    /// <para>
    /// The custom key store must be connected before you can create customer master keys
    /// (CMKs) in the key store or use the CMKs it contains. You can disconnect and reconnect
    /// a custom key store at any time.
    /// </para>
    ///  
    /// <para>
    /// To connect a custom key store, its associated AWS CloudHSM cluster must have at least
    /// one active HSM. To get the number of active HSMs in a cluster, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters">DescribeClusters</a>
    /// operation. To add HSMs to the cluster, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_CreateHsm">CreateHsm</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// The connection process can take an extended amount of time to complete; up to 20 minutes.
    /// This operation starts the connection process, but it does not wait for it to complete.
    /// When it succeeds, this operation quickly returns an HTTP 200 response and a JSON object
    /// with no properties. However, this response does not indicate that the custom key store
    /// is connected. To get the connection state of the custom key store, use the <a>DescribeCustomKeyStores</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// During the connection process, AWS KMS finds the AWS CloudHSM cluster that is associated
    /// with the custom key store, creates the connection infrastructure, connects to the
    /// cluster, logs into the AWS CloudHSM client as the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
    /// <code>kmsuser</code> crypto user</a> (CU), and rotates its password.
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
    /// If you are having trouble connecting or disconnecting a custom key store, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
    /// a Custom Key Store</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
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