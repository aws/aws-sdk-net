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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A single logging filter, used in <a>LoggingFilter</a>.
    /// </summary>
    public partial class Filter
    {
        private FilterBehavior _behavior;
        private List<Condition> _conditions = new List<Condition>();
        private FilterRequirement _requirement;

        /// <summary>
        /// Gets and sets the property Behavior. 
        /// <para>
        /// How to handle logs that satisfy the filter's conditions and requirement. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterBehavior Behavior
        {
            get { return this._behavior; }
            set { this._behavior = value; }
        }

        // Check to see if Behavior property is set
        internal bool IsSetBehavior()
        {
            return this._behavior != null;
        }

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// Match conditions for the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<Condition> Conditions
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
        /// Gets and sets the property Requirement. 
        /// <para>
        /// Logic to apply to the filtering conditions. You can specify that, in order to satisfy
        /// the filter, a log must match all conditions or must match at least one condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterRequirement Requirement
        {
            get { return this._requirement; }
            set { this._requirement = value; }
        }

        // Check to see if Requirement property is set
        internal bool IsSetRequirement()
        {
            return this._requirement != null;
        }

    }
}