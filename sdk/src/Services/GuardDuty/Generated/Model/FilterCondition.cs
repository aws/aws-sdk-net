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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the condition.
    /// </summary>
    public partial class FilterCondition
    {
        private string _equalsValue;
        private long? _greaterThan;
        private long? _lessThan;

        /// <summary>
        /// Gets and sets the property EqualsValue. 
        /// <para>
        /// Represents an <i>equal</i> <b/> condition to be applied to a single field when querying
        /// for scan entries.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string EqualsValue
        {
            get { return this._equalsValue; }
            set { this._equalsValue = value; }
        }

        // Check to see if EqualsValue property is set
        internal bool IsSetEqualsValue()
        {
            return this._equalsValue != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Represents a <i>greater than</i> condition to be applied to a single field when querying
        /// for scan entries.
        /// </para>
        /// </summary>
        public long? GreaterThan
        {
            get { return this._greaterThan; }
            set { this._greaterThan = value; }
        }

        // Check to see if GreaterThan property is set
        internal bool IsSetGreaterThan()
        {
            return this._greaterThan.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Represents a <i>less than</i> condition to be applied to a single field when querying
        /// for scan entries.
        /// </para>
        /// </summary>
        public long? LessThan
        {
            get { return this._lessThan; }
            set { this._lessThan = value; }
        }

        // Check to see if LessThan property is set
        internal bool IsSetLessThan()
        {
            return this._lessThan.HasValue; 
        }

    }
}