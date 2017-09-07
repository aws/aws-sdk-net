/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityGroupRuleDescriptionsIngress operation.
    /// Updates the description of an ingress (inbound) security group rule. You can replace
    /// an existing description, or add a description to a rule that did not have one previously.
    /// 
    ///  
    /// <para>
    /// You specify the description as part of the IP permissions structure. You can remove
    /// a description for a security group rule by omitting the description parameter in the
    /// request.
    /// </para>
    /// </summary>
    public partial class UpdateSecurityGroupRuleDescriptionsIngressRequest : AmazonEC2Request
    {
        private string _groupId;
        private string _groupName;
        private List<IpPermission> _ipPermissions = new List<IpPermission>();

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
        /// [EC2-Classic, default VPC] The name of the security group. You must specify either
        /// the security group ID or the security group name in the request.
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
        /// The IP permissions for the security group rule. 
        /// </para>
        /// </summary>
        public List<IpPermission> IpPermissions
        {
            get { return this._ipPermissions; }
            set { this._ipPermissions = value; }
        }

        // Check to see if IpPermissions property is set
        internal bool IsSetIpPermissions()
        {
            return this._ipPermissions != null && this._ipPermissions.Count > 0; 
        }

    }
}