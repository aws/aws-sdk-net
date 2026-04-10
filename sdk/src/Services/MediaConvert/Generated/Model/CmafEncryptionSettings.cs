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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for CMAF encryption
    /// </summary>
    public partial class CmafEncryptionSettings
    {
        private HlsClearLead _clearLead;
        private string _constantInitializationVector;
        private CmafEncryptionType _encryptionMethod;
        private CmafInitializationVectorInManifest _initializationVectorInManifest;
        private SpekeKeyProviderCmaf _spekeKeyProvider;
        private StaticKeyProvider _staticKeyProvider;
        private CmafKeyProviderType _type;

        /// <summary>
        /// Gets and sets the property ClearLead. Enable Clear Lead DRM to reduce video startup
        /// latency by leaving the first segment unencrypted while DRM license retrieval occurs
        /// in parallel. This optimization allows immediate playback startup while maintaining
        /// content protection for the remainder of the stream. When enabled, the first output
        /// segment remains fully unencrypted, and encryption begins at the start of the second
        /// segment. The HLS manifest will omit #EXT-X-KEY tags during the clear segment and insert
        /// the first #EXT-X-KEY immediately before the first encrypted fragment. This feature
        /// is supported exclusively for CMAF HLS (fMP4) outputs and is compatible with all existing
        /// key provider integrations (SPEKE v1, SPEKE v2, and Static Key encryption). Supported
        /// codecs: H.264, H.265, and AV1 video codecs, and AAC audio codec. Choose Enabled to
        /// activate Clear Lead DRM optimization. Choose Disabled to use standard encryption where
        /// all segments are encrypted from the beginning.
        /// </summary>
        public HlsClearLead ClearLead
        {
            get { return this._clearLead; }
            set { this._clearLead = value; }
        }

        // Check to see if ClearLead property is set
        internal bool IsSetClearLead()
        {
            return this._clearLead != null;
        }

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
        /// Gets and sets the property EncryptionMethod. Specify the encryption scheme that you
        /// want the service to use when encrypting your CMAF segments. Choose AES-CBC subsample
        /// or AES_CTR.
        /// </summary>
        public CmafEncryptionType EncryptionMethod
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
        /// Gets and sets the property InitializationVectorInManifest. When you use DRM with CMAF
        /// outputs, choose whether the service writes the 128-bit encryption initialization vector
        /// in the HLS and DASH manifests.
        /// </summary>
        public CmafInitializationVectorInManifest InitializationVectorInManifest
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
        /// Gets and sets the property SpekeKeyProvider. If your output group type is CMAF, use
        /// these settings when doing DRM encryption with a SPEKE-compliant key provider. If your
        /// output group type is HLS, DASH, or Microsoft Smooth, use the SpekeKeyProvider settings
        /// instead.
        /// </summary>
        public SpekeKeyProviderCmaf SpekeKeyProvider
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
        public CmafKeyProviderType Type
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