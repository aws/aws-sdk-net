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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// A range of integer values.
    /// </summary>
    public partial class Range
    {
        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The minimum value in the range.
        /// </para>
        /// </summary>
        public int? From { get; set; }

        /// <summary>
        /// Checks to see if the From property is set.
        /// </summary>
        internal bool IsSetFrom() => this.From.HasValue;

        /// <summary>
        /// Gets and sets the property Step. 
        /// <para>
        /// The step value for the range. For example, if you have a range of 5,000 to 10,000,
        /// with a step value of 1,000, the valid values start at 5,000 and step up by 1,000.
        /// Even though 7,500 is within the range, it isn't a valid value for the range. The valid
        /// values are 5,000, 6,000, 7,000, 8,000...
        /// </para>
        /// </summary>
        public int? Step { get; set; }

        /// <summary>
        /// Checks to see if the Step property is set.
        /// </summary>
        internal bool IsSetStep() => this.Step.HasValue;

        /// <summary>
        /// Gets and sets the property To. 
        /// <para>
        /// The maximum value in the range.
        /// </para>
        /// </summary>
        public int? To { get; set; }

        /// <summary>
        /// Checks to see if the To property is set.
        /// </summary>
        internal bool IsSetTo() => this.To.HasValue;
    }
}
