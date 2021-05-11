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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// A conditional statement with which to compare a value, after a timestamp, before a
    /// timestamp, or equal to a string or integer. If multiple conditions are specified,
    /// the conditionals become an <code>AND</code>ed statement. If multiple values are specified
    /// for a conditional, the values are <code>OR</code>d.
    /// </summary>
    public partial class Condition
    {
        private DateTime? _after;
        private DateTime? _before;
        private AttributeValueList _equals;

        /// <summary>
        /// Gets and sets the property After. 
        /// <para>
        /// After the specified timestamp.
        /// </para>
        /// </summary>
        public DateTime After
        {
            get { return this._after.GetValueOrDefault(); }
            set { this._after = value; }
        }

        // Check to see if After property is set
        internal bool IsSetAfter()
        {
            return this._after.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Before. 
        /// <para>
        /// Before the specified timestamp
        /// </para>
        /// </summary>
        public DateTime Before
        {
            get { return this._before.GetValueOrDefault(); }
            set { this._before = value; }
        }

        // Check to see if Before property is set
        internal bool IsSetBefore()
        {
            return this._before.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Equals. 
        /// <para>
        /// The value is equal to the provided string or integer. 
        /// </para>
        /// </summary>
        public AttributeValueList Equals
        {
            get { return this._equals; }
            set { this._equals = value; }
        }

        // Check to see if Equals property is set
        internal bool IsSetEquals()
        {
            return this._equals != null;
        }

    }
}