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
    /// Summary information about routing policy associations for an attachment.
    /// </summary>
    public partial class AttachmentRoutingPolicyAssociationSummary
    {
        private List<string> _associatedRoutingPolicies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _attachmentId;
        private List<string> _pendingRoutingPolicies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _routingPolicyLabel;

        /// <summary>
        /// Gets and sets the property AssociatedRoutingPolicies. 
        /// <para>
        /// The list of routing policies currently associated with the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedRoutingPolicies
        {
            get { return this._associatedRoutingPolicies; }
            set { this._associatedRoutingPolicies = value; }
        }

        // Check to see if AssociatedRoutingPolicies property is set
        internal bool IsSetAssociatedRoutingPolicies()
        {
            return this._associatedRoutingPolicies != null && (this._associatedRoutingPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the attachment associated with the routing policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public string AttachmentId
        {
            get { return this._attachmentId; }
            set { this._attachmentId = value; }
        }

        // Check to see if AttachmentId property is set
        internal bool IsSetAttachmentId()
        {
            return this._attachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property PendingRoutingPolicies. 
        /// <para>
        /// The list of routing policies that are pending association with the attachment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PendingRoutingPolicies
        {
            get { return this._pendingRoutingPolicies; }
            set { this._pendingRoutingPolicies = value; }
        }

        // Check to see if PendingRoutingPolicies property is set
        internal bool IsSetPendingRoutingPolicies()
        {
            return this._pendingRoutingPolicies != null && (this._pendingRoutingPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingPolicyLabel. 
        /// <para>
        /// The routing policy label associated with the attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string RoutingPolicyLabel
        {
            get { return this._routingPolicyLabel; }
            set { this._routingPolicyLabel = value; }
        }

        // Check to see if RoutingPolicyLabel property is set
        internal bool IsSetRoutingPolicyLabel()
        {
            return this._routingPolicyLabel != null;
        }

    }
}