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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Represents the average latency for the slowest X percent of requests over the last
    /// 10 seconds.
    /// </summary>
    public partial class Latency
    {
        private double? _p10;
        private double? _p50;
        private double? _p75;
        private double? _p85;
        private double? _p90;
        private double? _p95;
        private double? _p99;
        private double? _p999;

        /// <summary>
        /// Gets and sets the property P10. 
        /// <para>
        /// The average latency for the slowest 90 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P10
        {
            get { return this._p10; }
            set { this._p10 = value; }
        }

        // Check to see if P10 property is set
        internal bool IsSetP10()
        {
            return this._p10.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P50. 
        /// <para>
        /// The average latency for the slowest 50 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P50
        {
            get { return this._p50; }
            set { this._p50 = value; }
        }

        // Check to see if P50 property is set
        internal bool IsSetP50()
        {
            return this._p50.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P75. 
        /// <para>
        /// The average latency for the slowest 25 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P75
        {
            get { return this._p75; }
            set { this._p75 = value; }
        }

        // Check to see if P75 property is set
        internal bool IsSetP75()
        {
            return this._p75.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P85. 
        /// <para>
        /// The average latency for the slowest 15 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P85
        {
            get { return this._p85; }
            set { this._p85 = value; }
        }

        // Check to see if P85 property is set
        internal bool IsSetP85()
        {
            return this._p85.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P90. 
        /// <para>
        /// The average latency for the slowest 10 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P90
        {
            get { return this._p90; }
            set { this._p90 = value; }
        }

        // Check to see if P90 property is set
        internal bool IsSetP90()
        {
            return this._p90.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P95. 
        /// <para>
        /// The average latency for the slowest 5 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P95
        {
            get { return this._p95; }
            set { this._p95 = value; }
        }

        // Check to see if P95 property is set
        internal bool IsSetP95()
        {
            return this._p95.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P99. 
        /// <para>
        /// The average latency for the slowest 1 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P99
        {
            get { return this._p99; }
            set { this._p99 = value; }
        }

        // Check to see if P99 property is set
        internal bool IsSetP99()
        {
            return this._p99.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property P999. 
        /// <para>
        /// The average latency for the slowest 0.1 percent of requests over the last 10 seconds.
        /// </para>
        /// </summary>
        public double? P999
        {
            get { return this._p999; }
            set { this._p999 = value; }
        }

        // Check to see if P999 property is set
        internal bool IsSetP999()
        {
            return this._p999.HasValue; 
        }

    }
}