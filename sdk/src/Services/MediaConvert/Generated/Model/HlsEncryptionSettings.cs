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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for HLS encryption
    /// </summary>
    public partial class HlsEncryptionSettings
    {
        private string _constantInitializationVector;
        private HlsEncryptionType _encryptionMethod;
        private HlsInitializationVectorInManifest _initializationVectorInManifest;
        private HlsOfflineEncrypted _offlineEncrypted;
        private SpekeKeyProvider _spekeKeyProvider;
        private StaticKeyProvider _staticKeyProvider;
        private HlsKeyProviderType _type;

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. This is a 128-bit, 16-byte
        /// hex value represented by a 32-character text string. If this parameter is not set
        /// then the Initialization Vector will follow the segment number by default.
        /// </summary>
        [AWSProperty(Min=32, Max=32)]
        public string ConstantInitializationVector
        {
            get { return this._constantInitializationVector; }
            set { this._constantInitializationVector = value; }
        }

        // Check to see if ConstantInitializationVector property is set
        internal bool IsSetConstantInitializationVector()
        {
            return this._constantInitializationVector != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionMethod. Encrypts the segments with the given
        /// encryption scheme. Leave blank to disable. Selecting 'Disabled' in the web interface
        /// also disables encryption.
        /// </summary>
        public HlsEncryptionType EncryptionMethod
        {
            get { return this._encryptionMethod; }
            set { this._encryptionMethod = value; }
        }

        // Check to see if EncryptionMethod property is set
        internal bool IsSetEncryptionMethod()
        {
            return this._encryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationVectorInManifest. The Initialization Vector
        /// is a 128-bit number used in conjunction with the key for encrypting blocks. If set
        /// to INCLUDE, Initialization Vector is listed in the manifest. Otherwise Initialization
        /// Vector is not in the manifest.
        /// </summary>
        public HlsInitializationVectorInManifest InitializationVectorInManifest
        {
            get { return this._initializationVectorInManifest; }
            set { this._initializationVectorInManifest = value; }
        }

        // Check to see if InitializationVectorInManifest property is set
        internal bool IsSetInitializationVectorInManifest()
        {
            return this._initializationVectorInManifest != null;
        }

        /// <summary>
        /// Gets and sets the property OfflineEncrypted. Enable this setting to insert the EXT-X-SESSION-KEY
        /// element into the master playlist. This allows for offline Apple HLS FairPlay content
        /// protection.
        /// </summary>
        public HlsOfflineEncrypted OfflineEncrypted
        {
            get { return this._offlineEncrypted; }
            set { this._offlineEncrypted = value; }
        }

        // Check to see if OfflineEncrypted property is set
        internal bool IsSetOfflineEncrypted()
        {
            return this._offlineEncrypted != null;
        }

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider. If your output group type is HLS, DASH,
        /// or Microsoft Smooth, use these settings when doing DRM encryption with a SPEKE-compliant
        /// key provider. If your output group type is CMAF, use the SpekeKeyProviderCmaf settings
        /// instead.
        /// </summary>
        public SpekeKeyProvider SpekeKeyProvider
        {
            get { return this._spekeKeyProvider; }
            set { this._spekeKeyProvider = value; }
        }

        // Check to see if SpekeKeyProvider property is set
        internal bool IsSetSpekeKeyProvider()
        {
            return this._spekeKeyProvider != null;
        }

        /// <summary>
        /// Gets and sets the property StaticKeyProvider. Use these settings to set up encryption
        /// with a static key provider.
        /// </summary>
        public StaticKeyProvider StaticKeyProvider
        {
            get { return this._staticKeyProvider; }
            set { this._staticKeyProvider = value; }
        }

        // Check to see if StaticKeyProvider property is set
        internal bool IsSetStaticKeyProvider()
        {
            return this._staticKeyProvider != null;
        }

        /// <summary>
        /// Gets and sets the property Type. Specify whether your DRM encryption key is static
        /// or from a key provider that follows the SPEKE standard. For more information about
        /// SPEKE, see https://docs.aws.amazon.com/speke/latest/documentation/what-is-speke.html.
        /// </summary>
        public HlsKeyProviderType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}