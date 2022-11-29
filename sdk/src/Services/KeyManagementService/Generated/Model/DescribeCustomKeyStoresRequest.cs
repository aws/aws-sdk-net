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
    /// Container for the parameters to the DescribeCustomKeyStores operation.
    /// Gets information about <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key stores</a> in the account and Region.
    /// 
    ///  
    /// <para>
    ///  This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key stores</a> feature in KMS, which combines the convenience and extensive integration
    /// of KMS with the isolation and control of a key store that you own and manage.
    /// </para>
    ///  
    /// <para>
    /// By default, this operation returns information about all custom key stores in the
    /// account and Region. To get only information about a particular custom key store, use
    /// either the <code>CustomKeyStoreName</code> or <code>CustomKeyStoreId</code> parameter
    /// (but not both).
    /// </para>
    ///  
    /// <para>
    /// To determine whether the custom key store is connected to its CloudHSM cluster or
    /// external key store proxy, use the <code>ConnectionState</code> element in the response.
    /// If an attempt to connect the custom key store failed, the <code>ConnectionState</code>
    /// value is <code>FAILED</code> and the <code>ConnectionErrorCode</code> element in the
    /// response indicates the cause of the failure. For help interpreting the <code>ConnectionErrorCode</code>,
    /// see <a>CustomKeyStoresListEntry</a>.
    /// </para>
    ///  
    /// <para>
    /// Custom key stores have a <code>DISCONNECTED</code> connection state if the key store
    /// has never been connected or you used the <a>DisconnectCustomKeyStore</a> operation
    /// to disconnect it. Otherwise, the connection state is CONNECTED. If your custom key
    /// store connection state is <code>CONNECTED</code> but you are having trouble using
    /// it, verify that the backing store is active and available. For an CloudHSM key store,
    /// verify that the associated CloudHSM cluster is active and contains the minimum number
    /// of HSMs required for the operation, if any. For an external key store, verify that
    /// the external key store proxy and its associated external key manager are reachable
    /// and enabled.
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
    /// </summary>
    public partial class DescribeCustomKeyStoresRequest : AmazonKeyManagementServiceRequest
    {
        private string _customKeyStoreId;
        private string _customKeyStoreName;
        private int? _limit;
        private string _marker;

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Gets only information about the specified custom key store. Enter the key store ID.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation gets information about all custom key stores in the account
        /// and Region. To limit the output to a particular custom key store, provide either the
        /// <code>CustomKeyStoreId</code> or <code>CustomKeyStoreName</code> parameter, but not
        /// both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

        /// <summary>
        /// Gets and sets the property CustomKeyStoreName. 
        /// <para>
        /// Gets only information about the specified custom key store. Enter the friendly name
        /// of the custom key store.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation gets information about all custom key stores in the account
        /// and Region. To limit the output to a particular custom key store, provide either the
        /// <code>CustomKeyStoreId</code> or <code>CustomKeyStoreName</code> parameter, but not
        /// both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string CustomKeyStoreName
        {
            get { return this._customKeyStoreName; }
            set { this._customKeyStoreName = value; }
        }

        // Check to see if CustomKeyStoreName property is set
        internal bool IsSetCustomKeyStoreName()
        {
            return this._customKeyStoreName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Use this parameter to specify the maximum number of items to return. When this value
        /// is present, KMS does not return more than the specified number of items, but it might
        /// return fewer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter in a subsequent request after you receive a response with truncated
        /// results. Set it to the value of <code>NextMarker</code> from the truncated response
        /// you just received.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}