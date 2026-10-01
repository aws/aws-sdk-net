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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The value input pf the numeric range filter.
    /// </summary>
    public partial class NumericRangeFilterValue
    {
        /// <summary>
        /// Gets and sets the property Parameter. 
        /// <para>
        /// The parameter that is used in the numeric range.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Parameter { get; set; }

        /// <summary>
        /// Checks to see if the Parameter property is set.
        /// </summary>
        internal bool IsSetParameter() => this.Parameter != null;

        /// <summary>
        /// Gets and sets the property StaticValue. 
        /// <para>
        /// The static value of the numeric range filter.
        /// </para>
        /// </summary>
        public double? StaticValue { get; set; }

        /// <summary>
        /// Checks to see if the StaticValue property is set.
        /// </summary>
        internal bool IsSetStaticValue() => this.StaticValue.HasValue;
    }
}
