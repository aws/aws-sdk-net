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
    /// Represents a security vulnerability or issue discovered during testing
    /// </summary>
    public partial class Finding
    {
        private string _agentSpaceId;
        private string _attackScript;
        private CodeRemediationTask _codeRemediationTask;
        private ConfidenceLevel _confidence;
        private DateTime? _createdAt;
        private string _description;
        private string _findingId;
        private string _lastUpdatedBy;
        private string _name;
        private string _pentestId;
        private string _pentestJobId;
        private string _reasoning;
        private RiskLevel _riskLevel;
        private string _riskScore;
        private string _riskType;
        private FindingStatus _status;
        private string _taskId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// Identifier of the agent space that created this finding
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
        /// Gets and sets the property AttackScript. 
        /// <para>
        /// Proof-of-concept code demonstrating the vulnerability
        /// </para>
        /// </summary>
        public string AttackScript
        {
            get { return this._attackScript; }
            set { this._attackScript = value; }
        }

        // Check to see if AttackScript property is set
        internal bool IsSetAttackScript()
        {
            return this._attackScript != null;
        }

        /// <summary>
        /// Gets and sets the property CodeRemediationTask. 
        /// <para>
        /// Code remediation task associated with this finding
        /// </para>
        /// </summary>
        public CodeRemediationTask CodeRemediationTask
        {
            get { return this._codeRemediationTask; }
            set { this._codeRemediationTask = value; }
        }

        // Check to see if CodeRemediationTask property is set
        internal bool IsSetCodeRemediationTask()
        {
            return this._codeRemediationTask != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Confidence level of the finding
        /// </para>
        /// </summary>
        public ConfidenceLevel Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the finding was created
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Detailed description of the security vulnerability
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// Unique identifier for the finding
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
        /// Gets and sets the property LastUpdatedBy. 
        /// <para>
        /// Identifier of the task or agent that last updated this finding
        /// </para>
        /// </summary>
        public string LastUpdatedBy
        {
            get { return this._lastUpdatedBy; }
            set { this._lastUpdatedBy = value; }
        }

        // Check to see if LastUpdatedBy property is set
        internal bool IsSetLastUpdatedBy()
        {
            return this._lastUpdatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name or title of the finding
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property PentestId. 
        /// <para>
        /// Identifier of the parent pentest
        /// </para>
        /// </summary>
        public string PentestId
        {
            get { return this._pentestId; }
            set { this._pentestId = value; }
        }

        // Check to see if PentestId property is set
        internal bool IsSetPentestId()
        {
            return this._pentestId != null;
        }

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// Identifier of the pentest job
        /// </para>
        /// </summary>
        public string PentestJobId
        {
            get { return this._pentestJobId; }
            set { this._pentestJobId = value; }
        }

        // Check to see if PentestJobId property is set
        internal bool IsSetPentestJobId()
        {
            return this._pentestJobId != null;
        }

        /// <summary>
        /// Gets and sets the property Reasoning. 
        /// <para>
        /// Justification for the assigned risk score
        /// </para>
        /// </summary>
        public string Reasoning
        {
            get { return this._reasoning; }
            set { this._reasoning = value; }
        }

        // Check to see if Reasoning property is set
        internal bool IsSetReasoning()
        {
            return this._reasoning != null;
        }

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// Severity level of the identified risk
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
        /// Gets and sets the property RiskScore. 
        /// <para>
        /// Risk score associated with the finding
        /// </para>
        /// </summary>
        public string RiskScore
        {
            get { return this._riskScore; }
            set { this._riskScore = value; }
        }

        // Check to see if RiskScore property is set
        internal bool IsSetRiskScore()
        {
            return this._riskScore != null;
        }

        /// <summary>
        /// Gets and sets the property RiskType. 
        /// <para>
        /// Type of security risk identified
        /// </para>
        /// </summary>
        public string RiskType
        {
            get { return this._riskType; }
            set { this._riskType = value; }
        }

        // Check to see if RiskType property is set
        internal bool IsSetRiskType()
        {
            return this._riskType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the finding
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

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Identifier of the associated task
        /// </para>
        /// </summary>
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when the finding was last updated
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}