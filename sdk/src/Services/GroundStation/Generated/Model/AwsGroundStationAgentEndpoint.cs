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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about AwsGroundStationAgentEndpoint.
    /// </summary>
    public partial class AwsGroundStationAgentEndpoint
    {
        private AgentStatus _agentStatus;
        private AuditResults _auditResults;
        private ConnectionDetails _egressAddress;
        private RangedConnectionDetails _ingressAddress;
        private string _name;

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of AgentEndpoint.
        /// </para>
        /// </summary>
        public AgentStatus AgentStatus
        {
            get { return this._agentStatus; }
            set { this._agentStatus = value; }
        }

        // Check to see if AgentStatus property is set
        internal bool IsSetAgentStatus()
        {
            return this._agentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AuditResults. 
        /// <para>
        /// The results of the audit.
        /// </para>
        /// </summary>
        public AuditResults AuditResults
        {
            get { return this._auditResults; }
            set { this._auditResults = value; }
        }

        // Check to see if AuditResults property is set
        internal bool IsSetAuditResults()
        {
            return this._auditResults != null;
        }

        /// <summary>
        /// Gets and sets the property EgressAddress. 
        /// <para>
        /// The egress address of AgentEndpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionDetails EgressAddress
        {
            get { return this._egressAddress; }
            set { this._egressAddress = value; }
        }

        // Check to see if EgressAddress property is set
        internal bool IsSetEgressAddress()
        {
            return this._egressAddress != null;
        }

        /// <summary>
        /// Gets and sets the property IngressAddress. 
        /// <para>
        /// The ingress address of AgentEndpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RangedConnectionDetails IngressAddress
        {
            get { return this._ingressAddress; }
            set { this._ingressAddress = value; }
        }

        // Check to see if IngressAddress property is set
        internal bool IsSetIngressAddress()
        {
            return this._ingressAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name string associated with AgentEndpoint. Used as a human-readable identifier for
        /// AgentEndpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}