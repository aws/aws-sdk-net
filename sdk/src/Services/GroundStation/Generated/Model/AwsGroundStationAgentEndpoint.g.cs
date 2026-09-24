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

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Information about AwsGroundStationAgentEndpoint.
    /// </summary>
    public partial class AwsGroundStationAgentEndpoint
    {
        /// <summary>
        /// Gets and sets the property AgentStatus. 
        /// <para>
        /// The status of AgentEndpoint.
        /// </para>
        /// </summary>
        public AgentStatus AgentStatus { get; set; }

        /// <summary>
        /// Checks to see if the AgentStatus property is set.
        /// </summary>
        internal bool IsSetAgentStatus() => this.AgentStatus != null;

        /// <summary>
        /// Gets and sets the property AuditResults. 
        /// <para>
        /// The results of the audit.
        /// </para>
        /// </summary>
        public AuditResults AuditResults { get; set; }

        /// <summary>
        /// Checks to see if the AuditResults property is set.
        /// </summary>
        internal bool IsSetAuditResults() => this.AuditResults != null;

        /// <summary>
        /// Gets and sets the property EgressAddress. 
        /// <para>
        /// The egress address of AgentEndpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConnectionDetails EgressAddress { get; set; }

        /// <summary>
        /// Checks to see if the EgressAddress property is set.
        /// </summary>
        internal bool IsSetEgressAddress() => this.EgressAddress != null;

        /// <summary>
        /// Gets and sets the property IngressAddress. 
        /// <para>
        /// The ingress address of AgentEndpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RangedConnectionDetails IngressAddress { get; set; }

        /// <summary>
        /// Checks to see if the IngressAddress property is set.
        /// </summary>
        internal bool IsSetIngressAddress() => this.IngressAddress != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name string associated with AgentEndpoint. Used as a human-readable identifier for
        /// AgentEndpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
