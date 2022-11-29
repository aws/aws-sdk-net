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
    /// Container for the parameters to the DisconnectCustomKeyStore operation.
    /// Disconnects the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a> from its backing key store. This operation disconnects an CloudHSM key
    /// store from its associated CloudHSM cluster or disconnects an external key store from
    /// the external key store proxy that communicates with your external key manager.
    /// 
    ///  
    /// <para>
    ///  This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key stores</a> feature in KMS, which combines the convenience and extensive integration
    /// of KMS with the isolation and control of a key store that you own and manage.
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
    /// key store or to use existing KMS keys in <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
    /// operations</a> will fail. This action can prevent users from storing and accessing
    /// sensitive data.
    /// </para>
    ///  </note> 
    /// <para>
    /// When you disconnect a custom key store, its <code>ConnectionState</code> changes to
    /// <code>Disconnected</code>. To find the connection state of a custom key store, use
    /// the <a>DescribeCustomKeyStores</a> operation. To reconnect a custom key store, use
    /// the <a>ConnectCustomKeyStore</a> operation.
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
    /// </summary>
    public partial class DisconnectCustomKeyStoreRequest : AmazonKeyManagementServiceRequest
    {
        private string _customKeyStoreId;

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Enter the ID of the custom key store you want to disconnect. To find the ID of a custom
        /// key store, use the <a>DescribeCustomKeyStores</a> operation.
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