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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Contains the configuration settings for encrypting SRT streams, including the encryption
    /// key details and encryption parameters.
    /// </summary>
    public partial class SrtEncryptionConfiguration
    {
        private SecretsManagerEncryptionKeyConfiguration _encryptionKey;

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// Specifies the encryption key configuration used for encrypting SRT streams, including
        /// the key source and associated credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SecretsManagerEncryptionKeyConfiguration EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

    }
}