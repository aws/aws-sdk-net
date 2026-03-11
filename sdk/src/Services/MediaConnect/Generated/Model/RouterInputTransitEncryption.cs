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
    /// The transit encryption settings for a router input.
    /// </summary>
    public partial class RouterInputTransitEncryption
    {
        private RouterInputTransitEncryptionKeyConfiguration _encryptionKeyConfiguration;
        private RouterInputTransitEncryptionKeyType _encryptionKeyType;

        /// <summary>
        /// Gets and sets the property EncryptionKeyConfiguration. 
        /// <para>
        /// Contains the configuration details for the encryption key used in transit encryption,
        /// including the key source and associated parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RouterInputTransitEncryptionKeyConfiguration EncryptionKeyConfiguration
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
        /// Gets and sets the property EncryptionKeyType. 
        /// <para>
        /// Specifies the type of encryption key to use for transit encryption.
        /// </para>
        /// </summary>
        public RouterInputTransitEncryptionKeyType EncryptionKeyType
        {
            get { return this._encryptionKeyType; }
            set { this._encryptionKeyType = value; }
        }

        // Check to see if EncryptionKeyType property is set
        internal bool IsSetEncryptionKeyType()
        {
            return this._encryptionKeyType != null;
        }

    }
}