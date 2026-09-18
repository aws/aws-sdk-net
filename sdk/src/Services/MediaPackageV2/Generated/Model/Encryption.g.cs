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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        public bool? CmafExcludeSegmentDrmMetadata { get; set; }

        /// <summary>
        /// Checks to see if the CmafExcludeSegmentDrmMetadata property is set.
        /// </summary>
        internal bool IsSetCmafExcludeSegmentDrmMetadata() => this.CmafExcludeSegmentDrmMetadata.HasValue;

        /// <summary>
        /// Gets and sets the property ConstantInitializationVector. 
        /// <para>
        /// A 128-bit, 16-byte hex value represented by a 32-character string, used in conjunction
        /// with the key for encrypting content. If you don't specify a value, then MediaPackage
        /// creates the constant initialization vector (IV).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 32)]
        public string ConstantInitializationVector { get; set; }

        /// <summary>
        /// Checks to see if the ConstantInitializationVector property is set.
        /// </summary>
        internal bool IsSetConstantInitializationVector() => this.ConstantInitializationVector != null;

        /// <summary>
        /// Gets and sets the property EncryptionMethod. 
        /// <para>
        /// The encryption method to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionMethod EncryptionMethod { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMethod property is set.
        /// </summary>
        internal bool IsSetEncryptionMethod() => this.EncryptionMethod != null;

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
        [AWSProperty(Min = 300, Max = 31536000)]
        public int? KeyRotationIntervalSeconds { get; set; }

        /// <summary>
        /// Checks to see if the KeyRotationIntervalSeconds property is set.
        /// </summary>
        internal bool IsSetKeyRotationIntervalSeconds() => this.KeyRotationIntervalSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SpekeKeyProvider. 
        /// <para>
        /// The parameters for the SPEKE key provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SpekeKeyProvider SpekeKeyProvider { get; set; }

        /// <summary>
        /// Checks to see if the SpekeKeyProvider property is set.
        /// </summary>
        internal bool IsSetSpekeKeyProvider() => this.SpekeKeyProvider != null;
    }
}
