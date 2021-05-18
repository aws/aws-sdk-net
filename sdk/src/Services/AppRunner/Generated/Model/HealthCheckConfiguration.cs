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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the settings for the health check that AWS App Runner performs to monitor
    /// the health of a service.
    /// </summary>
    public partial class HealthCheckConfiguration
    {
        private int? _healthyThreshold;
        private int? _interval;
        private string _path;
        private HealthCheckProtocol _protocol;
        private int? _timeout;
        private int? _unhealthyThreshold;

        /// <summary>
        /// Gets and sets the property HealthyThreshold. 
        /// <para>
        /// The number of consecutive checks that must succeed before App Runner decides that
        /// the service is healthy.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>3</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// The time interval, in seconds, between health checks.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>5</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The URL that health check requests are sent to.
        /// </para>
        ///  
        /// <para>
        ///  <code>Path</code> is only applicable when you set <code>Protocol</code> to <code>HTTP</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>"/"</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=51200)]
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IP protocol that App Runner uses to perform health checks for your service.
        /// </para>
        ///  
        /// <para>
        /// If you set <code>Protocol</code> to <code>HTTP</code>, App Runner sends health check
        /// requests to the HTTP path specified by <code>Path</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>TCP</code> 
        /// </para>
        /// </summary>
        public HealthCheckProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The time, in seconds, to wait for a health check response before deciding it failed.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>2</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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
        /// The number of consecutive checks that must fail before App Runner decides that the
        /// service is unhealthy.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>3</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
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