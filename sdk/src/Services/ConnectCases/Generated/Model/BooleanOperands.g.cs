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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Boolean operands for a condition. In the Amazon Connect admin website, case rules
    /// are known as <i>case field conditions</i>. For more information about case field conditions,
    /// see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
    /// case field conditions to a case template</a>.
    /// </summary>
    public partial class BooleanOperands
    {
        /// <summary>
        /// Gets and sets the property OperandOne. 
        /// <para>
        /// Represents the left hand operand in the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperandOne OperandOne { get; set; }

        /// <summary>
        /// Checks to see if the OperandOne property is set.
        /// </summary>
        internal bool IsSetOperandOne() => this.OperandOne != null;

        /// <summary>
        /// Gets and sets the property OperandTwo. 
        /// <para>
        /// Represents the right hand operand in the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OperandTwo OperandTwo { get; set; }

        /// <summary>
        /// Checks to see if the OperandTwo property is set.
        /// </summary>
        internal bool IsSetOperandTwo() => this.OperandTwo != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The value of the outer rule if the condition evaluates to true.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result.HasValue;
    }
}
