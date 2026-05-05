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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFinding operation.
    /// Updates the status or risk level of a security finding.
    /// </summary>
    public partial class UpdateFindingRequest : AmazonSecurityAgentRequest
    {
        private string _agentSpaceId;
        private string _findingId;
        private RiskLevel _riskLevel;
        private FindingStatus _status;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space that contains the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The unique identifier of the finding to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FindingId
        {
            get { return this._findingId; }
            set { this._findingId = value; }
        }

        // Check to see if FindingId property is set
        internal bool IsSetFindingId()
        {
            return this._findingId != null;
        }

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The updated risk level for the finding.
        /// </para>
        /// </summary>
        public RiskLevel RiskLevel
        {
            get { return this._riskLevel; }
            set { this._riskLevel = value; }
        }

        // Check to see if RiskLevel property is set
        internal bool IsSetRiskLevel()
        {
            return this._riskLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The updated status for the finding.
        /// </para>
        /// </summary>
        public FindingStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}