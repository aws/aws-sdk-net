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
    /// Defines settings for using an Amazon Polly voice to communicate with a user.
    /// </summary>
    public partial class VoiceSettings
    {
        private VoiceEngine _engine;
        private string _voiceId;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// Indicates the type of Amazon Polly voice that Amazon Lex should use for voice interaction
        /// with the user. For more information, see the <a href="https://docs.aws.amazon.com/polly/latest/dg/API_SynthesizeSpeech.html#polly-SynthesizeSpeech-request-Engine">
        /// <code>engine</code> parameter of the <code>SynthesizeSpeech</code> operation</a> in
        /// the <i>Amazon Polly developer guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the default is <code>standard</code>.
        /// </para>
        /// </summary>
        public VoiceEngine Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceId. 
        /// <para>
        /// The identifier of the Amazon Polly voice to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VoiceId
        {
            get { return this._voiceId; }
            set { this._voiceId = value; }
        }

        // Check to see if VoiceId property is set
        internal bool IsSetVoiceId()
        {
            return this._voiceId != null;
        }

    }
}