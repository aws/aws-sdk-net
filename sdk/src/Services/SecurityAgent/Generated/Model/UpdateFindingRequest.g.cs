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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFinding operation. Updates the status or
    /// risk level of a security finding.
    /// </summary>
    public partial class UpdateFindingRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space that contains the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property AttackScript. 
        /// <para>
        /// The updated attack script for the finding.
        /// </para>
        /// </summary>
        public string AttackScript { get; set; }

        /// <summary>
        /// Checks to see if the AttackScript property is set.
        /// </summary>
        internal bool IsSetAttackScript() => this.AttackScript != null;

        /// <summary>
        /// Gets and sets the property CustomerNote. 
        /// <para>
        /// A customer-provided note on the finding.
        /// </para>
        /// </summary>
        public string CustomerNote { get; set; }

        /// <summary>
        /// Checks to see if the CustomerNote property is set.
        /// </summary>
        internal bool IsSetCustomerNote() => this.CustomerNote != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description for the finding.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The unique identifier of the finding to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for the finding.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Reasoning. 
        /// <para>
        /// The updated reasoning for the finding.
        /// </para>
        /// </summary>
        public string Reasoning { get; set; }

        /// <summary>
        /// Checks to see if the Reasoning property is set.
        /// </summary>
        internal bool IsSetReasoning() => this.Reasoning != null;

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The updated risk level for the finding.
        /// </para>
        /// </summary>
        public RiskLevel RiskLevel { get; set; }

        /// <summary>
        /// Checks to see if the RiskLevel property is set.
        /// </summary>
        internal bool IsSetRiskLevel() => this.RiskLevel != null;

        /// <summary>
        /// Gets and sets the property RiskScore. 
        /// <para>
        /// The updated numerical risk score for the finding.
        /// </para>
        /// </summary>
        public string RiskScore { get; set; }

        /// <summary>
        /// Checks to see if the RiskScore property is set.
        /// </summary>
        internal bool IsSetRiskScore() => this.RiskScore != null;

        /// <summary>
        /// Gets and sets the property RiskType. 
        /// <para>
        /// The updated risk type for the finding.
        /// </para>
        /// </summary>
        public string RiskType { get; set; }

        /// <summary>
        /// Checks to see if the RiskType property is set.
        /// </summary>
        internal bool IsSetRiskType() => this.RiskType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The updated status for the finding.
        /// </para>
        /// </summary>
        public FindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
