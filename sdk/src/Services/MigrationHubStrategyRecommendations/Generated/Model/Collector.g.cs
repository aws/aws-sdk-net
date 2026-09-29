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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Process data collector that runs in the environment that you specify.
    /// </summary>
    public partial class Collector
    {
        /// <summary>
        /// Gets and sets the property CollectorHealth. 
        /// <para>
        ///  Indicates the health of a collector. 
        /// </para>
        /// </summary>
        public CollectorHealth CollectorHealth { get; set; }

        /// <summary>
        /// Checks to see if the CollectorHealth property is set.
        /// </summary>
        internal bool IsSetCollectorHealth() => this.CollectorHealth != null;

        /// <summary>
        /// Gets and sets the property CollectorId. 
        /// <para>
        ///  The ID of the collector. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CollectorId { get; set; }

        /// <summary>
        /// Checks to see if the CollectorId property is set.
        /// </summary>
        internal bool IsSetCollectorId() => this.CollectorId != null;

        /// <summary>
        /// Gets and sets the property CollectorVersion. 
        /// <para>
        ///  Current version of the collector that is running in the environment that you specify.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string CollectorVersion { get; set; }

        /// <summary>
        /// Checks to see if the CollectorVersion property is set.
        /// </summary>
        internal bool IsSetCollectorVersion() => this.CollectorVersion != null;

        /// <summary>
        /// Gets and sets the property ConfigurationSummary. 
        /// <para>
        /// Summary of the collector configuration.
        /// </para>
        /// </summary>
        public ConfigurationSummary ConfigurationSummary { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSummary property is set.
        /// </summary>
        internal bool IsSetConfigurationSummary() => this.ConfigurationSummary != null;

        /// <summary>
        /// Gets and sets the property HostName. 
        /// <para>
        ///  Hostname of the server that is hosting the collector. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string HostName { get; set; }

        /// <summary>
        /// Checks to see if the HostName property is set.
        /// </summary>
        internal bool IsSetHostName() => this.HostName != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        ///  IP address of the server that is hosting the collector. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property LastActivityTimeStamp. 
        /// <para>
        ///  Time when the collector last pinged the service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string LastActivityTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the LastActivityTimeStamp property is set.
        /// </summary>
        internal bool IsSetLastActivityTimeStamp() => this.LastActivityTimeStamp != null;

        /// <summary>
        /// Gets and sets the property RegisteredTimeStamp. 
        /// <para>
        ///  Time when the collector registered with the service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string RegisteredTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredTimeStamp property is set.
        /// </summary>
        internal bool IsSetRegisteredTimeStamp() => this.RegisteredTimeStamp != null;
    }
}
