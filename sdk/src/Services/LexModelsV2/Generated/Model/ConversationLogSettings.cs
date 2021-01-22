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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Configures conversation logging that saves audio, text, and metadata for the conversations
    /// with your users.
    /// </summary>
    public partial class ConversationLogSettings
    {
        private List<AudioLogSetting> _audioLogSettings = new List<AudioLogSetting>();
        private List<TextLogSetting> _textLogSettings = new List<TextLogSetting>();

        /// <summary>
        /// Gets and sets the property AudioLogSettings. 
        /// <para>
        /// The Amazon S3 settings for logging audio to an S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AudioLogSetting> AudioLogSettings
        {
            get { return this._audioLogSettings; }
            set { this._audioLogSettings = value; }
        }

        // Check to see if AudioLogSettings property is set
        internal bool IsSetAudioLogSettings()
        {
            return this._audioLogSettings != null && this._audioLogSettings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TextLogSettings. 
        /// <para>
        /// The Amazon CloudWatch Logs settings for logging text and metadata.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<TextLogSetting> TextLogSettings
        {
            get { return this._textLogSettings; }
            set { this._textLogSettings = value; }
        }

        // Check to see if TextLogSettings property is set
        internal bool IsSetTextLogSettings()
        {
            return this._textLogSettings != null && this._textLogSettings.Count > 0; 
        }

    }
}