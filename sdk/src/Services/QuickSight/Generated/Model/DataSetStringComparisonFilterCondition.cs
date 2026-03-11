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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter condition that compares string values using operators like <c>EQUALS</c>,
    /// <c>CONTAINS</c>, or <c>STARTS_WITH</c>.
    /// </summary>
    public partial class DataSetStringComparisonFilterCondition
    {
        private DataSetStringComparisonFilterOperator _operator;
        private DataSetStringFilterValue _value;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The comparison operator to use, such as <c>EQUALS</c>, <c>CONTAINS</c>, <c>STARTS_WITH</c>,
        /// <c>ENDS_WITH</c>, or their negations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSetStringComparisonFilterOperator Operator
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The string value to compare against.
        /// </para>
        /// </summary>
        public DataSetStringFilterValue Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}