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
    /// Specify the SPEKE version, either v1.0 or v2.0, that MediaConvert uses when encrypting
    /// your output. For more information, see: https://docs.aws.amazon.com/speke/latest/documentation/speke-api-specification.html
    /// To use SPEKE v1.0: Leave blank. To use SPEKE v2.0: Specify a SPEKE v2.0 video preset
    /// and a SPEKE v2.0 audio preset.
    /// </summary>
    public partial class EncryptionContractConfiguration
    {
        private PresetSpeke20Audio _spekeAudioPreset;
        private PresetSpeke20Video _spekeVideoPreset;

        /// <summary>
        /// Gets and sets the property SpekeAudioPreset. Specify which SPEKE version 2.0 audio
        /// preset MediaConvert uses to request content keys from your SPEKE server. For more
        /// information, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/drm-content-speke-v2-presets.html
        /// To encrypt to your audio outputs, choose from the following: Audio preset 1, Audio
        /// preset 2, or Audio preset 3. To encrypt your audio outputs, using the same content
        /// key for both your audio and video outputs: Choose Shared. When you do, you must also
        /// set SPEKE v2.0 video preset to Shared. To not encrypt your audio outputs: Choose Unencrypted.
        /// When you do, to encrypt your video outputs, you must also specify a SPEKE v2.0 video
        /// preset (other than Shared or Unencrypted).
        /// </summary>
        public PresetSpeke20Audio SpekeAudioPreset
        {
            get { return this._spekeAudioPreset; }
            set { this._spekeAudioPreset = value; }
        }

        // Check to see if SpekeAudioPreset property is set
        internal bool IsSetSpekeAudioPreset()
        {
            return this._spekeAudioPreset != null;
        }

        /// <summary>
        /// Gets and sets the property SpekeVideoPreset. Specify which SPEKE version 2.0 video
        /// preset MediaConvert uses to request content keys from your SPEKE server. For more
        /// information, see: https://docs.aws.amazon.com/mediaconvert/latest/ug/drm-content-speke-v2-presets.html
        /// To encrypt to your video outputs, choose from the following: Video preset 1, Video
        /// preset 2, Video preset 3, Video preset 4, Video preset 5, Video preset 6, Video preset
        /// 7, or Video preset 8. To encrypt your video outputs, using the same content key for
        /// both your video and audio outputs: Choose Shared. When you do, you must also set SPEKE
        /// v2.0 audio preset to Shared. To not encrypt your video outputs: Choose Unencrypted.
        /// When you do, to encrypt your audio outputs, you must also specify a SPEKE v2.0 audio
        /// preset (other than Shared or Unencrypted).
        /// </summary>
        public PresetSpeke20Video SpekeVideoPreset
        {
            get { return this._spekeVideoPreset; }
            set { this._spekeVideoPreset = value; }
        }

        // Check to see if SpekeVideoPreset property is set
        internal bool IsSetSpekeVideoPreset()
        {
            return this._spekeVideoPreset != null;
        }

    }
}