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
    /// Container for the parameters to the UpdateRegistry operation.
    /// Updates an existing registry. This operation uses PATCH semantics, so you only need
    /// to specify the fields you want to change.
    /// </summary>
    public partial class UpdateRegistryRequest : AmazonBedrockAgentCoreControlRequest
    {
        private UpdatedApprovalConfiguration _approvalConfiguration;
        private UpdatedAuthorizerConfiguration _authorizerConfiguration;
        private UpdatedDescription _description;
        private string _name;
        private string _registryId;

        /// <summary>
        /// Gets and sets the property ApprovalConfiguration. 
        /// <para>
        /// The updated approval configuration for registry records. The updated configuration
        /// only affects new records that move to <c>PENDING_APPROVAL</c> status after the change.
        /// Existing records already in <c>PENDING_APPROVAL</c> status are not affected.
        /// </para>
        /// </summary>
        public UpdatedApprovalConfiguration ApprovalConfiguration
        {
            get { return this._approvalConfiguration; }
            set { this._approvalConfiguration = value; }
        }

        // Check to see if ApprovalConfiguration property is set
        internal bool IsSetApprovalConfiguration()
        {
            return this._approvalConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizerConfiguration. 
        /// <para>
        /// The updated authorizer configuration for the registry. Changing the authorizer configuration
        /// can break existing consumers of the registry who are using the authorization type
        /// prior to the update.
        /// </para>
        /// </summary>
        public UpdatedAuthorizerConfiguration AuthorizerConfiguration
        {
            get { return this._authorizerConfiguration; }
            set { this._authorizerConfiguration = value; }
        }

        // Check to see if AuthorizerConfiguration property is set
        internal bool IsSetAuthorizerConfiguration()
        {
            return this._authorizerConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the registry. To clear the description, include the <c>UpdatedDescription</c>
        /// wrapper with <c>optionalValue</c> not specified.
        /// </para>
        /// </summary>
        public UpdatedDescription Description
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The identifier of the registry to update. You can specify either the Amazon Resource
        /// Name (ARN) or the ID of the registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

    }
}