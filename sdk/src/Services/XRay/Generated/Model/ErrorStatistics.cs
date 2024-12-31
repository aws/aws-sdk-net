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
 * Do not modify this file. This file is generated from the xray-2016-04-12.normal.json service model.
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
namespace Amazon.XRay.Model
{
    /// <summary>
    /// Information about requests that failed with a 4xx Client Error status code.
    /// </summary>
    public partial class ErrorStatistics
    {
        private long? _otherCount;
        private long? _throttleCount;
        private long? _totalCount;

        /// <summary>
        /// Gets and sets the property OtherCount. 
        /// <para>
        /// The number of requests that failed with untracked 4xx Client Error status codes.
        /// </para>
        /// </summary>
        public long? OtherCount
        {
            get { return this._otherCount; }
            set { this._otherCount = value; }
        }

        // Check to see if OtherCount property is set
        internal bool IsSetOtherCount()
        {
            return this._otherCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThrottleCount. 
        /// <para>
        /// The number of requests that failed with a 429 throttling status code.
        /// </para>
        /// </summary>
        public long? ThrottleCount
        {
            get { return this._throttleCount; }
            set { this._throttleCount = value; }
        }

        // Check to see if ThrottleCount property is set
        internal bool IsSetThrottleCount()
        {
            return this._throttleCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of requests that failed with a 4xx Client Error status code.
        /// </para>
        /// </summary>
        public long? TotalCount
        {
            get { return this._totalCount; }
            set { this._totalCount = value; }
        }

        // Check to see if TotalCount property is set
        internal bool IsSetTotalCount()
        {
            return this._totalCount.HasValue; 
        }

    }
}