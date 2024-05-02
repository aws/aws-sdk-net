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
 * Do not modify this file. This file is generated from the iotevents-data-2018-10-23.normal.json service model.
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
namespace Amazon.IoTEventsData.Model
{
    /// <summary>
    /// Information needed to compare two values with a comparison operator.
    /// </summary>
    public partial class SimpleRuleEvaluation
    {
        private string _inputPropertyValue;
        private ComparisonOperator _operator;
        private string _thresholdValue;

        /// <summary>
        /// Gets and sets the property InputPropertyValue. 
        /// <para>
        /// The value of the input property, on the left side of the comparison operator.
        /// </para>
        /// </summary>
        public string InputPropertyValue
        {
            get { return this._inputPropertyValue; }
            set { this._inputPropertyValue = value; }
        }

        // Check to see if InputPropertyValue property is set
        internal bool IsSetInputPropertyValue()
        {
            return this._inputPropertyValue != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The comparison operator.
        /// </para>
        /// </summary>
        public ComparisonOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

        /// <summary>
        /// Gets and sets the property ThresholdValue. 
        /// <para>
        /// The threshold value, on the right side of the comparison operator.
        /// </para>
        /// </summary>
        public string ThresholdValue
        {
            get { return this._thresholdValue; }
            set { this._thresholdValue = value; }
        }

        // Check to see if ThresholdValue property is set
        internal bool IsSetThresholdValue()
        {
            return this._thresholdValue != null;
        }

    }
}