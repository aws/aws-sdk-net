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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains configuration information for maintaining Data Catalog security.
    /// </summary>
    public partial class DataCatalogEncryptionSettings
    {
        private ConnectionPasswordEncryption _connectionPasswordEncryption;
        private EncryptionAtRest _encryptionAtRest;

        /// <summary>
        /// Gets and sets the property ConnectionPasswordEncryption. 
        /// <para>
        /// When connection password protection is enabled, the Data Catalog uses a customer-provided
        /// key to encrypt the password as part of <c>CreateConnection</c> or <c>UpdateConnection</c>
        /// and store it in the <c>ENCRYPTED_PASSWORD</c> field in the connection properties.
        /// You can enable catalog encryption or only password encryption.
        /// </para>
        /// </summary>
        public ConnectionPasswordEncryption ConnectionPasswordEncryption
        {
            get { return this._connectionPasswordEncryption; }
            set { this._connectionPasswordEncryption = value; }
        }

        // Check to see if ConnectionPasswordEncryption property is set
        internal bool IsSetConnectionPasswordEncryption()
        {
            return this._connectionPasswordEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionAtRest. 
        /// <para>
        /// Specifies the encryption-at-rest configuration for the Data Catalog.
        /// </para>
        /// </summary>
        public EncryptionAtRest EncryptionAtRest
        {
            get { return this._encryptionAtRest; }
            set { this._encryptionAtRest = value; }
        }

        // Check to see if EncryptionAtRest property is set
        internal bool IsSetEncryptionAtRest()
        {
            return this._encryptionAtRest != null;
        }

    }
}