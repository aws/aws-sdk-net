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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Provides the name of the custom language model that was included in the specified
    /// transcription job.
    /// 
    ///  
    /// <para>
    /// Only use <code>ModelSettings</code> with the <code>LanguageModelName</code> sub-parameter
    /// if you're <b>not</b> using automatic language identification (<code/>). If using <code>LanguageIdSettings</code>
    /// in your request, this parameter contains a <code>LanguageModelName</code> sub-parameter.
    /// </para>
    /// </summary>
    public partial class ModelSettings
    {
        private string _languageModelName;

        /// <summary>
        /// Gets and sets the property LanguageModelName. 
        /// <para>
        /// The name of the custom language model you want to use when processing your transcription
        /// job. Note that custom language model names are case sensitive.
        /// </para>
        ///  
        /// <para>
        /// The language of the specified custom language model must match the language code that
        /// you specify in your transcription request. If the languages don't match, the custom
        /// language model isn't applied. There are no errors or warnings associated with a language
        /// mismatch.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string LanguageModelName
        {
            get { return this._languageModelName; }
            set { this._languageModelName = value; }
        }

        // Check to see if LanguageModelName property is set
        internal bool IsSetLanguageModelName()
        {
            return this._languageModelName != null;
        }

    }
}