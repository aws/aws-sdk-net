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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// Specifies how your DataSync agent connects to Amazon Web Services using a <a href="https://docs.aws.amazon.com/datasync/latest/userguide/choose-service-endpoint.html#choose-service-endpoint-vpc">virtual
    /// private cloud (VPC) service endpoint</a>. An agent that uses a VPC endpoint isn't
    /// accessible over the public internet.
    /// </summary>
    public partial class PrivateLinkConfig
    {
        private string _privateLinkEndpoint;
        private List<string> _securityGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _vpcEndpointId;

        /// <summary>
        /// Gets and sets the property PrivateLinkEndpoint. 
        /// <para>
        /// Specifies the VPC endpoint provided by <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/privatelink-share-your-services.html">Amazon
        /// Web Services PrivateLink</a> that your agent connects to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=15)]
        public string PrivateLinkEndpoint
        {
            get { return this._privateLinkEndpoint; }
            set { this._privateLinkEndpoint = value; }
        }

        // Check to see if PrivateLinkEndpoint property is set
        internal bool IsSetPrivateLinkEndpoint()
        {
            return this._privateLinkEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupArns. 
        /// <para>
        /// Specifies the Amazon Resource Names (ARN) of the security group that provides DataSync
        /// access to your VPC endpoint. You can only specify one ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SecurityGroupArns
        {
            get { return this._securityGroupArns; }
            set { this._securityGroupArns = value; }
        }

        // Check to see if SecurityGroupArns property is set
        internal bool IsSetSecurityGroupArns()
        {
            return this._securityGroupArns != null && (this._securityGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetArns. 
        /// <para>
        /// Specifies the ARN of the subnet where your VPC endpoint is located. You can only specify
        /// one ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SubnetArns
        {
            get { return this._subnetArns; }
            set { this._subnetArns = value; }
        }

        // Check to see if SubnetArns property is set
        internal bool IsSetSubnetArns()
        {
            return this._subnetArns != null && (this._subnetArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// Specifies the ID of the VPC endpoint that your agent connects to.
        /// </para>
        /// </summary>
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

    }
}