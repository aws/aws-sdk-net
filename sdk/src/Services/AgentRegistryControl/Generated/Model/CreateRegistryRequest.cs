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
    /// Container for the parameters to the CreateRegistry operation.
    /// Creates a new registry, a catalog that organizes registry records and defines their
    /// discovery authorization and record approval behavior. Creation is asynchronous: the
    /// registry begins in the CREATING status and becomes usable once it reaches READY.
    /// </summary>
    public partial class CreateRegistryRequest : AmazonAgentRegistryControlRequest
    {
        private ApprovalConfiguration _approvalConfiguration;
        private string _clientToken;
        private string _description;
        private DiscoveryConfiguration _discoveryConfiguration;
        private string _name;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApprovalConfiguration. 
        /// <para>
        /// Approval configuration for registry records
        /// </para>
        /// </summary>
        public ApprovalConfiguration ApprovalConfiguration
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Client token for idempotency
        /// </para>
        /// </summary>
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the registry
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=4096)]
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
        /// Gets and sets the property DiscoveryConfiguration. 
        /// <para>
        /// Discovery configuration for the registry
        /// </para>
        /// </summary>
        public DiscoveryConfiguration DiscoveryConfiguration
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
        /// The name of the registry
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to associate with the registry
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}