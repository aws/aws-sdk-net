/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// <para>Options associated with your audio codec.</para>
    /// </summary>
    public class AudioCodecOptions
    {
        
        private string profile;


        /// <summary>
        /// If you specified <c>AAC</c> for <c>Audio:Codec</c>, choose the AAC profile for the output file. Elastic Transcoder supports the following
        /// profiles: <ul> <li><c>auto</c>: If you specify <c>auto</c>, Elastic Transcoder will select the profile based on the bit rate selected for
        /// the output file.</li> <li><c>AAC-LC</c>: The most common AAC profile. Use for bitrates larger than 64 kbps.</li> <li><c>HE-AAC</c>: Not
        /// supported on some older players and devices. Use for bitrates between 40 and 80 kbps.</li> <li><c>HE-AACv2</c>: Not supported on some
        /// players and devices. Use for bitrates less than 48 kbps.</li> </ul> <note>If you created any presets before AAC profiles were added, Elastic
        /// Transcoder automatically updated your presets to use AAC-LC. You can change the value as required.</note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(^auto$)|(^AAC-LC$)|(^HE-AAC$)|(^HE-AACv2$)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Profile
        {
            get { return this.profile; }
            set { this.profile = value; }
        }

        // Check to see if Profile property is set
        internal bool IsSetProfile()
        {
            return this.profile != null;
        }
    }
}
