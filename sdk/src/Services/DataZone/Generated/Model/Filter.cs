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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// A search filter in Amazon DataZone.
    /// </summary>
    public partial class Filter
    {
        private string _attribute;
        private long? _intValue;
        private FilterOperator _operator;
        private string _value;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// A search filter attribute in Amazon DataZone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property IntValue. 
        /// <para>
        /// A search filter integer value in Amazon DataZone.
        /// </para>
        /// </summary>
        public long? IntValue
        {
            get { return this._intValue; }
            set { this._intValue = value; }
        }

        // Check to see if IntValue property is set
        internal bool IsSetIntValue()
        {
            return this._intValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Specifies the search filter operator.
        /// </para>
        /// </summary>
        public FilterOperator Operator
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
        /// A search filter string value in Amazon DataZone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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