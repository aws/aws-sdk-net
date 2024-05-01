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
    /// Statistics that describe how the incident has impacted a service.
    /// </summary>
    public partial class RequestImpactStatistics
    {
        private long? _faultCount;
        private long? _okCount;
        private long? _totalCount;

        /// <summary>
        /// Gets and sets the property FaultCount. 
        /// <para>
        /// The number of requests that have resulted in a fault,
        /// </para>
        /// </summary>
        public long? FaultCount
        {
            get { return this._faultCount; }
            set { this._faultCount = value; }
        }

        // Check to see if FaultCount property is set
        internal bool IsSetFaultCount()
        {
            return this._faultCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OkCount. 
        /// <para>
        /// The number of successful requests.
        /// </para>
        /// </summary>
        public long? OkCount
        {
            get { return this._okCount; }
            set { this._okCount = value; }
        }

        // Check to see if OkCount property is set
        internal bool IsSetOkCount()
        {
            return this._okCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCount. 
        /// <para>
        /// The total number of requests to the service.
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