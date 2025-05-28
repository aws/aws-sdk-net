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
    /// Container for the parameters to the DeleteVpcEndpointAssociation operation.
    /// Deletes the specified <a>VpcEndpointAssociation</a>.
    /// 
    ///  
    /// <para>
    /// You can check whether an endpoint association is in use by reviewing the route tables
    /// for the Availability Zones where you have the endpoint subnet mapping. You can retrieve
    /// the subnet mapping by calling <a>DescribeVpcEndpointAssociation</a>. You define and
    /// update the route tables through Amazon VPC. As needed, update the route tables for
    /// the Availability Zone to remove the firewall endpoint for the association. When the
    /// route tables no longer use the firewall endpoint, you can remove the endpoint association
    /// safely.
    /// </para>
    /// </summary>
    public partial class DeleteVpcEndpointAssociationRequest : AmazonNetworkFirewallRequest
    {
        private string _vpcEndpointAssociationArn;

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a VPC endpoint association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string VpcEndpointAssociationArn
        {
            get { return this._vpcEndpointAssociationArn; }
            set { this._vpcEndpointAssociationArn = value; }
        }

        // Check to see if VpcEndpointAssociationArn property is set
        internal bool IsSetVpcEndpointAssociationArn()
        {
            return this._vpcEndpointAssociationArn != null;
        }

    }
}