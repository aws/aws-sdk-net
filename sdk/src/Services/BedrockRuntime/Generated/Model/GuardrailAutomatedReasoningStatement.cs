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
    /// A logical statement that includes both formal logic representation and natural language
    /// explanation.
    /// </summary>
    public partial class GuardrailAutomatedReasoningStatement
    {
        private string _logic;
        private string _naturalLanguage;

        /// <summary>
        /// Gets and sets the property Logic. 
        /// <para>
        /// The formal logical representation of the statement.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string Logic
        {
            get { return this._logic; }
            set { this._logic = value; }
        }

        // Check to see if Logic property is set
        internal bool IsSetLogic()
        {
            return this._logic != null;
        }

        /// <summary>
        /// Gets and sets the property NaturalLanguage. 
        /// <para>
        /// The natural language explanation of the logical statement.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000)]
        public string NaturalLanguage
        {
            get { return this._naturalLanguage; }
            set { this._naturalLanguage = value; }
        }

        // Check to see if NaturalLanguage property is set
        internal bool IsSetNaturalLanguage()
        {
            return this._naturalLanguage != null;
        }

    }
}