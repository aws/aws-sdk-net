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
    /// Configure one or more content encryption keys for your endpoints that use SPEKE Version
    /// 2.0. The encryption contract defines which content keys are used to encrypt the audio
    /// and video tracks in your stream. To configure the encryption contract, specify which
    /// audio and video encryption presets to use.
    /// </summary>
    public partial class EncryptionContractConfiguration
    {
        private PresetSpeke20Audio _presetSpeke20Audio;
        private PresetSpeke20Video _presetSpeke20Video;

        /// <summary>
        /// Gets and sets the property PresetSpeke20Audio. 
        /// <para>
        /// A collection of audio encryption presets.
        /// </para>
        ///  
        /// <para>
        /// Value description: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PRESET-AUDIO-1 - Use one content key to encrypt all of the audio tracks in your stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-AUDIO-2 - Use one content key to encrypt all of the stereo audio tracks and
        /// one content key to encrypt all of the multichannel audio tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-AUDIO-3 - Use one content key to encrypt all of the stereo audio tracks, one
        /// content key to encrypt all of the multichannel audio tracks with 3 to 6 channels,
        /// and one content key to encrypt all of the multichannel audio tracks with more than
        /// 6 channels.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHARED - Use the same content key for all of the audio and video tracks in your stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNENCRYPTED - Don't encrypt any of the audio tracks in your stream.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property PresetSpeke20Video. 
        /// <para>
        /// A collection of video encryption presets.
        /// </para>
        ///  
        /// <para>
        /// Value description: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PRESET-VIDEO-1 - Use one content key to encrypt all of the video tracks in your stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-VIDEO-2 - Use one content key to encrypt all of the SD video tracks and one
        /// content key for all HD and higher resolutions video tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-VIDEO-3 - Use one content key to encrypt all of the SD video tracks, one content
        /// key for HD video tracks and one content key for all UHD video tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-VIDEO-4 - Use one content key to encrypt all of the SD video tracks, one content
        /// key for HD video tracks, one content key for all UHD1 video tracks and one content
        /// key for all UHD2 video tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-VIDEO-5 - Use one content key to encrypt all of the SD video tracks, one content
        /// key for HD1 video tracks, one content key for HD2 video tracks, one content key for
        /// all UHD1 video tracks and one content key for all UHD2 video tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-VIDEO-6 - Use one content key to encrypt all of the SD video tracks, one content
        /// key for HD1 video tracks, one content key for HD2 video tracks and one content key
        /// for all UHD video tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-VIDEO-7 - Use one content key to encrypt all of the SD+HD1 video tracks, one
        /// content key for HD2 video tracks and one content key for all UHD video tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PRESET-VIDEO-8 - Use one content key to encrypt all of the SD+HD1 video tracks, one
        /// content key for HD2 video tracks, one content key for all UHD1 video tracks and one
        /// content key for all UHD2 video tracks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHARED - Use the same content key for all of the video and audio tracks in your stream.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UNENCRYPTED - Don't encrypt any of the video tracks in your stream.
        /// </para>
        ///  </li> </ul>
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