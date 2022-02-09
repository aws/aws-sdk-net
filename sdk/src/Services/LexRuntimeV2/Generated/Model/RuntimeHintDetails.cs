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

namespace Amazon.LexRuntimeV2.Model
{
    /// <summary>
    /// Provides an array of phrases that should be given preference when resolving values
    /// for a slot.
    /// </summary>
    public partial class RuntimeHintDetails
    {
        private List<RuntimeHintValue> _runtimeHintValues = new List<RuntimeHintValue>();

        /// <summary>
        /// Gets and sets the property RuntimeHintValues. 
        /// <para>
        /// One or more strings that Amazon Lex V2 should look for in the input to the bot. Each
        /// phrase is given preference when deciding on slot values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<RuntimeHintValue> RuntimeHintValues
        {
            get { return this._runtimeHintValues; }
            set { this._runtimeHintValues = value; }
        }

        // Check to see if RuntimeHintValues property is set
        internal bool IsSetRuntimeHintValues()
        {
            return this._runtimeHintValues != null && this._runtimeHintValues.Count > 0; 
        }

    }
}