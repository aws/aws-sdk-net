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
    /// Represents a policy generation request within the AgentCore Policy system. Tracks
    /// the AI-powered conversion of natural language descriptions into Cedar policy statements,
    /// enabling users to author policies by describing authorization requirements in plain
    /// English. The generation process analyzes the natural language input along with the
    /// Gateway's tool context and Cedar schema to produce one or more validated policy options.
    /// Each generation request tracks the status of the conversion process and maintains
    /// findings about the generated policies, including validation results and potential
    /// issues. Generated policy assets remain available for one week after successful generation,
    /// allowing time to review and create policies from the generated options.
    /// </summary>
    public partial class PolicyGeneration
    {
        private DateTime? _createdAt;
        private string _findings;
        private string _name;
        private string _policyEngineId;
        private string _policyGenerationArn;
        private string _policyGenerationId;
        private Resource _resource;
        private PolicyGenerationStatus _status;
        private List<string> _statusReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when this policy generation request was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// Findings and insights from this policy generation process.
        /// </para>
        /// </summary>
        public string Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The customer-assigned name for this policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
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
        /// Gets and sets the property PolicyEngineId. 
        /// <para>
        /// The identifier of the policy engine associated with this generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyEngineId
        {
            get { return this._policyEngineId; }
            set { this._policyEngineId = value; }
        }

        // Check to see if PolicyEngineId property is set
        internal bool IsSetPolicyEngineId()
        {
            return this._policyEngineId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyGenerationArn. 
        /// <para>
        /// The ARN of this policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=103, Max=210)]
        public string PolicyGenerationArn
        {
            get { return this._policyGenerationArn; }
            set { this._policyGenerationArn = value; }
        }

        // Check to see if PolicyGenerationArn property is set
        internal bool IsSetPolicyGenerationArn()
        {
            return this._policyGenerationArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyGenerationId. 
        /// <para>
        /// The unique identifier for this policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=59)]
        public string PolicyGenerationId
        {
            get { return this._policyGenerationId; }
            set { this._policyGenerationId = value; }
        }

        // Check to see if PolicyGenerationId property is set
        internal bool IsSetPolicyGenerationId()
        {
            return this._policyGenerationId != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource information associated with this policy generation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this policy generation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyGenerationStatus Status
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
        /// Gets and sets the property StatusReasons. 
        /// <para>
        /// Additional information about the generation status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> StatusReasons
        {
            get { return this._statusReasons; }
            set { this._statusReasons = value; }
        }

        // Check to see if StatusReasons property is set
        internal bool IsSetStatusReasons()
        {
            return this._statusReasons != null && (this._statusReasons.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when this policy generation was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}