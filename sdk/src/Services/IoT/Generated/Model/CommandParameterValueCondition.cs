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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// A condition for the command parameter that must be evaluated to true for successful
    /// creation of a command execution.
    /// </summary>
    public partial class CommandParameterValueCondition
    {
        private CommandParameterValueComparisonOperator _comparisonOperator;
        private CommandParameterValueComparisonOperand _operand;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The comparison operator for the command parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// IN_RANGE, and NOT_IN_RANGE operators include boundary values.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public CommandParameterValueComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property Operand. 
        /// <para>
        /// The comparison operand for the command parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CommandParameterValueComparisonOperand Operand
        {
            get { return this._operand; }
            set { this._operand = value; }
        }

        // Check to see if Operand property is set
        internal bool IsSetOperand()
        {
            return this._operand != null;
        }

    }
}