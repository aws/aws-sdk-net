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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property AudioInput. 
        /// <para>
        /// Contains information about the audio input for an utterance.
        /// </para>
        /// </summary>
        public UtteranceAudioInputSpecification AudioInput { get; set; }

        /// <summary>
        /// Checks to see if the AudioInput property is set.
        /// </summary>
        internal bool IsSetAudioInput() => this.AudioInput != null;

        /// <summary>
        /// Gets and sets the property TextInput. 
        /// <para>
        /// A text input transcription of the utterance. It is only applicable for test-sets containing
        /// text data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string TextInput { get; set; }

        /// <summary>
        /// Checks to see if the TextInput property is set.
        /// </summary>
        internal bool IsSetTextInput() => this.TextInput != null;
    }
}
