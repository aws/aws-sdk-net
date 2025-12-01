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
    /// Configuration settings that define which speech-to-text model to use for processing
    /// speech input.
    /// </summary>
    public partial class SpeechModelConfig
    {
        private DeepgramSpeechModelConfig _deepgramConfig;

        /// <summary>
        /// Gets and sets the property DeepgramConfig. 
        /// <para>
        /// Configuration settings for using Deepgram as the speech-to-text provider.
        /// </para>
        /// </summary>
        public DeepgramSpeechModelConfig DeepgramConfig
        {
            get { return this._deepgramConfig; }
            set { this._deepgramConfig = value; }
        }

        // Check to see if DeepgramConfig property is set
        internal bool IsSetDeepgramConfig()
        {
            return this._deepgramConfig != null;
        }

    }
}