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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the RevokeSecurityGroupIngress operation.
    /// </summary>
    public partial class RevokeSecurityGroupIngressResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Return. 
        /// <para>
        /// Returns <c>true</c> if the request succeeds; otherwise, returns an error.
        /// </para>
        /// </summary>
        public bool? Return { get; set; }

        /// <summary>
        /// Checks to see if the Return property is set.
        /// </summary>
        internal bool IsSetReturn() => this.Return.HasValue;

        /// <summary>
        /// Gets and sets the property RevokedSecurityGroupRules. 
        /// <para>
        /// Details about the revoked security group rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RevokedSecurityGroupRule> RevokedSecurityGroupRules { get; set; } = AWSConfigs.InitializeCollections ? new List<RevokedSecurityGroupRule>() : null;

        /// <summary>
        /// Checks to see if the RevokedSecurityGroupRules property is set.
        /// </summary>
        internal bool IsSetRevokedSecurityGroupRules() => this.RevokedSecurityGroupRules != null && (this.RevokedSecurityGroupRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UnknownIpPermissions. 
        /// <para>
        /// The inbound rules that were unknown to the service. In some cases, <c>unknownIpPermissionSet</c>
        /// might be in a different format from the request parameter. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpPermission> UnknownIpPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;

        /// <summary>
        /// Checks to see if the UnknownIpPermissions property is set.
        /// </summary>
        internal bool IsSetUnknownIpPermissions() => this.UnknownIpPermissions != null && (this.UnknownIpPermissions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
