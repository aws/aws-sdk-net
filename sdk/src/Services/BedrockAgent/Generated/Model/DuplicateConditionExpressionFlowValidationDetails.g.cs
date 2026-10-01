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
    /// Details about duplicate condition expressions found in a condition node.
    /// </summary>
    public partial class DuplicateConditionExpressionFlowValidationDetails
    {
        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The duplicated condition expression.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 64)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property Node. 
        /// <para>
        /// The name of the node containing the duplicate condition expressions.
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
