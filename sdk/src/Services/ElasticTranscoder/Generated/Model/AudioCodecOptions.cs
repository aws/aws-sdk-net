/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Options associated with your audio codec.
    /// </summary>
    public partial class AudioCodecOptions
    {
        private string _bitDepth;
        private string _bitOrder;
        private string _profile;
        private string _signed;

        /// <summary>
        /// Gets and sets the property BitDepth. 
        /// <para>
        /// You can only choose an audio bit depth when you specify <code>flac</code> or <code>pcm</code>
        /// for the value of Audio:Codec.
        /// </para>
        ///  
        /// <para>
        /// The bit depth of a sample is how many bits of information are included in the audio
        /// samples. The higher the bit depth, the better the audio, but the larger the file.
        /// </para>
        ///  
        /// <para>
        /// Valid values are <code>16</code> and <code>24</code>.
        /// </para>
        ///  
        /// <para>
        /// The most common bit depth is <code>24</code>.
        /// </para>
        /// </summary>
        public string BitDepth
        {
            get { return this._bitDepth; }
            set { this._bitDepth = value; }
        }

        // Check to see if BitDepth property is set
        internal bool IsSetBitDepth()
        {
            return this._bitDepth != null;
        }

        /// <summary>
        /// Gets and sets the property BitOrder. 
        /// <para>
        /// You can only choose an audio bit order when you specify <code>pcm</code> for the value
        /// of Audio:Codec.
        /// </para>
        ///  
        /// <para>
        /// The order the bits of a PCM sample are stored in.
        /// </para>
        ///  
        /// <para>
        /// The supported value is <code>LittleEndian</code>.
        /// </para>
        /// </summary>
        public string BitOrder
        {
            get { return this._bitOrder; }
            set { this._bitOrder = value; }
        }

        // Check to see if BitOrder property is set
        internal bool IsSetBitOrder()
        {
            return this._bitOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Profile. 
        /// <para>
        /// You can only choose an audio profile when you specify AAC for the value of Audio:Codec.
        /// </para>
        ///  
        /// <para>
        /// Specify the AAC profile for the output file. Elastic Transcoder supports the following
        /// profiles:
        /// </para>
        ///  <ul> <li><code>auto</code>: If you specify <code>auto</code>, Elastic Transcoder
        /// will select the profile based on the bit rate selected for the output file.</li> <li><code>AAC-LC</code>:
        /// The most common AAC profile. Use for bit rates larger than 64 kbps.</li> <li><code>HE-AAC</code>:
        /// Not supported on some older players and devices. Use for bit rates between 40 and
        /// 80 kbps.</li> <li><code>HE-AACv2</code>: Not supported on some players and devices.
        /// Use for bit rates less than 48 kbps.</li> </ul> 
        /// <para>
        /// All outputs in a <code>Smooth</code> playlist must have the same value for <code>Profile</code>.
        /// </para>
        ///  <note>
        /// <para>
        /// If you created any presets before AAC profiles were added, Elastic Transcoder automatically
        /// updated your presets to use AAC-LC. You can change the value as required.
        /// </para>
        /// </note>
        /// </summary>
        public string Profile
        {
            get { return this._profile; }
            set { this._profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this._profile != null;
        }

        /// <summary>
        /// Gets and sets the property Signed. 
        /// <para>
        /// You can only choose whether an audio sample is signed when you specify <code>pcm</code>
        /// for the value of Audio:Codec.
        /// </para>
        ///  
        /// <para>
        /// Whether audio samples are represented with negative and positive numbers (signed)
        /// or only positive numbers (unsigned).
        /// </para>
        ///  
        /// <para>
        /// The supported value is <code>Signed</code>.
        /// </para>
        /// </summary>
        public string Signed
        {
            get { return this._signed; }
            set { this._signed = value; }
        }

        // Check to see if Signed property is set
        internal bool IsSetSigned()
        {
            return this._signed != null;
        }

    }
}