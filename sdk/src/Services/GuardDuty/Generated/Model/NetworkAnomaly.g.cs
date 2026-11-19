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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about how network activity deviates from normal behavior.
    /// </summary>
    public partial class NetworkAnomaly
    {
        /// <summary>
        /// Gets and sets the property BaselineBytes. 
        /// <para>
        /// The amount of data that is typical for the normal behavior.
        /// </para>
        /// </summary>
        public string BaselineBytes { get; set; }

        /// <summary>
        /// Checks to see if the BaselineBytes property is set.
        /// </summary>
        internal bool IsSetBaselineBytes() => this.BaselineBytes != null;

        /// <summary>
        /// Gets and sets the property Deviation. 
        /// <para>
        /// How much the activity deviates from normal behavior.
        /// </para>
        /// </summary>
        public string Deviation { get; set; }

        /// <summary>
        /// Checks to see if the Deviation property is set.
        /// </summary>
        internal bool IsSetDeviation() => this.Deviation != null;

        /// <summary>
        /// Gets and sets the property Duration. 
        /// <para>
        /// The duration of the activity.
        /// </para>
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Checks to see if the Duration property is set.
        /// </summary>
        internal bool IsSetDuration() => this.Duration != null;

        /// <summary>
        /// Gets and sets the property ProfileAgeDays. 
        /// <para>
        /// The number of days of activity that the normal behavior is based on.
        /// </para>
        /// </summary>
        public int? ProfileAgeDays { get; set; }

        /// <summary>
        /// Checks to see if the ProfileAgeDays property is set.
        /// </summary>
        internal bool IsSetProfileAgeDays() => this.ProfileAgeDays.HasValue;

        /// <summary>
        /// Gets and sets the property RemoteRegion. 
        /// <para>
        /// The Region of the remote endpoint.
        /// </para>
        /// </summary>
        public string RemoteRegion { get; set; }

        /// <summary>
        /// Checks to see if the RemoteRegion property is set.
        /// </summary>
        internal bool IsSetRemoteRegion() => this.RemoteRegion != null;

        /// <summary>
        /// Gets and sets the property RemoteService. 
        /// <para>
        /// The remote service that the activity involved.
        /// </para>
        /// </summary>
        public string RemoteService { get; set; }

        /// <summary>
        /// Checks to see if the RemoteService property is set.
        /// </summary>
        internal bool IsSetRemoteService() => this.RemoteService != null;

        /// <summary>
        /// Gets and sets the property ResetRatio. 
        /// <para>
        /// The ratio of connection attempts that were reset.
        /// </para>
        /// </summary>
        public string ResetRatio { get; set; }

        /// <summary>
        /// Checks to see if the ResetRatio property is set.
        /// </summary>
        internal bool IsSetResetRatio() => this.ResetRatio != null;

        /// <summary>
        /// Gets and sets the property TargetHostCount. 
        /// <para>
        /// The number of target hosts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TargetHostCount { get; set; }

        /// <summary>
        /// Checks to see if the TargetHostCount property is set.
        /// </summary>
        internal bool IsSetTargetHostCount() => this.TargetHostCount.HasValue;
    }
}
