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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the RevokeSecurityGroupEgress operation.
    /// </summary>
    public partial class RevokeSecurityGroupEgressResponse : AmazonWebServiceResponse
    {
        private bool? _return;
        private List<RevokedSecurityGroupRule> _revokedSecurityGroupRules = AWSConfigs.InitializeCollections ? new List<RevokedSecurityGroupRule>() : null;
        private List<IpPermission> _unknownIpPermissions = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;

        /// <summary>
        /// Gets and sets the property Return. 
        /// <para>
        /// Returns <c>true</c> if the request succeeds; otherwise, returns an error.
        /// </para>
        /// </summary>
        public bool Return
        {
            get { return this._return.GetValueOrDefault(); }
            set { this._return = value; }
        }

        // Check to see if Return property is set
        internal bool IsSetReturn()
        {
            return this._return.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RevokedSecurityGroupRules. 
        /// <para>
        /// Details about the revoked security group rules.
        /// </para>
        /// </summary>
        public List<RevokedSecurityGroupRule> RevokedSecurityGroupRules
        {
            get { return this._revokedSecurityGroupRules; }
            set { this._revokedSecurityGroupRules = value; }
        }

        // Check to see if RevokedSecurityGroupRules property is set
        internal bool IsSetRevokedSecurityGroupRules()
        {
            return this._revokedSecurityGroupRules != null && (this._revokedSecurityGroupRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnknownIpPermissions. 
        /// <para>
        /// The outbound rules that were unknown to the service. In some cases, <c>unknownIpPermissionSet</c>
        /// might be in a different format from the request parameter. 
        /// </para>
        /// </summary>
        public List<IpPermission> UnknownIpPermissions
        {
            get { return this._unknownIpPermissions; }
            set { this._unknownIpPermissions = value; }
        }

        // Check to see if UnknownIpPermissions property is set
        internal bool IsSetUnknownIpPermissions()
        {
            return this._unknownIpPermissions != null && (this._unknownIpPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}