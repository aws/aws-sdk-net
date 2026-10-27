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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property EqualsValue. 
        /// <para>
        /// Represents an <i>equal</i> <b/> condition to be applied to a single field when querying
        /// for scan entries.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string EqualsValue { get; set; }

        /// <summary>
        /// Checks to see if the EqualsValue property is set.
        /// </summary>
        internal bool IsSetEqualsValue() => this.EqualsValue != null;

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// Represents a <i>greater than</i> condition to be applied to a single field when querying
        /// for scan entries.
        /// </para>
        /// </summary>
        public long? GreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThan property is set.
        /// </summary>
        internal bool IsSetGreaterThan() => this.GreaterThan.HasValue;

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// Represents a <i>less than</i> condition to be applied to a single field when querying
        /// for scan entries.
        /// </para>
        /// </summary>
        public long? LessThan { get; set; }

        /// <summary>
        /// Checks to see if the LessThan property is set.
        /// </summary>
        internal bool IsSetLessThan() => this.LessThan.HasValue;
    }
}
