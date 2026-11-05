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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// The inventory data for installed Agentless Collector collectors.
    /// </summary>
    public partial class CustomerAgentlessCollectorInfo
    {
        /// <summary>
        /// Gets and sets the property ActiveAgentlessCollectors. 
        /// <para>
        /// The number of active Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ActiveAgentlessCollectors { get; set; }

        /// <summary>
        /// Checks to see if the ActiveAgentlessCollectors property is set.
        /// </summary>
        internal bool IsSetActiveAgentlessCollectors() => this.ActiveAgentlessCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property DenyListedAgentlessCollectors. 
        /// <para>
        /// The number of deny-listed Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DenyListedAgentlessCollectors { get; set; }

        /// <summary>
        /// Checks to see if the DenyListedAgentlessCollectors property is set.
        /// </summary>
        internal bool IsSetDenyListedAgentlessCollectors() => this.DenyListedAgentlessCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property HealthyAgentlessCollectors. 
        /// <para>
        /// The number of healthy Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HealthyAgentlessCollectors { get; set; }

        /// <summary>
        /// Checks to see if the HealthyAgentlessCollectors property is set.
        /// </summary>
        internal bool IsSetHealthyAgentlessCollectors() => this.HealthyAgentlessCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property ShutdownAgentlessCollectors. 
        /// <para>
        /// The number of Agentless Collector collectors with <c>SHUTDOWN</c> status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ShutdownAgentlessCollectors { get; set; }

        /// <summary>
        /// Checks to see if the ShutdownAgentlessCollectors property is set.
        /// </summary>
        internal bool IsSetShutdownAgentlessCollectors() => this.ShutdownAgentlessCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property TotalAgentlessCollectors. 
        /// <para>
        ///  The total number of Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalAgentlessCollectors { get; set; }

        /// <summary>
        /// Checks to see if the TotalAgentlessCollectors property is set.
        /// </summary>
        internal bool IsSetTotalAgentlessCollectors() => this.TotalAgentlessCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyAgentlessCollectors. 
        /// <para>
        ///  The number of unhealthy Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnhealthyAgentlessCollectors { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyAgentlessCollectors property is set.
        /// </summary>
        internal bool IsSetUnhealthyAgentlessCollectors() => this.UnhealthyAgentlessCollectors.HasValue;

        /// <summary>
        /// Gets and sets the property UnknownAgentlessCollectors. 
        /// <para>
        ///  The number of unknown Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnknownAgentlessCollectors { get; set; }

        /// <summary>
        /// Checks to see if the UnknownAgentlessCollectors property is set.
        /// </summary>
        internal bool IsSetUnknownAgentlessCollectors() => this.UnknownAgentlessCollectors.HasValue;
    }
}
