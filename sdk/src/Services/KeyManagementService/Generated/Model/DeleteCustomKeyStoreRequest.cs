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
    /// Container for the parameters to the DeleteCustomKeyStore operation.
    /// Deletes a <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a>. This operation does not delete the AWS CloudHSM cluster that is associated
    /// with the custom key store, or affect any users or keys in the cluster.
    /// 
    ///  
    /// <para>
    /// The custom key store that you delete cannot contain any AWS KMS <a href="http://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">customer
    /// master keys (CMKs)</a>. Before deleting the key store, verify that you will never
    /// need to use any of the CMKs in the key store for any cryptographic operations. Then,
    /// use <a>ScheduleKeyDeletion</a> to delete the AWS KMS customer master keys (CMKs) from
    /// the key store. When the scheduled waiting period expires, the <code>ScheduleKeyDeletion</code>
    /// operation deletes the CMKs. Then it makes a best effort to delete the key material
    /// from the associated cluster. However, you might need to manually <a href="http://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-orphaned-key">delete
    /// the orphaned key material</a> from the cluster and its backups.
    /// </para>
    ///  
    /// <para>
    /// After all CMKs are deleted from AWS KMS, use <a>DisconnectCustomKeyStore</a> to disconnect
    /// the key store from AWS KMS. Then, you can delete the custom key store.
    /// </para>
    ///  
    /// <para>
    /// Instead of deleting the custom key store, consider using <a>DisconnectCustomKeyStore</a>
    /// to disconnect it from AWS KMS. While the key store is disconnected, you cannot create
    /// or use the CMKs in the key store. But, you do not need to delete CMKs and you can
    /// reconnect a disconnected custom key store at any time.
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