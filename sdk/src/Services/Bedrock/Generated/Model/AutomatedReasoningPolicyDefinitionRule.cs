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
    /// Represents a formal logic rule in an Automated Reasoning policy. For example, rules
    /// can be expressed as if-then statements that define logical constraints.
    /// </summary>
    public partial class AutomatedReasoningPolicyDefinitionRule
    {
        private string _alternateExpression;
        private string _expression;
        private string _id;

        /// <summary>
        /// Gets and sets the property AlternateExpression. 
        /// <para>
        /// The human-readable form of the rule expression, often in natural language or simplified
        /// notation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string AlternateExpression
        {
            get { return this._alternateExpression; }
            set { this._alternateExpression = value; }
        }

        // Check to see if AlternateExpression property is set
        internal bool IsSetAlternateExpression()
        {
            return this._alternateExpression != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The formal logic expression of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=0, Max=2048)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the rule within the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

    }
}