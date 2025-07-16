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
    /// This is the response object from the UpdateGatewayTarget operation.
    /// </summary>
    public partial class UpdateGatewayTargetResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private List<CredentialProviderConfiguration> _credentialProviderConfigurations = AWSConfigs.InitializeCollections ? new List<CredentialProviderConfiguration>() : null;
        private string _description;
        private string _gatewayArn;
        private string _name;
        private TargetStatus _status;
        private List<string> _statusReasons = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TargetConfiguration _targetConfiguration;
        private string _targetId;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the Gateway Target was created.
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
        /// Gets and sets the property CredentialProviderConfigurations. 
        /// <para>
        /// The updated credential provider configurations for the Gateway Target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<CredentialProviderConfiguration> CredentialProviderConfigurations
        {
            get { return this._credentialProviderConfigurations; }
            set { this._credentialProviderConfigurations = value; }
        }

        // Check to see if CredentialProviderConfigurations property is set
        internal bool IsSetCredentialProviderConfigurations()
        {
            return this._credentialProviderConfigurations != null && (this._credentialProviderConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the Gateway Target.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
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
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the Gateway Target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the updated Gateway Target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetStatus Status
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
        /// The reasons for the current status of the updated Gateway Target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// Gets and sets the property TargetConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public TargetConfiguration TargetConfiguration
        {
            get { return this._targetConfiguration; }
            set { this._targetConfiguration = value; }
        }

        // Check to see if TargetConfiguration property is set
        internal bool IsSetTargetConfiguration()
        {
            return this._targetConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The unique identifier of the updated Gateway Target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetId
        {
            get { return this._targetId; }
            set { this._targetId = value; }
        }

        // Check to see if TargetId property is set
        internal bool IsSetTargetId()
        {
            return this._targetId != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the Gateway Target was last updated.
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