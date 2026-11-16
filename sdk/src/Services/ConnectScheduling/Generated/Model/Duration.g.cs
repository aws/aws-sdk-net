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

namespace Amazon.ConnectScheduling.Model
{
    /// <summary>
    /// A length of time, expressed as a value and the unit it is counted in.
    /// </summary>
    public partial class Duration
    {
        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit the value is counted in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DurationUnit Unit { get; set; }

        /// <summary>
        /// Checks to see if the Unit property is set.
        /// </summary>
        internal bool IsSetUnit() => this.Unit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The number of units of time. You can use a negative value to report an overdrawn balance.
        /// The value must be within 876,000 hours (100 years) of zero: at most 52,560,000 <c>MINUTES</c>,
        /// 876,000 <c>HOURS</c>, or 36,500 <c>DAYS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = -52560000, Max = 52560000)]
        public int? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
