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
    /// Inventory data for installed discovery agents.
    /// </summary>
    public partial class CustomerAgentInfo
    {
        /// <summary>
        /// Gets and sets the property ActiveAgents. 
        /// <para>
        /// Number of active discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ActiveAgents { get; set; }

        /// <summary>
        /// Checks to see if the ActiveAgents property is set.
        /// </summary>
        internal bool IsSetActiveAgents() => this.ActiveAgents.HasValue;

        /// <summary>
        /// Gets and sets the property BlackListedAgents. 
        /// <para>
        /// Number of blacklisted discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? BlackListedAgents { get; set; }

        /// <summary>
        /// Checks to see if the BlackListedAgents property is set.
        /// </summary>
        internal bool IsSetBlackListedAgents() => this.BlackListedAgents.HasValue;

        /// <summary>
        /// Gets and sets the property HealthyAgents. 
        /// <para>
        /// Number of healthy discovery agents
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? HealthyAgents { get; set; }

        /// <summary>
        /// Checks to see if the HealthyAgents property is set.
        /// </summary>
        internal bool IsSetHealthyAgents() => this.HealthyAgents.HasValue;

        /// <summary>
        /// Gets and sets the property ShutdownAgents. 
        /// <para>
        /// Number of discovery agents with status SHUTDOWN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? ShutdownAgents { get; set; }

        /// <summary>
        /// Checks to see if the ShutdownAgents property is set.
        /// </summary>
        internal bool IsSetShutdownAgents() => this.ShutdownAgents.HasValue;

        /// <summary>
        /// Gets and sets the property TotalAgents. 
        /// <para>
        /// Total number of discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalAgents { get; set; }

        /// <summary>
        /// Checks to see if the TotalAgents property is set.
        /// </summary>
        internal bool IsSetTotalAgents() => this.TotalAgents.HasValue;

        /// <summary>
        /// Gets and sets the property UnhealthyAgents. 
        /// <para>
        /// Number of unhealthy discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnhealthyAgents { get; set; }

        /// <summary>
        /// Checks to see if the UnhealthyAgents property is set.
        /// </summary>
        internal bool IsSetUnhealthyAgents() => this.UnhealthyAgents.HasValue;

        /// <summary>
        /// Gets and sets the property UnknownAgents. 
        /// <para>
        /// Number of unknown discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? UnknownAgents { get; set; }

        /// <summary>
        /// Checks to see if the UnknownAgents property is set.
        /// </summary>
        internal bool IsSetUnknownAgents() => this.UnknownAgents.HasValue;
    }
}
