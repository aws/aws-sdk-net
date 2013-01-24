/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> The HealthCheck data type. </para>
    /// </summary>
    public class HealthCheck  
    {
        
        private string target;
        private int? interval;
        private int? timeout;
        private int? unhealthyThreshold;
        private int? healthyThreshold;
        /// <summary>
        /// Default constructor for a new HealthCheck object.  Callers should use the
        /// properties or fluent setter (With...) methods to initialize this object after creating it.
        /// </summary>
        public HealthCheck() {}
    
        /// <summary>
        /// Constructs a new HealthCheck object.
        /// Callers should use the properties or fluent setter (With...) methods to
        /// initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="target"> Specifies the instance being checked. The protocol is either TCP, HTTP, HTTPS, or SSL. The range of valid ports is one
        /// (1) through 65535. <note> TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this case a healthcheck simply
        /// attempts to open a TCP connection to the instance on the specified port. Failure to connect within the configured timeout is considered
        /// unhealthy. SSL is also specified as SSL: port pair, for example, SSL:5000. For HTTP or HTTPS protocol, the situation is different. You have
        /// to include a ping path in the string. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example "HTTP:80/weather/us/wa/seattle".
        /// In this case, a HTTP GET request is issued to the instance on the given port and path. Any answer other than "200 OK" within the timeout
        /// period is considered unhealthy. The total length of the HTTP ping target needs to be 1024 16-bit Unicode characters or less. </note>
        /// </param>
        /// <param name="interval"> Specifies the approximate interval, in seconds, between health checks of an individual instance. </param>
        /// <param name="timeout"> Specifies the amount of time, in seconds, during which no response means a failed health probe. <note> This value
        /// must be less than the <i>Interval</i> value. </note> </param>
        /// <param name="unhealthyThreshold"> Specifies the number of consecutive health probe failures required before moving the instance to the
        /// <i>Unhealthy</i> state. </param>
        /// <param name="healthyThreshold"> Specifies the number of consecutive health probe successes required before moving the instance to the
        /// <i>Healthy</i> state. </param>
        public HealthCheck(string target, int interval, int timeout, int unhealthyThreshold, int healthyThreshold) 
        {
            this.target = target;
            this.interval = interval;
            this.timeout = timeout;
            this.unhealthyThreshold = unhealthyThreshold;
            this.healthyThreshold = healthyThreshold;
        }
    

        /// <summary>
        /// Specifies the instance being checked. The protocol is either TCP, HTTP, HTTPS, or SSL. The range of valid ports is one (1) through 65535.
        /// <note> TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this case a healthcheck simply attempts to open a TCP
        /// connection to the instance on the specified port. Failure to connect within the configured timeout is considered unhealthy. SSL is also
        /// specified as SSL: port pair, for example, SSL:5000. For HTTP or HTTPS protocol, the situation is different. You have to include a ping path
        /// in the string. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example "HTTP:80/weather/us/wa/seattle". In this case, a HTTP
        /// GET request is issued to the instance on the given port and path. Any answer other than "200 OK" within the timeout period is considered
        /// unhealthy. The total length of the HTTP ping target needs to be 1024 16-bit Unicode characters or less. </note>
        ///  
        /// </summary>
        public string Target
        {
            get { return this.target; }
            set { this.target = value; }
        }

        /// <summary>
        /// Sets the Target property
        /// </summary>
        /// <param name="target">The value to set for the Target property </param>
        /// <returns>this instance</returns>
        public HealthCheck WithTarget(string target)
        {
            this.target = target;
            return this;
        }
            

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this.target != null;       
        }

        /// <summary>
        /// Specifies the approximate interval, in seconds, between health checks of an individual instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 300</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Interval
        {
            get { return this.interval ?? default(int); }
            set { this.interval = value; }
        }

        /// <summary>
        /// Sets the Interval property
        /// </summary>
        /// <param name="interval">The value to set for the Interval property </param>
        /// <returns>this instance</returns>
        public HealthCheck WithInterval(int interval)
        {
            this.interval = interval;
            return this;
        }
            

        // Check to see if Interval property is set
        internal bool IsSetInterval()
        {
            return this.interval.HasValue;       
        }

        /// <summary>
        /// Specifies the amount of time, in seconds, during which no response means a failed health probe. <note> This value must be less than the
        /// <i>Interval</i> value. </note>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 300</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int Timeout
        {
            get { return this.timeout ?? default(int); }
            set { this.timeout = value; }
        }

        /// <summary>
        /// Sets the Timeout property
        /// </summary>
        /// <param name="timeout">The value to set for the Timeout property </param>
        /// <returns>this instance</returns>
        public HealthCheck WithTimeout(int timeout)
        {
            this.timeout = timeout;
            return this;
        }
            

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this.timeout.HasValue;       
        }

        /// <summary>
        /// Specifies the number of consecutive health probe failures required before moving the instance to the <i>Unhealthy</i> state.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>2 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int UnhealthyThreshold
        {
            get { return this.unhealthyThreshold ?? default(int); }
            set { this.unhealthyThreshold = value; }
        }

        /// <summary>
        /// Sets the UnhealthyThreshold property
        /// </summary>
        /// <param name="unhealthyThreshold">The value to set for the UnhealthyThreshold property </param>
        /// <returns>this instance</returns>
        public HealthCheck WithUnhealthyThreshold(int unhealthyThreshold)
        {
            this.unhealthyThreshold = unhealthyThreshold;
            return this;
        }
            

        // Check to see if UnhealthyThreshold property is set
        internal bool IsSetUnhealthyThreshold()
        {
            return this.unhealthyThreshold.HasValue;       
        }

        /// <summary>
        /// Specifies the number of consecutive health probe successes required before moving the instance to the <i>Healthy</i> state.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>2 - 10</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int HealthyThreshold
        {
            get { return this.healthyThreshold ?? default(int); }
            set { this.healthyThreshold = value; }
        }

        /// <summary>
        /// Sets the HealthyThreshold property
        /// </summary>
        /// <param name="healthyThreshold">The value to set for the HealthyThreshold property </param>
        /// <returns>this instance</returns>
        public HealthCheck WithHealthyThreshold(int healthyThreshold)
        {
            this.healthyThreshold = healthyThreshold;
            return this;
        }
            

        // Check to see if HealthyThreshold property is set
        internal bool IsSetHealthyThreshold()
        {
            return this.healthyThreshold.HasValue;       
        }
    }
}
