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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// The current DevOps Agent integration state for a service. Read operations return this
    /// state.
    /// </summary>
    public partial class DevOpsAgentConfigurationView
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceArn. 
        /// <para>
        /// The ARN of the linked DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AgentSpaceArn { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceArn property is set.
        /// </summary>
        internal bool IsSetAgentSpaceArn() => this.AgentSpaceArn != null;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The identifier of the linked DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property ConnectedAt. 
        /// <para>
        /// The timestamp when the service successfully connected to the DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        public DateTime? ConnectedAt { get; set; }

        /// <summary>
        /// Checks to see if the ConnectedAt property is set.
        /// </summary>
        internal bool IsSetConnectedAt() => this.ConnectedAt.HasValue;

        /// <summary>
        /// Gets and sets the property OperatorAppUrl. 
        /// <para>
        /// The URL of the DevOps Agent Operator App for the linked Agent Space. This URL is present
        /// when the connection status is CONNECTED.
        /// </para>
        /// </summary>
        public string OperatorAppUrl { get; set; }

        /// <summary>
        /// Checks to see if the OperatorAppUrl property is set.
        /// </summary>
        internal bool IsSetOperatorAppUrl() => this.OperatorAppUrl != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region of the linked DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The connection status of the DevOps Agent integration for this service. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CONNECTING - The service is being connected to the Agent Space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CONNECTED - The service is connected to the Agent Space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DISCONNECTED - The service is not connected to an Agent Space.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The connection attempt failed. See statusReason for details.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DevOpsAgentConnectionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current connection status. This field explains
        /// the status when the connection fails.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
