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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Group of Audio Selectors
    /// </summary>
    public partial class AudioSelectorGroup
    {
        private List<string> _audioSelectorNames = new List<string>();

        /// <summary>
        /// Gets and sets the property AudioSelectorNames. Name of an Audio Selector within the
        /// same input to include in the group.  Audio selector names are standardized, based
        /// on their order within the input (e.g., "Audio Selector 1").  The audio selector name
        /// parameter can be repeated to add any number of audio selectors to the group.
        /// </summary>
        public List<string> AudioSelectorNames
        {
            get { return this._audioSelectorNames; }
            set { this._audioSelectorNames = value; }
        }

        // Check to see if AudioSelectorNames property is set
        internal bool IsSetAudioSelectorNames()
        {
            return this._audioSelectorNames != null && this._audioSelectorNames.Count > 0; 
        }

    }
}