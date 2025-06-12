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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about an Amazon EC2 security group.
    /// </summary>
    public partial class AwsEc2SecurityGroupDetails
    {
        private string _groupId;
        private string _groupName;
        private List<AwsEc2SecurityGroupIpPermission> _ipPermissions = AWSConfigs.InitializeCollections ? new List<AwsEc2SecurityGroupIpPermission>() : null;
        private List<AwsEc2SecurityGroupIpPermission> _ipPermissionsEgress = AWSConfigs.InitializeCollections ? new List<AwsEc2SecurityGroupIpPermission>() : null;
        private string _ownerId;
        private string _vpcId;

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
        /// Gets and sets the property IpPermissions. 
        /// <para>
        /// The inbound rules associated with the security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2SecurityGroupIpPermission> IpPermissions
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
        /// Gets and sets the property IpPermissionsEgress. 
        /// <para>
        /// [VPC only] The outbound rules associated with the security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2SecurityGroupIpPermission> IpPermissionsEgress
        {
            get { return this._ipPermissionsEgress; }
            set { this._ipPermissionsEgress = value; }
        }

        // Check to see if IpPermissionsEgress property is set
        internal bool IsSetIpPermissionsEgress()
        {
            return this._ipPermissionsEgress != null && (this._ipPermissionsEgress.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the security group.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// [VPC only] The ID of the VPC for the security group.
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