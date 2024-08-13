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
    /// The inventory data for installed Agentless Collector collectors.
    /// </summary>
    public partial class CustomerAgentlessCollectorInfo
    {
        private int? _activeAgentlessCollectors;
        private int? _denyListedAgentlessCollectors;
        private int? _healthyAgentlessCollectors;
        private int? _shutdownAgentlessCollectors;
        private int? _totalAgentlessCollectors;
        private int? _unhealthyAgentlessCollectors;
        private int? _unknownAgentlessCollectors;

        /// <summary>
        /// Gets and sets the property ActiveAgentlessCollectors. 
        /// <para>
        /// The number of active Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ActiveAgentlessCollectors
        {
            get { return this._activeAgentlessCollectors; }
            set { this._activeAgentlessCollectors = value; }
        }

        // Check to see if ActiveAgentlessCollectors property is set
        internal bool IsSetActiveAgentlessCollectors()
        {
            return this._activeAgentlessCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DenyListedAgentlessCollectors. 
        /// <para>
        /// The number of deny-listed Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DenyListedAgentlessCollectors
        {
            get { return this._denyListedAgentlessCollectors; }
            set { this._denyListedAgentlessCollectors = value; }
        }

        // Check to see if DenyListedAgentlessCollectors property is set
        internal bool IsSetDenyListedAgentlessCollectors()
        {
            return this._denyListedAgentlessCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthyAgentlessCollectors. 
        /// <para>
        /// The number of healthy Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? HealthyAgentlessCollectors
        {
            get { return this._healthyAgentlessCollectors; }
            set { this._healthyAgentlessCollectors = value; }
        }

        // Check to see if HealthyAgentlessCollectors property is set
        internal bool IsSetHealthyAgentlessCollectors()
        {
            return this._healthyAgentlessCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShutdownAgentlessCollectors. 
        /// <para>
        /// The number of Agentless Collector collectors with <c>SHUTDOWN</c> status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ShutdownAgentlessCollectors
        {
            get { return this._shutdownAgentlessCollectors; }
            set { this._shutdownAgentlessCollectors = value; }
        }

        // Check to see if ShutdownAgentlessCollectors property is set
        internal bool IsSetShutdownAgentlessCollectors()
        {
            return this._shutdownAgentlessCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalAgentlessCollectors. 
        /// <para>
        ///  The total number of Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalAgentlessCollectors
        {
            get { return this._totalAgentlessCollectors; }
            set { this._totalAgentlessCollectors = value; }
        }

        // Check to see if TotalAgentlessCollectors property is set
        internal bool IsSetTotalAgentlessCollectors()
        {
            return this._totalAgentlessCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnhealthyAgentlessCollectors. 
        /// <para>
        ///  The number of unhealthy Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnhealthyAgentlessCollectors
        {
            get { return this._unhealthyAgentlessCollectors; }
            set { this._unhealthyAgentlessCollectors = value; }
        }

        // Check to see if UnhealthyAgentlessCollectors property is set
        internal bool IsSetUnhealthyAgentlessCollectors()
        {
            return this._unhealthyAgentlessCollectors.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnknownAgentlessCollectors. 
        /// <para>
        ///  The number of unknown Agentless Collector collectors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? UnknownAgentlessCollectors
        {
            get { return this._unknownAgentlessCollectors; }
            set { this._unknownAgentlessCollectors = value; }
        }

        // Check to see if UnknownAgentlessCollectors property is set
        internal bool IsSetUnknownAgentlessCollectors()
        {
            return this._unknownAgentlessCollectors.HasValue; 
        }

    }
}