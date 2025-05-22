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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
    /// Contains configurations for an input in an Amazon Bedrock Flows node.
    /// </summary>
    public partial class FlowNodeInput
    {
        private FlowNodeInputCategory _category;
        private string _expression;
        private string _name;
        private FlowNodeIODataType _type;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// Specifies how input data flows between iterations in a DoWhile loop.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LoopCondition</c> - Controls whether the loop continues by evaluating condition
        /// expressions against the input data. Use this category to define the condition that
        /// determines if the loop should continue. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ReturnValueToLoopStart</c> - Defines data to pass back to the start of the loop's
        /// next iteration. Use this category for variables that you want to update for each loop
        /// iteration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExitLoop</c> - Defines the value that's available once the loop ends. Use this
        /// category to expose loop results to nodes outside the loop.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FlowNodeInputCategory Category
        {
            get { return this._category; }
            set { this._category = value; }
        }

        // Check to see if Category property is set
        internal bool IsSetCategory()
        {
            return this._category != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// An expression that formats the input for the node. For an explanation of how to create
        /// expressions, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/flows-expressions.html">Expressions
        /// in Prompt flows in Amazon Bedrock</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=64)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies a name for the input that you can reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Specifies the data type of the input. If the input doesn't match this type at runtime,
        /// a validation error will be thrown.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowNodeIODataType Type
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