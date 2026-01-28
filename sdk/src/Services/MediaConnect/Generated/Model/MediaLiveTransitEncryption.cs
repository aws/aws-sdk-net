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
    /// The encryption configuration that defines how content is encrypted during transit
    /// between MediaConnect Router and MediaLive. This configuration determines whether encryption
    /// keys are automatically managed by the service or manually managed through Secrets
    /// Manager.
    /// </summary>
    public partial class MediaLiveTransitEncryption
    {
        private MediaLiveTransitEncryptionKeyConfiguration _encryptionKeyConfiguration;
        private MediaLiveTransitEncryptionKeyType _encryptionKeyType;

        /// <summary>
        /// Gets and sets the property EncryptionKeyConfiguration. 
        /// <para>
        /// The configuration details for the MediaLive encryption key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MediaLiveTransitEncryptionKeyConfiguration EncryptionKeyConfiguration
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
        /// The type of encryption key to use for MediaLive transit encryption.
        /// </para>
        /// </summary>
        public MediaLiveTransitEncryptionKeyType EncryptionKeyType
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