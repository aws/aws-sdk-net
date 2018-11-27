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
    /// Container for the parameters to the DisconnectCustomKeyStore operation.
    /// Disconnects the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a> from its associated AWS CloudHSM cluster. While a custom key store is
    /// disconnected, you can manage the custom key store and its customer master keys (CMKs),
    /// but you cannot create or use CMKs in the custom key store. You can reconnect the custom
    /// key store at any time.
    /// 
    ///  <note> 
    /// <para>
    /// While a custom key store is disconnected, all attempts to create customer master keys
    /// (CMKs) in the custom key store or to use existing CMKs in cryptographic operations
    /// will fail. This action can prevent users from storing and accessing sensitive data.
    /// </para>
    ///  </note>  
    /// <para>
    /// To find the connection state of a custom key store, use the <a>DescribeCustomKeyStores</a>
    /// operation. To reconnect a custom key store, use the <a>ConnectCustomKeyStore</a> operation.
    /// </para>
    ///  
    /// <para>
    /// If the operation succeeds, it returns a JSON object with no properties.
    /// </para>
    ///  
    /// <para>
    /// This operation is part of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
    /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
    /// integration of AWS KMS with the isolation and control of a single-tenant key store.
    /// </para>
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