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
    /// Configures the content quality analysis features for the router input.
    /// </summary>
    public partial class ContentQualityAnalysisFeatureConfiguration
    {
        private BlackFramesConfiguration _blackFrames;
        private FrozenFramesConfiguration _frozenFrames;
        private SilentAudioConfiguration _silentAudio;

        /// <summary>
        /// Gets and sets the property BlackFrames. 
        /// <para>
        /// Settings for black frames detection.
        /// </para>
        /// </summary>
        public BlackFramesConfiguration BlackFrames
        {
            get { return this._blackFrames; }
            set { this._blackFrames = value; }
        }

        // Check to see if BlackFrames property is set
        internal bool IsSetBlackFrames()
        {
            return this._blackFrames != null;
        }

        /// <summary>
        /// Gets and sets the property FrozenFrames. 
        /// <para>
        /// Settings for frozen frames detection.
        /// </para>
        /// </summary>
        public FrozenFramesConfiguration FrozenFrames
        {
            get { return this._frozenFrames; }
            set { this._frozenFrames = value; }
        }

        // Check to see if FrozenFrames property is set
        internal bool IsSetFrozenFrames()
        {
            return this._frozenFrames != null;
        }

        /// <summary>
        /// Gets and sets the property SilentAudio. 
        /// <para>
        /// Settings for silent audio detection.
        /// </para>
        /// </summary>
        public SilentAudioConfiguration SilentAudio
        {
            get { return this._silentAudio; }
            set { this._silentAudio = value; }
        }

        // Check to see if SilentAudio property is set
        internal bool IsSetSilentAudio()
        {
            return this._silentAudio != null;
        }

    }
}