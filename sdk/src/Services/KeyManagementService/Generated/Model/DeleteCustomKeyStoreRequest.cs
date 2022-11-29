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
    /// Container for the parameters to the DeleteCustomKeyStore operation.
    /// Deletes a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a>. This operation does not affect any backing elements of the custom key
    /// store. It does not delete the CloudHSM cluster that is associated with an CloudHSM
    /// key store, or affect any users or keys in the cluster. For an external key store,
    /// it does not affect the external key store proxy, external key manager, or any external
    /// keys.
    /// 
    ///  
    /// <para>
    ///  This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key stores</a> feature in KMS, which combines the convenience and extensive integration
    /// of KMS with the isolation and control of a key store that you own and manage.
    /// </para>
    ///  
    /// <para>
    /// The custom key store that you delete cannot contain any <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#kms_keys">KMS
    /// keys</a>. Before deleting the key store, verify that you will never need to use any
    /// of the KMS keys in the key store for any <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#cryptographic-operations">cryptographic
    /// operations</a>. Then, use <a>ScheduleKeyDeletion</a> to delete the KMS keys from the
    /// key store. After the required waiting period expires and all KMS keys are deleted
    /// from the custom key store, use <a>DisconnectCustomKeyStore</a> to disconnect the key
    /// store from KMS. Then, you can delete the custom key store.
    /// </para>
    ///  
    /// <para>
    /// For keys in an CloudHSM key store, the <code>ScheduleKeyDeletion</code> operation
    /// makes a best effort to delete the key material from the associated cluster. However,
    /// you might need to manually <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
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
    /// </summary>
    public partial class DeleteCustomKeyStoreRequest : AmazonKeyManagementServiceRequest
    {
        private string _customKeyStoreId;

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Enter the ID of the custom key store you want to delete. To find the ID of a custom
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