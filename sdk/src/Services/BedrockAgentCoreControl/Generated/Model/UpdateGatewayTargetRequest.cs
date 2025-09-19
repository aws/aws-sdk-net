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
    /// Container for the parameters to the UpdateGatewayTarget operation.
    /// Updates an existing gateway target.
    /// </summary>
    public partial class UpdateGatewayTargetRequest : AmazonBedrockAgentCoreControlRequest
    {
        private List<CredentialProviderConfiguration> _credentialProviderConfigurations = AWSConfigs.InitializeCollections ? new List<CredentialProviderConfiguration>() : null;
        private string _description;
        private string _gatewayIdentifier;
        private string _name;
        private TargetConfiguration _targetConfiguration;
        private string _targetId;

        /// <summary>
        /// Gets and sets the property CredentialProviderConfigurations. 
        /// <para>
        /// The updated credential provider configurations for the gateway target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// The updated description for the gateway target.
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
        /// Gets and sets the property GatewayIdentifier. 
        /// <para>
        /// The unique identifier of the gateway associated with the target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayIdentifier
        {
            get { return this._gatewayIdentifier; }
            set { this._gatewayIdentifier = value; }
        }

        // Check to see if GatewayIdentifier property is set
        internal bool IsSetGatewayIdentifier()
        {
            return this._gatewayIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name for the gateway target.
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
        /// The unique identifier of the gateway target to update.
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

    }
}