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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about the private connectivity configuration for an Outpost.
    /// </summary>
    public partial class PrivateConnectivityConfig
    {
        private PrivateConnectivityStatus _privateConnectivityStatus;
        private string _provisioningRoleArn;
        private string _roleArn;
        private List<VpcInformation> _vpcInformationList = AWSConfigs.InitializeCollections ? new List<VpcInformation>() : null;

        /// <summary>
        /// Gets and sets the property PrivateConnectivityStatus. 
        /// <para>
        /// The status of private connectivity for the Outpost. Valid values are <c>ENABLED</c>
        /// and <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public PrivateConnectivityStatus PrivateConnectivityStatus
        {
            get { return this._privateConnectivityStatus; }
            set { this._privateConnectivityStatus = value; }
        }

        // Check to see if PrivateConnectivityStatus property is set
        internal bool IsSetPrivateConnectivityStatus()
        {
            return this._privateConnectivityStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the provisioning role in your account that Amazon
        /// Web Services Outposts uses to establish the service link connection during Outpost
        /// installation. This field is present only when VPC endpoint-based provisioning is configured.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string ProvisioningRoleArn
        {
            get { return this._provisioningRoleArn; }
            set { this._provisioningRoleArn = value; }
        }

        // Check to see if ProvisioningRoleArn property is set
        internal bool IsSetProvisioningRoleArn()
        {
            return this._provisioningRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that Amazon Web Services
        /// Outposts creates and uses to provision and attach the network interfaces for private
        /// connectivity in your VPC. The role's permissions are scoped to the specific Outpost
        /// and VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property VpcInformationList. 
        /// <para>
        /// Information about the VPC used for private connectivity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<VpcInformation> VpcInformationList
        {
            get { return this._vpcInformationList; }
            set { this._vpcInformationList = value; }
        }

        // Check to see if VpcInformationList property is set
        internal bool IsSetVpcInformationList()
        {
            return this._vpcInformationList != null && (this._vpcInformationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}