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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Provides the phrase that Amazon Lex V2 should look for in the user's input to the
    /// bot.
    /// </summary>
    public partial class RuntimeHintValue
    {
        private string _phrase;

        /// <summary>
        /// Gets and sets the property Phrase. 
        /// <para>
        /// The phrase that Amazon Lex V2 should look for in the user's input to the bot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string Phrase
        {
            get { return this._phrase; }
            set { this._phrase = value; }
        }

        // Check to see if Phrase property is set
        internal bool IsSetPhrase()
        {
            return this._phrase != null;
        }

    }
}