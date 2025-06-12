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
    /// Container for the parameters to the UpdateSecurityGroupRuleDescriptionsIngress operation.
    /// Updates the description of an ingress (inbound) security group rule. You can replace
    /// an existing description, or add a description to a rule that did not have one previously.
    /// You can remove a description for a security group rule by omitting the description
    /// parameter in the request.
    /// </summary>
    public partial class UpdateSecurityGroupRuleDescriptionsIngressRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private string _groupId;
        private string _groupName;
        private List<IpPermission> _ipPermissions = AWSConfigs.InitializeCollections ? new List<IpPermission>() : null;
        private List<SecurityGroupRuleDescription> _securityGroupRuleDescriptions = AWSConfigs.InitializeCollections ? new List<SecurityGroupRuleDescription>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group. You must specify either the security group ID or the
        /// security group name in the request. For security groups in a nondefault VPC, you must
        /// specify the security group ID.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// [Default VPC] The name of the security group. You must specify either the security
        /// group ID or the security group name. For security groups in a nondefault VPC, you
        /// must specify the security group ID.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property IpPermissions. 
        /// <para>
        /// The IP permissions for the security group rule. You must specify either IP permissions
        /// or a description.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpPermission> IpPermissions
        {
            get { return this._ipPermissions; }
            set { this._ipPermissions = value; }
        }

        // Check to see if IpPermissions property is set
        internal bool IsSetIpPermissions()
        {
            return this._ipPermissions != null && (this._ipPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupRuleDescriptions. 
        /// <para>
        /// The description for the ingress security group rules. You must specify either a description
        /// or IP permissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SecurityGroupRuleDescription> SecurityGroupRuleDescriptions
        {
            get { return this._securityGroupRuleDescriptions; }
            set { this._securityGroupRuleDescriptions = value; }
        }

        // Check to see if SecurityGroupRuleDescriptions property is set
        internal bool IsSetSecurityGroupRuleDescriptions()
        {
            return this._securityGroupRuleDescriptions != null && (this._securityGroupRuleDescriptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}