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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// This is the response object from the DescribeVpcEndpointAssociation operation.
    /// </summary>
    public partial class DescribeVpcEndpointAssociationResponse : AmazonWebServiceResponse
    {
        private VpcEndpointAssociation _vpcEndpointAssociation;
        private VpcEndpointAssociationStatus _vpcEndpointAssociationStatus;

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociation. 
        /// <para>
        /// The configuration settings for the VPC endpoint association. These settings include
        /// the firewall and the VPC and subnet to use for the firewall endpoint. 
        /// </para>
        /// </summary>
        public VpcEndpointAssociation VpcEndpointAssociation
        {
            get { return this._vpcEndpointAssociation; }
            set { this._vpcEndpointAssociation = value; }
        }

        // Check to see if VpcEndpointAssociation property is set
        internal bool IsSetVpcEndpointAssociation()
        {
            return this._vpcEndpointAssociation != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationStatus. 
        /// <para>
        /// Detailed information about the current status of a <a>VpcEndpointAssociation</a>.
        /// You can retrieve this by calling <a>DescribeVpcEndpointAssociation</a> and providing
        /// the VPC endpoint association ARN.
        /// </para>
        /// </summary>
        public VpcEndpointAssociationStatus VpcEndpointAssociationStatus
        {
            get { return this._vpcEndpointAssociationStatus; }
            set { this._vpcEndpointAssociationStatus = value; }
        }

        // Check to see if VpcEndpointAssociationStatus property is set
        internal bool IsSetVpcEndpointAssociationStatus()
        {
            return this._vpcEndpointAssociationStatus != null;
        }

    }
}