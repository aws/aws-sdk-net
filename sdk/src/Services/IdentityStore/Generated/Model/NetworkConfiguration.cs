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
 * Do not modify this file. This file is generated from the identitystore-2020-06-15.normal.json service model.
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
namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// The network configuration that controls how an identity store can be accessed. You
    /// provide this object in a request.
    /// </summary>
    public partial class NetworkConfiguration
    {
        private List<string> _apiAllowSourceIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _apiRestrictSourceVpcs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _scimAllowSourceIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _vpceAccessRequired;

        /// <summary>
        /// Gets and sets the property ApiAllowSourceIps. 
        /// <para>
        /// A list of IP address CIDR ranges that are allowed to access the identity store API
        /// operations. A request from an IP address in this list bypasses the identity store's
        /// other API network controls: it's permitted even if it doesn't come through a VPC endpoint
        /// required by <c>VpceAccessRequired</c>, and even if it doesn't originate from a VPC
        /// in <c>ApiRestrictSourceVpcs</c>. If you don't specify a value, no such IP address
        /// exception applies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> ApiAllowSourceIps
        {
            get { return this._apiAllowSourceIps; }
            set { this._apiAllowSourceIps = value; }
        }

        // Check to see if ApiAllowSourceIps property is set
        internal bool IsSetApiAllowSourceIps()
        {
            return this._apiAllowSourceIps != null && (this._apiAllowSourceIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApiRestrictSourceVpcs. 
        /// <para>
        /// A list of virtual private cloud (VPC) IDs that are allowed to access the identity
        /// store API operations. A request is denied unless it originates from a VPC in this
        /// list, or from an IP address in <c>ApiAllowSourceIps</c> if you specified one. If you
        /// don't specify a value, access isn't restricted to specific VPCs, but the VPC endpoint
        /// requirement set by <c>VpceAccessRequired</c> still applies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> ApiRestrictSourceVpcs
        {
            get { return this._apiRestrictSourceVpcs; }
            set { this._apiRestrictSourceVpcs = value; }
        }

        // Check to see if ApiRestrictSourceVpcs property is set
        internal bool IsSetApiRestrictSourceVpcs()
        {
            return this._apiRestrictSourceVpcs != null && (this._apiRestrictSourceVpcs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScimAllowSourceIps. 
        /// <para>
        /// A list of IP address CIDR ranges that are allowed to access the identity store through
        /// the System for Cross-domain Identity Management (SCIM) protocol. Requests from IP
        /// addresses outside these ranges are denied. If you don't specify a value, SCIM requests
        /// remain subject to the identity store's other network controls, such as the VPC endpoint
        /// requirement set by <c>VpceAccessRequired</c>.
        /// </para>
        ///  
        /// <para>
        /// For example, to allow SCIM traffic from the public internet while still requiring
        /// the identity store API operations to be accessed through a VPC endpoint, set <c>VpceAccessRequired</c>
        /// to <c>true</c> and set this value to <c>0.0.0.0/0</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> ScimAllowSourceIps
        {
            get { return this._scimAllowSourceIps; }
            set { this._scimAllowSourceIps = value; }
        }

        // Check to see if ScimAllowSourceIps property is set
        internal bool IsSetScimAllowSourceIps()
        {
            return this._scimAllowSourceIps != null && (this._scimAllowSourceIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpceAccessRequired. 
        /// <para>
        /// Specifies whether the identity store can be accessed only through a virtual private
        /// cloud (VPC) endpoint. When set to <c>true</c>, requests must originate from a VPC
        /// endpoint.
        /// </para>
        ///  
        /// <para>
        /// This value must be set to either <c>true</c> or <c>false</c> when you provide <c>NetworkConfiguration</c>
        /// in a request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? VpceAccessRequired
        {
            get { return this._vpceAccessRequired; }
            set { this._vpceAccessRequired = value; }
        }

        // Check to see if VpceAccessRequired property is set
        internal bool IsSetVpceAccessRequired()
        {
            return this._vpceAccessRequired.HasValue; 
        }

    }
}