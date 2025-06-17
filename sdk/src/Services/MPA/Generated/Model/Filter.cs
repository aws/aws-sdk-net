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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains the filter to apply to requests. You can specify up to 10 filters for a request.
    /// </summary>
    public partial class Filter
    {
        private FilterField _fieldName;
        private Operator _operator;
        private string _value;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// Name of the filter to use.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Supported filters</b> 
        /// </para>
        ///  
        /// <para>
        /// The supported filters for <a>ListSessions</a> are: <c>ActionName</c>, <c>SessionStatus</c>,
        /// and <c>InitationTime</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public FilterField FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Operator to use for filtering.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>EQ</c>: Equal to the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NE</c>: Not equal to the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GT</c>: Greater than the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LT</c>: Less than the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GTE</c>: Greater than or equal to the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LTE</c>: Less than or equal to the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTAINS</c>: Contains the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NOT_CONTAINS</c>: Does not contain the specified value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BETWEEN</c>: Between two values, inclusive of the specified values.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <b>Supported operators for each filter</b>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ActionName</c>: <c>EQ</c> | <c>NE</c> | <c>CONTAINS</c> | <c>NOT_CONTAINS</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SessionStatus</c>: <c>EQ</c> | <c>NE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InitiationTime</c>: <c>GT</c> | <c>LT</c> | <c>GTE</c> | <c>LTE</c> | <c>BETWEEN</c>
        /// 
        /// </para>
        ///  </li> </ul> </note>
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

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Value to use for filtering. For the <c>BETWEEN</c> operator, specify values in the
        /// format <c>a AND b</c> (<c>AND</c> is case-insensitive).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Value
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