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
    /// Contains information about input of an utterance.
    /// </summary>
    public partial class UtteranceInputSpecification
    {
        private UtteranceAudioInputSpecification _audioInput;
        private string _textInput;

        /// <summary>
        /// Gets and sets the property AudioInput. 
        /// <para>
        /// Contains information about the audio input for an utterance.
        /// </para>
        /// </summary>
        public UtteranceAudioInputSpecification AudioInput
        {
            get { return this._audioInput; }
            set { this._audioInput = value; }
        }

        // Check to see if AudioInput property is set
        internal bool IsSetAudioInput()
        {
            return this._audioInput != null;
        }

        /// <summary>
        /// Gets and sets the property TextInput. 
        /// <para>
        /// A text input transcription of the utterance. It is only applicable for test-sets containing
        /// text data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string TextInput
        {
            get { return this._textInput; }
            set { this._textInput = value; }
        }

        // Check to see if TextInput property is set
        internal bool IsSetTextInput()
        {
            return this._textInput != null;
        }

    }
}