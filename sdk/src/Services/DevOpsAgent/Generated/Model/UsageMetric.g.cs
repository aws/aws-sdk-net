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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Represents a usage metric with its configured limit and current usage value.
    /// </summary>
    public partial class UsageMetric
    {
        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// Configured limit for this metric. A value of -1 indicates no limit is enforced.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Usage. 
        /// <para>
        /// Current usage for this metric
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public double? Usage { get; set; }

        /// <summary>
        /// Checks to see if the Usage property is set.
        /// </summary>
        internal bool IsSetUsage() => this.Usage.HasValue;
    }
}
