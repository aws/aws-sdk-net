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

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// If you are suppressing an anomaly temporariliy, this structure defines how long the
    /// suppression period is to be.
    /// </summary>
    public partial class SuppressionPeriod
    {
        /// <summary>
        /// Gets and sets the property SuppressionUnit. 
        /// <para>
        /// Specifies whether the value of <c>value</c> is in seconds, minutes, or hours.
        /// </para>
        /// </summary>
        public SuppressionUnit SuppressionUnit { get; set; }

        /// <summary>
        /// Checks to see if the SuppressionUnit property is set.
        /// </summary>
        internal bool IsSetSuppressionUnit() => this.SuppressionUnit != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// Specifies the number of seconds, minutes or hours to suppress this anomaly. There
        /// is no maximum.
        /// </para>
        /// </summary>
        public int? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
