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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// The guardrail coverage for the text characters.
    /// </summary>
    public partial class GuardrailTextCharactersCoverage
    {
        private int? _guarded;
        private int? _total;

        /// <summary>
        /// Gets and sets the property Guarded. 
        /// <para>
        /// The text characters that were guarded by the guardrail coverage.
        /// </para>
        /// </summary>
        public int Guarded
        {
            get { return this._guarded.GetValueOrDefault(); }
            set { this._guarded = value; }
        }

        // Check to see if Guarded property is set
        internal bool IsSetGuarded()
        {
            return this._guarded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The total text characters by the guardrail coverage.
        /// </para>
        /// </summary>
        public int Total
        {
            get { return this._total.GetValueOrDefault(); }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}