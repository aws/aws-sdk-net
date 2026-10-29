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

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Contains information about the rate limiter status for a connection, including the
    /// maximum number of rate limiters allowed, the number currently in use, and the remaining
    /// capacity.
    /// </summary>
    public partial class RateLimiterStatus
    {
        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// The number of rate limiters currently in use on the connection.
        /// </para>
        /// </summary>
        public int? InUse { get; set; }

        /// <summary>
        /// Checks to see if the InUse property is set.
        /// </summary>
        internal bool IsSetInUse() => this.InUse.HasValue;

        /// <summary>
        /// Gets and sets the property MaxAllowed. 
        /// <para>
        /// The maximum number of rate limiters allowed on the connection.
        /// </para>
        /// </summary>
        public int? MaxAllowed { get; set; }

        /// <summary>
        /// Checks to see if the MaxAllowed property is set.
        /// </summary>
        internal bool IsSetMaxAllowed() => this.MaxAllowed.HasValue;

        /// <summary>
        /// Gets and sets the property Remaining. 
        /// <para>
        /// The number of rate limiters remaining (available) on the connection.
        /// </para>
        /// </summary>
        public int? Remaining { get; set; }

        /// <summary>
        /// Checks to see if the Remaining property is set.
        /// </summary>
        internal bool IsSetRemaining() => this.Remaining.HasValue;

        /// <summary>
        /// Gets and sets the property TotalBandwidth. 
        /// <para>
        /// The total bandwidth allocated across all rate limiters on the connection.
        /// </para>
        /// </summary>
        public string TotalBandwidth { get; set; }

        /// <summary>
        /// Checks to see if the TotalBandwidth property is set.
        /// </summary>
        internal bool IsSetTotalBandwidth() => this.TotalBandwidth != null;
    }
}
