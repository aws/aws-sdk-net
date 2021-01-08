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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Audio Selector
    /// </summary>
    public partial class AudioSelector
    {
        private string _name;
        private AudioSelectorSettings _selectorSettings;

        /// <summary>
        /// Gets and sets the property Name. The name of this AudioSelector. AudioDescriptions
        /// will use this name to uniquely identify this Selector.  Selector names should be unique
        /// per input.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SelectorSettings. The audio selector settings.
        /// </summary>
        public AudioSelectorSettings SelectorSettings
        {
            get { return this._selectorSettings; }
            set { this._selectorSettings = value; }
        }

        // Check to see if SelectorSettings property is set
        internal bool IsSetSelectorSettings()
        {
            return this._selectorSettings != null;
        }

    }
}