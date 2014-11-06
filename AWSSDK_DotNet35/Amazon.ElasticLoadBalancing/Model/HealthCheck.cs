/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// The HealthCheck data type.
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
        /// <param name="target"> Specifies the instance being checked. The protocol is either TCP, HTTP, HTTPS, or SSL. The range of valid ports is one (1) through 65535.  <note>  TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this case a healthcheck simply attempts to open a TCP connection to the instance on the specified port. Failure to connect within the configured timeout is considered unhealthy.  SSL is also specified as SSL: port pair, for example, SSL:5000.  For HTTP or HTTPS protocol, the situation is different. You have to include a ping path in the string. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example "HTTP:80/weather/us/wa/seattle". In this case, a HTTP GET request is issued to the instance on the given port and path. Any answer other than "200 OK" within the timeout period is considered unhealthy.   The total length of the HTTP ping target needs to be 1024 16-bit Unicode characters or less.  </note></param>
        /// <param name="interval"> Specifies the approximate interval, in seconds, between health checks of an individual instance. </param>
        /// <param name="timeout"> Specifies the amount of time, in seconds, during which no response means a failed health probe.  <note> This value must be less than the <i>Interval</i> value. </note></param>
        /// <param name="unhealthyThreshold"> Specifies the number of consecutive health probe failures required before moving the instance to the <i>Unhealthy</i> state. </param>
        /// <param name="healthyThreshold"> Specifies the number of consecutive health probe successes required before moving the instance to the <i>Healthy</i> state. </param>
        public HealthCheck(string target, int interval, int timeout, int unhealthyThreshold, int healthyThreshold)
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
        ///  Specifies the number of consecutive health probe successes required before moving
        /// the instance to the <i>Healthy</i> state. 
        /// </para>
        /// </summary>
        public int HealthyThreshold
        {
            get { return this._healthyThreshold.GetValueOrDefault(); }
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
        ///  Specifies the approximate interval, in seconds, between health checks of an individual
        /// instance. 
        /// </para>
        /// </summary>
        public int Interval
        {
            get { return this._interval.GetValueOrDefault(); }
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
        ///  Specifies the instance being checked. The protocol is either TCP, HTTP, HTTPS, or
        /// SSL. The range of valid ports is one (1) through 65535. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this
        /// case a healthcheck simply attempts to open a TCP connection to the instance on the
        /// specified port. Failure to connect within the configured timeout is considered unhealthy.
        /// 
        /// </para>
        ///  
        /// <para>
        /// SSL is also specified as SSL: port pair, for example, SSL:5000.
        /// </para>
        ///  
        /// <para>
        ///  For HTTP or HTTPS protocol, the situation is different. You have to include a ping
        /// path in the string. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example
        /// "HTTP:80/weather/us/wa/seattle". In this case, a HTTP GET request is issued to the
        /// instance on the given port and path. Any answer other than "200 OK" within the timeout
        /// period is considered unhealthy. 
        /// </para>
        ///  
        /// <para>
        ///  The total length of the HTTP ping target needs to be 1024 16-bit Unicode characters
        /// or less. 
        /// </para>
        ///  </note>
        /// </summary>
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
        ///  Specifies the amount of time, in seconds, during which no response means a failed
        /// health probe. 
        /// </para>
        ///  <note> This value must be less than the <i>Interval</i> value. </note>
        /// </summary>
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
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
        ///  Specifies the number of consecutive health probe failures required before moving
        /// the instance to the <i>Unhealthy</i> state. 
        /// </para>
        /// </summary>
        public int UnhealthyThreshold
        {
            get { return this._unhealthyThreshold.GetValueOrDefault(); }
            set { this._unhealthyThreshold = value; }
        }

        // Check to see if UnhealthyThreshold property is set
        internal bool IsSetUnhealthyThreshold()
        {
            return this._unhealthyThreshold.HasValue; 
        }

    }
}