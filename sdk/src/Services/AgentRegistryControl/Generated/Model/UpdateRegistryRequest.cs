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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
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
namespace Amazon.AgentRegistryControl.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRegistry operation.
    /// Updates an existing registry. This operation uses PATCH semantics: specify only the
    /// fields you want to change, and omit the rest to leave them unchanged. Updates are
    /// applied asynchronously and the registry transitions to the UPDATING status while they
    /// are processed.
    /// </summary>
    public partial class UpdateRegistryRequest : AmazonAgentRegistryControlRequest
    {
        private UpdatedApprovalConfiguration _approvalConfiguration;
        private UpdatedDescription _description;
        private UpdatedDiscoveryConfiguration _discoveryConfiguration;
        private string _name;
        private string _registryId;

        /// <summary>
        /// Gets and sets the property ApprovalConfiguration. 
        /// <para>
        /// The updated approval configuration. The change applies only to records that move to
        /// PENDING_APPROVAL after the update; records already in PENDING_APPROVAL are unaffected.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the registry
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
        /// Gets and sets the property DiscoveryConfiguration. 
        /// <para>
        /// The updated discovery configuration. Changing the discovery authorization can break
        /// existing consumers that rely on the previous authorization type.
        /// </para>
        /// </summary>
        public UpdatedDiscoveryConfiguration DiscoveryConfiguration
        {
            get { return this._discoveryConfiguration; }
            set { this._discoveryConfiguration = value; }
        }

        // Check to see if DiscoveryConfiguration property is set
        internal bool IsSetDiscoveryConfiguration()
        {
            return this._discoveryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The updated name of the registry
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
        /// The identifier of the registry to update (ARN or ID)
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