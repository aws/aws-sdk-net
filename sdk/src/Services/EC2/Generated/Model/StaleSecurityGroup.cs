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
    /// Describes a stale security group (a security group that contains stale rules).
    /// </summary>
    public partial class StaleSecurityGroup
    {
        private string _description;
        private string _groupId;
        private string _groupName;
        private List<StaleIpPermission> _staleIpPermissions = new List<StaleIpPermission>();
        private List<StaleIpPermission> _staleIpPermissionsEgress = new List<StaleIpPermission>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the security group.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
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
        /// The name of the security group.
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
        /// Gets and sets the property StaleIpPermissions. 
        /// <para>
        /// Information about the stale inbound rules in the security group.
        /// </para>
        /// </summary>
        public List<StaleIpPermission> StaleIpPermissions
        {
            get { return this._staleIpPermissions; }
            set { this._staleIpPermissions = value; }
        }

        // Check to see if StaleIpPermissions property is set
        internal bool IsSetStaleIpPermissions()
        {
            return this._staleIpPermissions != null && this._staleIpPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StaleIpPermissionsEgress. 
        /// <para>
        /// Information about the stale outbound rules in the security group.
        /// </para>
        /// </summary>
        public List<StaleIpPermission> StaleIpPermissionsEgress
        {
            get { return this._staleIpPermissionsEgress; }
            set { this._staleIpPermissionsEgress = value; }
        }

        // Check to see if StaleIpPermissionsEgress property is set
        internal bool IsSetStaleIpPermissionsEgress()
        {
            return this._staleIpPermissionsEgress != null && this._staleIpPermissionsEgress.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the security group.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}