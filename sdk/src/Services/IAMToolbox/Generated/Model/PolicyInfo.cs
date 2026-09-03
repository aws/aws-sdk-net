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
 * Do not modify this file. This file is generated from the iam-toolbox-2018-05-10.normal.json service model.
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
namespace Amazon.IAMToolbox.Model
{
    /// <summary>
    /// Contains details about a policy evaluated during authorization. Details include the
    /// policy type, whether it is inline or managed, a URI that identifies it, and the entities
    /// it is attached to.
    /// </summary>
    public partial class PolicyInfo
    {
        private List<AttachedTo> _attachedTo = AWSConfigs.InitializeCollections ? new List<AttachedTo>() : null;
        private bool? _inline;
        private PolicyType _type;
        private string _uri;

        /// <summary>
        /// Gets and sets the property AttachedTo. 
        /// <para>
        /// The entities that the policy is attached to. For identity, session, and resource-based
        /// policies, this is typically a single entity. For organization control policies (SCPs
        /// and RCPs), it can be multiple entities at different levels of the organization hierarchy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttachedTo> AttachedTo
        {
            get { return this._attachedTo; }
            set { this._attachedTo = value; }
        }

        // Check to see if AttachedTo property is set
        internal bool IsSetAttachedTo()
        {
            return this._attachedTo != null && (this._attachedTo.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Inline. 
        /// <para>
        /// Specifies whether this is an inline policy (<c>true</c>) or a managed policy (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? Inline
        {
            get { return this._inline; }
            set { this._inline = value; }
        }

        // Check to see if Inline property is set
        internal bool IsSetInline()
        {
            return this._inline.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of policy. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>IDENTITY_BASED_POLICY</c> - An identity-based policy attached to an IAM user,
        /// group, or role.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PERMISSIONS_BOUNDARY</c> - A permissions boundary for an IAM entity.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_BASED_POLICY</c> - A resource-based policy attached to a resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_CONTROL_POLICY</c> - A resource control policy (RCP) in AWS Organizations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SERVICE_CONTROL_POLICY</c> - A service control policy (SCP) in AWS Organizations.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SESSION_POLICY</c> - A session policy passed during role assumption or federation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VPC_ENDPOINT_POLICY</c> - A VPC endpoint policy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PolicyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Uri. 
        /// <para>
        /// A URI that identifies the policy. Use this URI to cross-reference the policy with
        /// the matching policies in each evaluation. The value depends on the policy type:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For managed policies, this is the policy ARN.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For inline policies, which have no ARN, this is an opaque identifier.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Uri
        {
            get { return this._uri; }
            set { this._uri = value; }
        }

        // Check to see if Uri property is set
        internal bool IsSetUri()
        {
            return this._uri != null;
        }

    }
}