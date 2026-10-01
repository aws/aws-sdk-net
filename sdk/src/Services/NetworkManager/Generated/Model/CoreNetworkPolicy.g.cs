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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Whether a core network policy is the current LIVE policy or the most recently submitted
        /// policy.
        /// </para>
        /// </summary>
        public CoreNetworkPolicyAlias Alias { get; set; }

        /// <summary>
        /// Checks to see if the Alias property is set.
        /// </summary>
        internal bool IsSetAlias() => this.Alias != null;

        /// <summary>
        /// Gets and sets the property ChangeSetState. 
        /// <para>
        /// The state of a core network policy.
        /// </para>
        /// </summary>
        public ChangeSetState ChangeSetState { get; set; }

        /// <summary>
        /// Checks to see if the ChangeSetState property is set.
        /// </summary>
        internal bool IsSetChangeSetState() => this.ChangeSetState != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when a core network policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of a core network policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property PolicyDocument. 
        /// <para>
        /// Describes a core network policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// Checks to see if the PolicyDocument property is set.
        /// </summary>
        internal bool IsSetPolicyDocument() => this.PolicyDocument != null;

        /// <summary>
        /// Gets and sets the property PolicyErrors. 
        /// <para>
        /// Describes any errors in a core network policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CoreNetworkPolicyError> PolicyErrors { get; set; } = AWSConfigs.InitializeCollections ? new List<CoreNetworkPolicyError>() : null;

        /// <summary>
        /// Checks to see if the PolicyErrors property is set.
        /// </summary>
        internal bool IsSetPolicyErrors() => this.PolicyErrors != null && (this.PolicyErrors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyVersionId. 
        /// <para>
        /// The ID of the policy version.
        /// </para>
        /// </summary>
        public int? PolicyVersionId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyVersionId property is set.
        /// </summary>
        internal bool IsSetPolicyVersionId() => this.PolicyVersionId.HasValue;
    }
}
