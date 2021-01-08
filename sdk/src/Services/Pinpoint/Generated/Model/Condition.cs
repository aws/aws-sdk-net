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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the conditions to evaluate for an activity in a journey, and how to evaluate
    /// those conditions.
    /// </summary>
    public partial class Condition
    {
        private List<SimpleCondition> _conditions = new List<SimpleCondition>();
        private Operator _operator;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// The conditions to evaluate for the activity.
        /// </para>
        /// </summary>
        public List<SimpleCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && this._conditions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Specifies how to handle multiple conditions for the activity. For example, if you
        /// specify two conditions for an activity, whether both or only one of the conditions
        /// must be met for the activity to be performed.
        /// </para>
        /// </summary>
        public Operator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

    }
}