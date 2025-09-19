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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// This is the response object from the UpdateAgentRuntime operation.
    /// </summary>
    public partial class UpdateAgentRuntimeResponse : AmazonWebServiceResponse
    {
        private string _agentRuntimeArn;
        private string _agentRuntimeId;
        private string _agentRuntimeVersion;
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private AgentRuntimeStatus _status;
        private WorkloadIdentityDetails _workloadIdentityDetails;

        /// <summary>
        /// Gets and sets the property AgentRuntimeArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the updated AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeArn
        {
            get { return this._agentRuntimeArn; }
            set { this._agentRuntimeArn = value; }
        }

        // Check to see if AgentRuntimeArn property is set
        internal bool IsSetAgentRuntimeArn()
        {
            return this._agentRuntimeArn != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeId. 
        /// <para>
        /// The unique identifier of the updated AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentRuntimeId
        {
            get { return this._agentRuntimeId; }
            set { this._agentRuntimeId = value; }
        }

        // Check to see if AgentRuntimeId property is set
        internal bool IsSetAgentRuntimeId()
        {
            return this._agentRuntimeId != null;
        }

        /// <summary>
        /// Gets and sets the property AgentRuntimeVersion. 
        /// <para>
        /// The version of the updated AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public string AgentRuntimeVersion
        {
            get { return this._agentRuntimeVersion; }
            set { this._agentRuntimeVersion = value; }
        }

        // Check to see if AgentRuntimeVersion property is set
        internal bool IsSetAgentRuntimeVersion()
        {
            return this._agentRuntimeVersion != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the AgentCore Runtime was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The timestamp when the AgentCore Runtime was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated AgentCore Runtime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AgentRuntimeStatus Status
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
        /// Gets and sets the property WorkloadIdentityDetails. 
        /// <para>
        /// The workload identity details for the updated AgentCore Runtime.
        /// </para>
        /// </summary>
        public WorkloadIdentityDetails WorkloadIdentityDetails
        {
            get { return this._workloadIdentityDetails; }
            set { this._workloadIdentityDetails = value; }
        }

        // Check to see if WorkloadIdentityDetails property is set
        internal bool IsSetWorkloadIdentityDetails()
        {
            return this._workloadIdentityDetails != null;
        }

    }
}