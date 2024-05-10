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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
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
namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Information about a health check.
    /// </summary>
    public partial class HealthCheck
    {
        private int? _healthyThreshold;
        private int? _interval;
        private string _target;
        private int? _timeout;
        private int? _unhealthyThreshold;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public HealthCheck() { }

        /// <summary>
        /// Instantiates HealthCheck with the parameterized properties
        /// </summary>
        /// <param name="target">The instance being checked. The protocol is either TCP, HTTP, HTTPS, or SSL. The range of valid ports is one (1) through 65535. TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this case, a health check simply attempts to open a TCP connection to the instance on the specified port. Failure to connect within the configured timeout is considered unhealthy. SSL is also specified as SSL: port pair, for example, SSL:5000. For HTTP/HTTPS, you must include a ping path in the string. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example "HTTP:80/weather/us/wa/seattle". In this case, a HTTP GET request is issued to the instance on the given port and path. Any answer other than "200 OK" within the timeout period is considered unhealthy. The total length of the HTTP ping target must be 1024 16-bit Unicode characters or less.</param>
        /// <param name="interval">The approximate interval, in seconds, between health checks of an individual instance.</param>
        /// <param name="timeout">The amount of time, in seconds, during which no response means a failed health check. This value must be less than the <c>Interval</c> value.</param>
        /// <param name="unhealthyThreshold">The number of consecutive health check failures required before moving the instance to the <c>Unhealthy</c> state.</param>
        /// <param name="healthyThreshold">The number of consecutive health checks successes required before moving the instance to the <c>Healthy</c> state.</param>
        public HealthCheck(string target, int? interval, int? timeout, int? unhealthyThreshold, int? healthyThreshold)
        {
            _target = target;
            _interval = interval;
            _timeout = timeout;
            _unhealthyThreshold = unhealthyThreshold;
            _healthyThreshold = healthyThreshold;
        }

        /// <summary>
        /// Gets and sets the property HealthyThreshold. 
        /// <para>
        /// The number of consecutive health checks successes required before moving the instance
        /// to the <c>Healthy</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=10)]
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
        /// Gets and sets the property Interval. 
        /// <para>
        /// The approximate interval, in seconds, between health checks of an individual instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=300)]
        public int? Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this._interval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The instance being checked. The protocol is either TCP, HTTP, HTTPS, or SSL. The range
        /// of valid ports is one (1) through 65535.
        /// </para>
        ///  
        /// <para>
        /// TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this
        /// case, a health check simply attempts to open a TCP connection to the instance on the
        /// specified port. Failure to connect within the configured timeout is considered unhealthy.
        /// </para>
        ///  
        /// <para>
        /// SSL is also specified as SSL: port pair, for example, SSL:5000.
        /// </para>
        ///  
        /// <para>
        /// For HTTP/HTTPS, you must include a ping path in the string. HTTP is specified as a
        /// HTTP:port;/;PathToPing; grouping, for example "HTTP:80/weather/us/wa/seattle". In
        /// this case, a HTTP GET request is issued to the instance on the given port and path.
        /// Any answer other than "200 OK" within the timeout period is considered unhealthy.
        /// </para>
        ///  
        /// <para>
        /// The total length of the HTTP ping target must be 1024 16-bit Unicode characters or
        /// less.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The amount of time, in seconds, during which no response means a failed health check.
        /// </para>
        ///  
        /// <para>
        /// This value must be less than the <c>Interval</c> value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=60)]
        public int? Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyThreshold. 
        /// <para>
        /// The number of consecutive health check failures required before moving the instance
        /// to the <c>Unhealthy</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=10)]
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