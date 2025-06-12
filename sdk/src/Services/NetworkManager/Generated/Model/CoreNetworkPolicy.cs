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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network policy. You can have only one LIVE Core Policy.
    /// </summary>
    public partial class CoreNetworkPolicy
    {
        private CoreNetworkPolicyAlias _alias;
        private ChangeSetState _changeSetState;
        private string _coreNetworkId;
        private DateTime? _createdAt;
        private string _description;
        private string _policyDocument;
        private List<CoreNetworkPolicyError> _policyErrors = AWSConfigs.InitializeCollections ? new List<CoreNetworkPolicyError>() : null;
        private int? _policyVersionId;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Whether a core network policy is the current LIVE policy or the most recently submitted
        /// policy.
        /// </para>
        /// </summary>
        public CoreNetworkPolicyAlias Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeSetState. 
        /// <para>
        /// The state of a core network policy.
        /// </para>
        /// </summary>
        public ChangeSetState ChangeSetState
        {
            get { return this._changeSetState; }
            set { this._changeSetState = value; }
        }

        // Check to see if ChangeSetState property is set
        internal bool IsSetChangeSetState()
        {
            return this._changeSetState != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when a core network policy was created.
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
        /// The description of a core network policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// Describes a core network policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000000)]
        public string PolicyDocument
        {
            get { return this._policyDocument; }
            set { this._policyDocument = value; }
        }

        // Check to see if PolicyDocument property is set
        internal bool IsSetPolicyDocument()
        {
            return this._policyDocument != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyErrors. 
        /// <para>
        /// Describes any errors in a core network policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CoreNetworkPolicyError> PolicyErrors
        {
            get { return this._policyErrors; }
            set { this._policyErrors = value; }
        }

        // Check to see if PolicyErrors property is set
        internal bool IsSetPolicyErrors()
        {
            return this._policyErrors != null && (this._policyErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PolicyVersionId. 
        /// <para>
        /// The ID of the policy version.
        /// </para>
        /// </summary>
        public int? PolicyVersionId
        {
            get { return this._policyVersionId; }
            set { this._policyVersionId = value; }
        }

        // Check to see if PolicyVersionId property is set
        internal bool IsSetPolicyVersionId()
        {
            return this._policyVersionId.HasValue; 
        }

    }
}