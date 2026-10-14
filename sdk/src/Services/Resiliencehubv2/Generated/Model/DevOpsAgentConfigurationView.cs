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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
        private string _agentSpaceArn;
        private string _agentSpaceId;
        private DateTime? _connectedAt;
        private string _operatorAppUrl;
        private string _region;
        private DevOpsAgentConnectionStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AgentSpaceArn. 
        /// <para>
        /// The ARN of the linked DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AgentSpaceArn
        {
            get { return this._agentSpaceArn; }
            set { this._agentSpaceArn = value; }
        }

        // Check to see if AgentSpaceArn property is set
        internal bool IsSetAgentSpaceArn()
        {
            return this._agentSpaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The identifier of the linked DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectedAt. 
        /// <para>
        /// The timestamp when the service successfully connected to the DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        public DateTime? ConnectedAt
        {
            get { return this._connectedAt; }
            set { this._connectedAt = value; }
        }

        // Check to see if ConnectedAt property is set
        internal bool IsSetConnectedAt()
        {
            return this._connectedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperatorAppUrl. 
        /// <para>
        /// The URL of the DevOps Agent Operator App for the linked Agent Space. This URL is present
        /// when the connection status is CONNECTED.
        /// </para>
        /// </summary>
        public string OperatorAppUrl
        {
            get { return this._operatorAppUrl; }
            set { this._operatorAppUrl = value; }
        }

        // Check to see if OperatorAppUrl property is set
        internal bool IsSetOperatorAppUrl()
        {
            return this._operatorAppUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The AWS Region of the linked DevOps Agent Agent Space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

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
        public DevOpsAgentConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable explanation of the current connection status. This field explains
        /// the status when the connection fails.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}