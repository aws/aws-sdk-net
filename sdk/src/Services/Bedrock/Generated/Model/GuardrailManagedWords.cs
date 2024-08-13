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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The managed word list that was configured for the guardrail. (This is a list of words
    /// that are pre-defined and managed by guardrails only.)
    /// </summary>
    public partial class GuardrailManagedWords
    {
        private GuardrailManagedWordsType _type;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// ManagedWords$type The managed word type that was configured for the guardrail. (For
        /// now, we only offer profanity word list)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GuardrailManagedWordsType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}