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
    /// An annotation for adding a new rule to the policy by converting a natural language
    /// description into a formal logical expression.
    /// </summary>
    public partial class AutomatedReasoningPolicyAddRuleFromNaturalLanguageAnnotation
    {
        private string _naturalLanguage;

        /// <summary>
        /// Gets and sets the property NaturalLanguage. 
        /// <para>
        /// The natural language description of the rule that should be converted into a formal
        /// logical expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=1024)]
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