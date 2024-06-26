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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// The claim in OIDC identity provider tokens that indicates a user's group membership,
    /// and the entity type that you want to map it to. For example, this object can map the
    /// contents of a <c>groups</c> claim to <c>MyCorp::UserGroup</c>.
    /// 
    ///  
    /// <para>
    /// This data type is part of a <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_OpenIdConnectConfigurationDetail.html">OpenIdConnectConfigurationDetail</a>
    /// structure, which is a parameter of <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_GetIdentitySource.html">GetIdentitySource</a>.
    /// </para>
    /// </summary>
    public partial class OpenIdConnectGroupConfigurationDetail
    {
        private string _groupClaim;
        private string _groupEntityType;

        /// <summary>
        /// Gets and sets the property GroupClaim. 
        /// <para>
        /// The token claim that you want Verified Permissions to interpret as group membership.
        /// For example, <c>groups</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string GroupClaim
        {
            get { return this._groupClaim; }
            set { this._groupClaim = value; }
        }

        // Check to see if GroupClaim property is set
        internal bool IsSetGroupClaim()
        {
            return this._groupClaim != null;
        }

        /// <summary>
        /// Gets and sets the property GroupEntityType. 
        /// <para>
        /// The policy store entity type that you want to map your users' group claim to. For
        /// example, <c>MyCorp::UserGroup</c>. A group entity type is an entity that can have
        /// a user entity type as a member.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=200)]
        public string GroupEntityType
        {
            get { return this._groupEntityType; }
            set { this._groupEntityType = value; }
        }

        // Check to see if GroupEntityType property is set
        internal bool IsSetGroupEntityType()
        {
            return this._groupEntityType != null;
        }

    }
}