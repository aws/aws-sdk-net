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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Details about a malformed condition expression in a node.
    /// </summary>
    public partial class MalformedConditionExpressionFlowValidationDetails
    {
        /// <summary>
        /// Gets and sets the property Cause. 
        /// <para>
        /// The error message describing why the condition expression is malformed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string Cause { get; set; }

        /// <summary>
        /// Checks to see if the Cause property is set.
        /// </summary>
        internal bool IsSetCause() => this.Cause != null;

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// The name of the malformed condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property Node. 
        /// <para>
        /// The name of the node containing the malformed condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Node { get; set; }

        /// <summary>
        /// Checks to see if the Node property is set.
        /// </summary>
        internal bool IsSetNode() => this.Node != null;
    }
}
