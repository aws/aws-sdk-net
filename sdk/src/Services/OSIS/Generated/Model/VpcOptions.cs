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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
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
namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Options that specify the subnets and security groups for an OpenSearch Ingestion VPC
    /// endpoint.
    /// </summary>
    public partial class VpcOptions
    {
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private VpcAttachmentOptions _vpcAttachmentOptions;
        private VpcEndpointManagement _vpcEndpointManagement;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security groups associated with the VPC endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet IDs associated with the VPC endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=12)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcAttachmentOptions. 
        /// <para>
        /// Options for attaching a VPC to a pipeline.
        /// </para>
        /// </summary>
        public VpcAttachmentOptions VpcAttachmentOptions
        {
            get { return this._vpcAttachmentOptions; }
            set { this._vpcAttachmentOptions = value; }
        }

        // Check to see if VpcAttachmentOptions property is set
        internal bool IsSetVpcAttachmentOptions()
        {
            return this._vpcAttachmentOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointManagement. 
        /// <para>
        /// Defines whether you or Amazon OpenSearch Ingestion service create and manage the VPC
        /// endpoint configured for the pipeline.
        /// </para>
        /// </summary>
        public VpcEndpointManagement VpcEndpointManagement
        {
            get { return this._vpcEndpointManagement; }
            set { this._vpcEndpointManagement = value; }
        }

        // Check to see if VpcEndpointManagement property is set
        internal bool IsSetVpcEndpointManagement()
        {
            return this._vpcEndpointManagement != null;
        }

    }
}