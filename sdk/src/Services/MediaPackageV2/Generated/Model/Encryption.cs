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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The parameters for encrypting content.
    /// </summary>
    public partial class Encryption
    {
        private bool? _cmafExcludeSegmentDrmMetadata;
        private string _constantInitializationVector;
        private EncryptionMethod _encryptionMethod;
        private int? _keyRotationIntervalSeconds;
        private SpekeKeyProvider _spekeKeyProvider;

        /// <summary>
        /// Gets and sets the property CmafExcludeSegmentDrmMetadata. 
        /// <para>
        /// Excludes SEIG and SGPD boxes from segment metadata in CMAF containers.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>true</c>, MediaPackage omits these DRM metadata boxes from CMAF segments,
        /// which can improve compatibility with certain devices and players that don't support
        /// these boxes.
        /// </para>
        ///  
        /// <para>
        /// Important considerations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// This setting only affects CMAF container formats
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key rotation can still be handled through media playlist signaling
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PSSH and TENC boxes remain unaffected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Default behavior is preserved when this setting is disabled
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid values: <c>true</c> | <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? CmafExcludeSegmentDrmMetadata
        {
            get { return this._cmafExcludeSegmentDrmMetadata; }
            set { this._cmafExcludeSegmentDrmMetadata = value; }
        }

        // Check to see if CmafExcludeSegmentDrmMetadata property is set
        internal bool IsSetCmafExcludeSegmentDrmMetadata()
        {
            return this._cmafExcludeSegmentDrmMetadata.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. 
        /// <para>
        /// A 128-bit, 16-byte hex value represented by a 32-character string, used in conjunction
        /// with the key for encrypting content. If you don't specify a value, then MediaPackage
        /// creates the constant initialization vector (IV).
        /// </para>
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
        /// Gets and sets the property EncryptionMethod. 
        /// <para>
        /// The encryption method to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EncryptionMethod EncryptionMethod
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
        /// Gets and sets the property KeyRotationIntervalSeconds. 
        /// <para>
        /// The frequency (in seconds) of key changes for live workflows, in which content is
        /// streamed real time. The service retrieves content keys before the live content begins
        /// streaming, and then retrieves them as needed over the lifetime of the workflow. By
        /// default, key rotation is set to 300 seconds (5 minutes), the minimum rotation interval,
        /// which is equivalent to setting it to 300. If you don't enter an interval, content
        /// keys aren't rotated.
        /// </para>
        ///  
        /// <para>
        /// The following example setting causes the service to rotate keys every thirty minutes:
        /// <c>1800</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=300, Max=31536000)]
        public int? KeyRotationIntervalSeconds
        {
            get { return this._keyRotationIntervalSeconds; }
            set { this._keyRotationIntervalSeconds = value; }
        }

        // Check to see if KeyRotationIntervalSeconds property is set
        internal bool IsSetKeyRotationIntervalSeconds()
        {
            return this._keyRotationIntervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider. 
        /// <para>
        /// The parameters for the SPEKE key provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}