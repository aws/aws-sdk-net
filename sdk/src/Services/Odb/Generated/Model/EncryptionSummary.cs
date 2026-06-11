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
    /// The encryption configuration for an Autonomous Database.
    /// </summary>
    public partial class EncryptionSummary
    {
        private EncryptionKeyConfiguration _encryptionKeyConfiguration;
        private EncryptionKeyProvider _encryptionKeyProvider;

        /// <summary>
        /// Gets and sets the property EncryptionKeyConfiguration. 
        /// <para>
        /// The configuration of the encryption key used for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionKeyConfiguration EncryptionKeyConfiguration
        {
            get { return this._encryptionKeyConfiguration; }
            set { this._encryptionKeyConfiguration = value; }
        }

        // Check to see if EncryptionKeyConfiguration property is set
        internal bool IsSetEncryptionKeyConfiguration()
        {
            return this._encryptionKeyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyProvider. 
        /// <para>
        /// The provider of the encryption key used for the Autonomous Database.
        /// </para>
        /// </summary>
        public EncryptionKeyProvider EncryptionKeyProvider
        {
            get { return this._encryptionKeyProvider; }
            set { this._encryptionKeyProvider = value; }
        }

        // Check to see if EncryptionKeyProvider property is set
        internal bool IsSetEncryptionKeyProvider()
        {
            return this._encryptionKeyProvider != null;
        }

    }
}