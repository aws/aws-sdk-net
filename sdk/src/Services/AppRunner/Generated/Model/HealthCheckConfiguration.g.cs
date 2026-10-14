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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the settings for the health check that App Runner performs to monitor the
    /// health of a service.
    /// </summary>
    public partial class HealthCheckConfiguration
    {
        /// <summary>
        /// Gets and sets the property HealthyThreshold. 
        /// <para>
        /// The number of consecutive checks that must succeed before App Runner decides that
        /// the service is healthy.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>1</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// Checks to see if the HealthyThreshold property is set.
        /// </summary>
        internal bool IsSetHealthyThreshold() => this.HealthyThreshold.HasValue;

        /// <summary>
        /// Gets and sets the property Interval. 
        /// <para>
        /// The time interval, in seconds, between health checks.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>5</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? Interval { get; set; }

        /// <summary>
        /// Checks to see if the Interval property is set.
        /// </summary>
        internal bool IsSetInterval() => this.Interval.HasValue;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The URL that health check requests are sent to.
        /// </para>
        ///  
        /// <para>
        ///  <c>Path</c> is only applicable when you set <c>Protocol</c> to <c>HTTP</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>"/"</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The IP protocol that App Runner uses to perform health checks for your service.
        /// </para>
        ///  
        /// <para>
        /// If you set <c>Protocol</c> to <c>HTTP</c>, App Runner sends health check requests
        /// to the HTTP path specified by <c>Path</c>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>TCP</c> 
        /// </para>
        /// </summary>
        public HealthCheckProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The time, in seconds, to wait for a health check response before deciding it failed.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>2</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyThreshold. 
        /// <para>
        /// The number of consecutive checks that must fail before App Runner decides that the
        /// service is unhealthy.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>5</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyThreshold property is set.
        /// </summary>
        internal bool IsSetUnhealthyThreshold() => this.UnhealthyThreshold.HasValue;
    }
}
