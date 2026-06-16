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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A physical constraint for a quote.
    /// </summary>
    public partial class QuoteConstraint
    {
        private QuoteConstraintType _quoteConstraintType;
        private string _value;

        /// <summary>
        /// Gets and sets the property QuoteConstraintType. 
        /// <para>
        /// The type of constraint. Valid values are <c>RACK_MAXIMUM</c>, <c>RACK_MAX_POWER_KVA</c>,
        /// and <c>RACK_MAX_WEIGHT_LBS</c>.
        /// </para>
        /// </summary>
        public QuoteConstraintType QuoteConstraintType
        {
            get { return this._quoteConstraintType; }
            set { this._quoteConstraintType = value; }
        }

        // Check to see if QuoteConstraintType property is set
        internal bool IsSetQuoteConstraintType()
        {
            return this._quoteConstraintType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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