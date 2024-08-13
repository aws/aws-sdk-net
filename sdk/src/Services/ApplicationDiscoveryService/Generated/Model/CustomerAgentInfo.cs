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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
        private int? _activeAgents;
        private int? _blackListedAgents;
        private int? _healthyAgents;
        private int? _shutdownAgents;
        private int? _totalAgents;
        private int? _unhealthyAgents;
        private int? _unknownAgents;

        /// <summary>
        /// Gets and sets the property ActiveAgents. 
        /// <para>
        /// Number of active discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ActiveAgents
        {
            get { return this._activeAgents; }
            set { this._activeAgents = value; }
        }

        // Check to see if ActiveAgents property is set
        internal bool IsSetActiveAgents()
        {
            return this._activeAgents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlackListedAgents. 
        /// <para>
        /// Number of blacklisted discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? BlackListedAgents
        {
            get { return this._blackListedAgents; }
            set { this._blackListedAgents = value; }
        }

        // Check to see if BlackListedAgents property is set
        internal bool IsSetBlackListedAgents()
        {
            return this._blackListedAgents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthyAgents. 
        /// <para>
        /// Number of healthy discovery agents
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? HealthyAgents
        {
            get { return this._healthyAgents; }
            set { this._healthyAgents = value; }
        }

        // Check to see if HealthyAgents property is set
        internal bool IsSetHealthyAgents()
        {
            return this._healthyAgents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShutdownAgents. 
        /// <para>
        /// Number of discovery agents with status SHUTDOWN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ShutdownAgents
        {
            get { return this._shutdownAgents; }
            set { this._shutdownAgents = value; }
        }

        // Check to see if ShutdownAgents property is set
        internal bool IsSetShutdownAgents()
        {
            return this._shutdownAgents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalAgents. 
        /// <para>
        /// Total number of discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalAgents
        {
            get { return this._totalAgents; }
            set { this._totalAgents = value; }
        }

        // Check to see if TotalAgents property is set
        internal bool IsSetTotalAgents()
        {
            return this._totalAgents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyAgents. 
        /// <para>
        /// Number of unhealthy discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnhealthyAgents
        {
            get { return this._unhealthyAgents; }
            set { this._unhealthyAgents = value; }
        }

        // Check to see if UnhealthyAgents property is set
        internal bool IsSetUnhealthyAgents()
        {
            return this._unhealthyAgents.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnknownAgents. 
        /// <para>
        /// Number of unknown discovery agents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnknownAgents
        {
            get { return this._unknownAgents; }
            set { this._unknownAgents = value; }
        }

        // Check to see if UnknownAgents property is set
        internal bool IsSetUnknownAgents()
        {
            return this._unknownAgents.HasValue; 
        }

    }
}