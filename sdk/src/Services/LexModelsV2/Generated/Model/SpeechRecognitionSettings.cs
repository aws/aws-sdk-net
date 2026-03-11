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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Settings that control how Amazon Lex processes and recognizes speech input from users.
    /// </summary>
    public partial class SpeechRecognitionSettings
    {
        private SpeechModelConfig _speechModelConfig;
        private SpeechModelPreference _speechModelPreference;

        /// <summary>
        /// Gets and sets the property SpeechModelConfig. 
        /// <para>
        /// Configuration settings for the selected speech-to-text model.
        /// </para>
        /// </summary>
        public SpeechModelConfig SpeechModelConfig
        {
            get { return this._speechModelConfig; }
            set { this._speechModelConfig = value; }
        }

        // Check to see if SpeechModelConfig property is set
        internal bool IsSetSpeechModelConfig()
        {
            return this._speechModelConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SpeechModelPreference. 
        /// <para>
        /// The speech-to-text model to use.
        /// </para>
        /// </summary>
        public SpeechModelPreference SpeechModelPreference
        {
            get { return this._speechModelPreference; }
            set { this._speechModelPreference = value; }
        }

        // Check to see if SpeechModelPreference property is set
        internal bool IsSetSpeechModelPreference()
        {
            return this._speechModelPreference != null;
        }

    }
}