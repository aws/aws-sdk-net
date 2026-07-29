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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
        private int? _inUse;
        private int? _maxAllowed;
        private int? _remaining;
        private string _totalBandwidth;

        /// <summary>
        /// Gets and sets the property InUse. 
        /// <para>
        /// The number of rate limiters currently in use on the connection.
        /// </para>
        /// </summary>
        public int? InUse
        {
            get { return this._inUse; }
            set { this._inUse = value; }
        }

        // Check to see if InUse property is set
        internal bool IsSetInUse()
        {
            return this._inUse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAllowed. 
        /// <para>
        /// The maximum number of rate limiters allowed on the connection.
        /// </para>
        /// </summary>
        public int? MaxAllowed
        {
            get { return this._maxAllowed; }
            set { this._maxAllowed = value; }
        }

        // Check to see if MaxAllowed property is set
        internal bool IsSetMaxAllowed()
        {
            return this._maxAllowed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Remaining. 
        /// <para>
        /// The number of rate limiters remaining (available) on the connection.
        /// </para>
        /// </summary>
        public int? Remaining
        {
            get { return this._remaining; }
            set { this._remaining = value; }
        }

        // Check to see if Remaining property is set
        internal bool IsSetRemaining()
        {
            return this._remaining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalBandwidth. 
        /// <para>
        /// The total bandwidth allocated across all rate limiters on the connection.
        /// </para>
        /// </summary>
        public string TotalBandwidth
        {
            get { return this._totalBandwidth; }
            set { this._totalBandwidth = value; }
        }

        // Check to see if TotalBandwidth property is set
        internal bool IsSetTotalBandwidth()
        {
            return this._totalBandwidth != null;
        }

    }
}