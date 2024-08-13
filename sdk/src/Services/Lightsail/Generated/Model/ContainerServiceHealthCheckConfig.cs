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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the health check configuration of an Amazon Lightsail container service.
    /// </summary>
    public partial class ContainerServiceHealthCheckConfig
    {
        private int? _healthyThreshold;
        private int? _intervalSeconds;
        private string _path;
        private string _successCodes;
        private int? _timeoutSeconds;
        private int? _unhealthyThreshold;

        /// <summary>
        /// Gets and sets the property HealthyThreshold. 
        /// <para>
        /// The number of consecutive health checks successes required before moving the container
        /// to the <c>Healthy</c> state. The default value is <c>2</c>.
        /// </para>
        /// </summary>
        public int? HealthyThreshold
        {
            get { return this._healthyThreshold; }
            set { this._healthyThreshold = value; }
        }

        // Check to see if HealthyThreshold property is set
        internal bool IsSetHealthyThreshold()
        {
            return this._healthyThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntervalSeconds. 
        /// <para>
        /// The approximate interval, in seconds, between health checks of an individual container.
        /// You can specify between 5 and 300 seconds. The default value is <c>5</c>.
        /// </para>
        /// </summary>
        public int? IntervalSeconds
        {
            get { return this._intervalSeconds; }
            set { this._intervalSeconds = value; }
        }

        // Check to see if IntervalSeconds property is set
        internal bool IsSetIntervalSeconds()
        {
            return this._intervalSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path on the container on which to perform the health check. The default value
        /// is <c>/</c>.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property SuccessCodes. 
        /// <para>
        /// The HTTP codes to use when checking for a successful response from a container. You
        /// can specify values between <c>200</c> and <c>499</c>. You can specify multiple values
        /// (for example, <c>200,202</c>) or a range of values (for example, <c>200-299</c>).
        /// </para>
        /// </summary>
        public string SuccessCodes
        {
            get { return this._successCodes; }
            set { this._successCodes = value; }
        }

        // Check to see if SuccessCodes property is set
        internal bool IsSetSuccessCodes()
        {
            return this._successCodes != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutSeconds. 
        /// <para>
        /// The amount of time, in seconds, during which no response means a failed health check.
        /// You can specify between 2 and 60 seconds. The default value is <c>2</c>.
        /// </para>
        /// </summary>
        public int? TimeoutSeconds
        {
            get { return this._timeoutSeconds; }
            set { this._timeoutSeconds = value; }
        }

        // Check to see if TimeoutSeconds property is set
        internal bool IsSetTimeoutSeconds()
        {
            return this._timeoutSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyThreshold. 
        /// <para>
        /// The number of consecutive health check failures required before moving the container
        /// to the <c>Unhealthy</c> state. The default value is <c>2</c>.
        /// </para>
        /// </summary>
        public int? UnhealthyThreshold
        {
            get { return this._unhealthyThreshold; }
            set { this._unhealthyThreshold = value; }
        }

        // Check to see if UnhealthyThreshold property is set
        internal bool IsSetUnhealthyThreshold()
        {
            return this._unhealthyThreshold.HasValue; 
        }

    }
}