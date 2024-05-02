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
    /// The object containing information that associates the recommended intent/slot type
    /// with a conversation.
    /// </summary>
    public partial class AssociatedTranscript
    {
        private string _transcript;

        /// <summary>
        /// Gets and sets the property Transcript. 
        /// <para>
        /// The content of the transcript that meets the search filter criteria. For the JSON
        /// format of the transcript, see <a href="https://docs.aws.amazon.com/lexv2/latest/dg/designing-output-format.html">Output
        /// transcript format</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6000000)]
        public string Transcript
        {
            get { return this._transcript; }
            set { this._transcript = value; }
        }

        // Check to see if Transcript property is set
        internal bool IsSetTranscript()
        {
            return this._transcript != null;
        }

    }
}