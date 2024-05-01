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
 * Do not modify this file. This file is generated from the mediapackage-vod-2018-11-07.normal.json service model.
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
namespace Amazon.MediaPackageVod.Model
{
    /// <summary>
    /// Use encryptionContractConfiguration to configure one or more content encryption keys
    /// for your endpoints that use SPEKE 2.0. The encryption contract defines which content
    /// keys are used to encrypt the audio and video tracks in your stream. To configure the
    /// encryption contract, specify which audio and video encryption presets to use.Note
    /// the following considerations when using encryptionContractConfiguration:encryptionContractConfiguration
    /// can be used for DASH endpoints that use SPEKE 2.0. SPEKE 2.0 relies on the CPIX 2.3
    /// specification.You must disable key rotation for this endpoint by setting keyRotationIntervalSeconds
    /// to 0.
    /// </summary>
    public partial class EncryptionContractConfiguration
    {
        private PresetSpeke20Audio _presetSpeke20Audio;
        private PresetSpeke20Video _presetSpeke20Video;

        /// <summary>
        /// Gets and sets the property PresetSpeke20Audio. A collection of audio encryption presets.
        /// </summary>
        [AWSProperty(Required=true)]
        public PresetSpeke20Audio PresetSpeke20Audio
        {
            get { return this._presetSpeke20Audio; }
            set { this._presetSpeke20Audio = value; }
        }

        // Check to see if PresetSpeke20Audio property is set
        internal bool IsSetPresetSpeke20Audio()
        {
            return this._presetSpeke20Audio != null;
        }

        /// <summary>
        /// Gets and sets the property PresetSpeke20Video. A collection of video encryption presets.
        /// </summary>
        [AWSProperty(Required=true)]
        public PresetSpeke20Video PresetSpeke20Video
        {
            get { return this._presetSpeke20Video; }
            set { this._presetSpeke20Video = value; }
        }

        // Check to see if PresetSpeke20Video property is set
        internal bool IsSetPresetSpeke20Video()
        {
            return this._presetSpeke20Video != null;
        }

    }
}