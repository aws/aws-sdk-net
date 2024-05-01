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
    /// Response statistics for an edge.
    /// </summary>
    public partial class EdgeStatistics
    {
        private ErrorStatistics _errorStatistics;
        private FaultStatistics _faultStatistics;
        private long? _okCount;
        private long? _totalCount;
        private double? _totalResponseTime;

        /// <summary>
        /// Gets and sets the property ErrorStatistics. 
        /// <para>
        /// Information about requests that failed with a 4xx Client Error status code.
        /// </para>
        /// </summary>
        public ErrorStatistics ErrorStatistics
        {
            get { return this._errorStatistics; }
            set { this._errorStatistics = value; }
        }

        // Check to see if ErrorStatistics property is set
        internal bool IsSetErrorStatistics()
        {
            return this._errorStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property FaultStatistics. 
        /// <para>
        /// Information about requests that failed with a 5xx Server Error status code.
        /// </para>
        /// </summary>
        public FaultStatistics FaultStatistics
        {
            get { return this._faultStatistics; }
            set { this._faultStatistics = value; }
        }

        // Check to see if FaultStatistics property is set
        internal bool IsSetFaultStatistics()
        {
            return this._faultStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property OkCount. 
        /// <para>
        /// The number of requests that completed with a 2xx Success status code.
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
        /// The total number of completed requests.
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

        /// <summary>
        /// Gets and sets the property TotalResponseTime. 
        /// <para>
        /// The aggregate response time of completed requests.
        /// </para>
        /// </summary>
        public double? TotalResponseTime
        {
            get { return this._totalResponseTime; }
            set { this._totalResponseTime = value; }
        }

        // Check to see if TotalResponseTime property is set
        internal bool IsSetTotalResponseTime()
        {
            return this._totalResponseTime.HasValue; 
        }

    }
}