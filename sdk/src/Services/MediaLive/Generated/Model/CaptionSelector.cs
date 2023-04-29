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
    /// Caption Selector
    /// </summary>
    public partial class CaptionSelector
    {
        private string _languageCode;
        private string _name;
        private CaptionSelectorSettings _selectorSettings;

        /// <summary>
        /// Gets and sets the property LanguageCode. When specified this field indicates the three
        /// letter language code of the caption track to extract from the source.
        /// </summary>
        public string LanguageCode
        {
            get { return this._languageCode; }
            set { this._languageCode = value; }
        }

        // Check to see if LanguageCode property is set
        internal bool IsSetLanguageCode()
        {
            return this._languageCode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. Name identifier for a caption selector.  This name
        /// is used to associate this caption selector with one or more caption descriptions.
        ///  Names must be unique within an event.
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
        /// Gets and sets the property SelectorSettings. Caption selector settings.
        /// </summary>
        public CaptionSelectorSettings SelectorSettings
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