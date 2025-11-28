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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Optional configuration for audio language settings
    /// </summary>
    public partial class AudioLanguageConfiguration
    {
        private AudioGenerativeOutputLanguage _generativeOutputLanguage;
        private bool? _identifyMultipleLanguages;
        private List<string> _inputLanguages = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GenerativeOutputLanguage.
        /// </summary>
        public AudioGenerativeOutputLanguage GenerativeOutputLanguage
        {
            get { return this._generativeOutputLanguage; }
            set { this._generativeOutputLanguage = value; }
        }

        // Check to see if GenerativeOutputLanguage property is set
        internal bool IsSetGenerativeOutputLanguage()
        {
            return this._generativeOutputLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property IdentifyMultipleLanguages. 
        /// <para>
        /// Enable multiple language identification in audio
        /// </para>
        /// </summary>
        public bool? IdentifyMultipleLanguages
        {
            get { return this._identifyMultipleLanguages; }
            set { this._identifyMultipleLanguages = value; }
        }

        // Check to see if IdentifyMultipleLanguages property is set
        internal bool IsSetIdentifyMultipleLanguages()
        {
            return this._identifyMultipleLanguages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputLanguages.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InputLanguages
        {
            get { return this._inputLanguages; }
            set { this._inputLanguages = value; }
        }

        // Check to see if InputLanguages property is set
        internal bool IsSetInputLanguages()
        {
            return this._inputLanguages != null && (this._inputLanguages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}