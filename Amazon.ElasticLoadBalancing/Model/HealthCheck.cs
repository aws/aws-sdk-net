/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.ElasticLoadBalancing.Model
{
    ///<summary>
    ///A health probe to determine if the instance in the LoadBalancer should take requests.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://elasticloadbalancing.amazonaws.com/doc/2009-05-15/", IsNullable = false)]
    public class HealthCheck
    {
        private string targetField;
        private Decimal? intervalField;
        private Decimal? timeoutField;
        private Decimal? unhealthyThresholdField;
        private Decimal? healthyThresholdField;

        /// <summary>
        /// Gets and sets the Target property.
        /// The instance being checked. The protocol is either TCP or HTTP. The range of valid ports is one (1) through 65535.
        ///
        /// TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this case a healthcheck simply attempts
        /// to open a TCP connection to the instance on the specified port. Failure to connect within the configured timeout is
        /// considered unhealthy.
        ///
        /// For HTTP, the situation is different. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example
        /// "HTTP:80/weather/us/wa/seattle". In this case, a HTTP GET request is issued to the instance on the given port
        /// and path. Any answer other than "200 OK" within the timeout period is considered unhealthy.
        ///
        /// The total length of the HTTP ping target needs to be 1024 16-bit Unicode characters or less.
        /// </summary>
        [XmlElementAttribute(ElementName = "Target")]
        public string Target
        {
            get { return this.targetField ; }
            set { this.targetField= value; }
        }

        /// <summary>
        /// Sets the Target property
        /// </summary>
        /// <param name="target">The instance being checked. The protocol is either TCP or HTTP. The range of valid ports is one (1) through 65535.
        ///
        /// TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this case a healthcheck simply attempts
        /// to open a TCP connection to the instance on the specified port. Failure to connect within the configured timeout is
        /// considered unhealthy.
        ///
        /// For HTTP, the situation is different. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example
        /// "HTTP:80/weather/us/wa/seattle". In this case, a HTTP GET request is issued to the instance on the given port
        /// and path. Any answer other than "200 OK" within the timeout period is considered unhealthy.
        ///
        /// The total length of the HTTP ping target needs to be 1024 16-bit Unicode characters or less.</param>
        /// <returns>this instance</returns>
        public HealthCheck WithTarget(string target)
        {
            this.targetField = target;
            return this;
        }

        /// <summary>
        /// Checks if Target property is set
        /// </summary>
        /// <returns>true if Target property is set</returns>
        public bool IsSetTarget()
        {
            return  this.targetField != null;
        }

        /// <summary>
        /// Gets and sets the Interval property.
        /// The approximate interval (in seconds) between health checks of an individual instance. The default is 30 seconds and
        /// a valid interval must be between 5 seconds and 600 seconds. Also, the interval value must be greater than the Timeout
        /// value.
        /// </summary>
        [XmlElementAttribute(ElementName = "Interval")]
        public Decimal Interval
        {
            get { return this.intervalField.GetValueOrDefault() ; }
            set { this.intervalField= value; }
        }

        /// <summary>
        /// Sets the Interval property
        /// </summary>
        /// <param name="interval">The approximate interval (in seconds) between health checks of an individual instance. The default is 30 seconds and
        /// a valid interval must be between 5 seconds and 600 seconds. Also, the interval value must be greater than the Timeout
        /// value.</param>
        /// <returns>this instance</returns>
        public HealthCheck WithInterval(Decimal interval)
        {
            this.intervalField = interval;
            return this;
        }

        /// <summary>
        /// Checks if Interval property is set
        /// </summary>
        /// <returns>true if Interval property is set</returns>
        public bool IsSetInterval()
        {
            return  this.intervalField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Timeout property.
        /// Amount of time (in seconds) during which no response means a failed health probe. The default is five seconds and a
        /// valid value must be between 2 seconds and 60 seconds. Also, the timeout value must be less than the Interval value.
        /// </summary>
        [XmlElementAttribute(ElementName = "Timeout")]
        public Decimal Timeout
        {
            get { return this.timeoutField.GetValueOrDefault() ; }
            set { this.timeoutField= value; }
        }

        /// <summary>
        /// Sets the Timeout property
        /// </summary>
        /// <param name="timeout">Amount of time (in seconds) during which no response means a failed health probe. The default is five seconds and a
        /// valid value must be between 2 seconds and 60 seconds. Also, the timeout value must be less than the Interval value.</param>
        /// <returns>this instance</returns>
        public HealthCheck WithTimeout(Decimal timeout)
        {
            this.timeoutField = timeout;
            return this;
        }

        /// <summary>
        /// Checks if Timeout property is set
        /// </summary>
        /// <returns>true if Timeout property is set</returns>
        public bool IsSetTimeout()
        {
            return  this.timeoutField.HasValue;
        }

        /// <summary>
        /// Gets and sets the UnhealthyThreshold property.
        /// The number of consecutive health probe failures that move the instance to the unhealthy state. The default is 5 and a
        /// valid value lies between 2 and 10.
        /// </summary>
        [XmlElementAttribute(ElementName = "UnhealthyThreshold")]
        public Decimal UnhealthyThreshold
        {
            get { return this.unhealthyThresholdField.GetValueOrDefault() ; }
            set { this.unhealthyThresholdField= value; }
        }

        /// <summary>
        /// Sets the UnhealthyThreshold property
        /// </summary>
        /// <param name="unhealthyThreshold">The number of consecutive health probe failures that move the instance to the unhealthy state. The default is 5 and a
        /// valid value lies between 2 and 10.</param>
        /// <returns>this instance</returns>
        public HealthCheck WithUnhealthyThreshold(Decimal unhealthyThreshold)
        {
            this.unhealthyThresholdField = unhealthyThreshold;
            return this;
        }

        /// <summary>
        /// Checks if UnhealthyThreshold property is set
        /// </summary>
        /// <returns>true if UnhealthyThreshold property is set</returns>
        public bool IsSetUnhealthyThreshold()
        {
            return  this.unhealthyThresholdField.HasValue;
        }

        /// <summary>
        /// Gets and sets the HealthyThreshold property.
        /// The number of consecutive health probe successes required before moving the instance to the Healthy state. The default is
        /// three and a valid value lies between two and ten.
        /// </summary>
        [XmlElementAttribute(ElementName = "HealthyThreshold")]
        public Decimal HealthyThreshold
        {
            get { return this.healthyThresholdField.GetValueOrDefault() ; }
            set { this.healthyThresholdField= value; }
        }

        /// <summary>
        /// Sets the HealthyThreshold property
        /// </summary>
        /// <param name="healthyThreshold">The number of consecutive health probe successes required before moving the instance to the Healthy state. The default is
        /// three and a valid value lies between two and ten.</param>
        /// <returns>this instance</returns>
        public HealthCheck WithHealthyThreshold(Decimal healthyThreshold)
        {
            this.healthyThresholdField = healthyThreshold;
            return this;
        }

        /// <summary>
        /// Checks if HealthyThreshold property is set
        /// </summary>
        /// <returns>true if HealthyThreshold property is set</returns>
        public bool IsSetHealthyThreshold()
        {
            return  this.healthyThresholdField.HasValue;
        }

    }
}
