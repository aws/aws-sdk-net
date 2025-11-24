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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Details for an uplink agent endpoint
    /// </summary>
    public partial class UplinkAwsGroundStationAgentEndpointDetails
    {
        private AgentStatus _agentStatus;
        private AuditResults _auditResults;
        private UplinkDataflowDetails _dataflowDetails;
        private string _name;

        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// Status of the agent associated with the uplink dataflow endpoint
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
        /// Health audit results for the uplink dataflow endpoint
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
        /// Gets and sets the property DataflowDetails. 
        /// <para>
        /// Dataflow details for the uplink endpoint
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public UplinkDataflowDetails DataflowDetails
        {
            get { return this._dataflowDetails; }
            set { this._dataflowDetails = value; }
        }

        // Check to see if DataflowDetails property is set
        internal bool IsSetDataflowDetails()
        {
            return this._dataflowDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Uplink dataflow endpoint name
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