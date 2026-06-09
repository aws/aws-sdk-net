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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The configuration of the Oracle Cloud Infrastructure (OCI) Vault encryption key used
    /// for an Autonomous Database.
    /// </summary>
    public partial class OciEncryptionKeyConfiguration
    {
        private string _kmsKeyId;
        private string _vaultId;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the OCI Vault key to use for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property VaultId. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the OCI Vault that contains the encryption key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string VaultId
        {
            get { return this._vaultId; }
            set { this._vaultId = value; }
        }

        // Check to see if VaultId property is set
        internal bool IsSetVaultId()
        {
            return this._vaultId != null;
        }

    }
}