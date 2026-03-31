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
    /// Output for the CreateAgentSpace operation
    /// </summary>
    public partial class CreateAgentSpaceResponse : AmazonWebServiceResponse
    {
        private string _agentSpaceId;
        private AWSResources _awsResources;
        private CodeReviewSettings _codeReviewSettings;
        private DateTime? _createdAt;
        private string _description;
        private string _kmsKeyId;
        private string _name;
        private List<string> _targetDomainIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// Unique identifier of the created agent space
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
        /// Gets and sets the property AwsResources. 
        /// <para>
        /// AWS resource configurations associated with the agent space
        /// </para>
        /// </summary>
        public AWSResources AwsResources
        {
            get { return this._awsResources; }
            set { this._awsResources = value; }
        }

        // Check to see if AwsResources property is set
        internal bool IsSetAwsResources()
        {
            return this._awsResources != null;
        }

        /// <summary>
        /// Gets and sets the property CodeReviewSettings. 
        /// <para>
        /// Configuration for code review analysis, including controls scanning and general purpose
        /// scanning settings
        /// </para>
        /// </summary>
        public CodeReviewSettings CodeReviewSettings
        {
            get { return this._codeReviewSettings; }
            set { this._codeReviewSettings = value; }
        }

        // Check to see if CodeReviewSettings property is set
        internal bool IsSetCodeReviewSettings()
        {
            return this._codeReviewSettings != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp when the agent space was created
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
        /// Description of the created agent space
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
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Identifier of the KMS key used to encrypt data. Can be a key ID, key ARN, alias name,
        /// or alias ARN. If not specified, an AWS managed key is used.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the created agent space
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TargetDomainIds. 
        /// <para>
        /// List of target domain IDs registered with the agent space
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetDomainIds
        {
            get { return this._targetDomainIds; }
            set { this._targetDomainIds = value; }
        }

        // Check to see if TargetDomainIds property is set
        internal bool IsSetTargetDomainIds()
        {
            return this._targetDomainIds != null && (this._targetDomainIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp when the agent space was last updated
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