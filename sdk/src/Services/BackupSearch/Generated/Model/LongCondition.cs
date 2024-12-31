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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// The long condition contains a <c>Value</c> and can optionally contain an <c>Operator</c>.
    /// </summary>
    public partial class LongCondition
    {
        private LongConditionOperator _operator;
        private long? _value;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// A string that defines what values will be returned.
        /// </para>
        ///  
        /// <para>
        /// If this is included, avoid combinations of operators that will return all possible
        /// values. For example, including both <c>EQUALS_TO</c> and <c>NOT_EQUALS_TO</c> with
        /// a value of <c>4</c> will return all values.
        /// </para>
        /// </summary>
        public LongConditionOperator Operator
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
        /// The value of an item included in one of the search item filters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long Value
        {
            get { return this._value.GetValueOrDefault(); }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value.HasValue; 
        }

    }
}