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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVpcEndpoints operation.
    /// Deletes one or more specified VPC endpoints. You can delete any of the following types
    /// of VPC endpoints. 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Gateway endpoint,
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Gateway Load Balancer endpoint,
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Interface endpoint
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The following rules apply when you delete a VPC endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When you delete a gateway endpoint, we delete the endpoint routes in the route tables
    /// that are associated with the endpoint.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you delete a Gateway Load Balancer endpoint, we delete the endpoint network interfaces.
    /// 
    /// </para>
    ///  
    /// <para>
    /// You can only delete Gateway Load Balancer endpoints when the routes that are associated
    /// with the endpoint are deleted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you delete an interface endpoint, we delete the endpoint network interfaces.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteVpcEndpointsRequest : AmazonEC2Request
    {
        private List<string> _vpcEndpointIds = new List<string>();

        /// <summary>
        /// Gets and sets the property VpcEndpointIds. 
        /// <para>
        /// One or more VPC endpoint IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VpcEndpointIds
        {
            get { return this._vpcEndpointIds; }
            set { this._vpcEndpointIds = value; }
        }

        // Check to see if VpcEndpointIds property is set
        internal bool IsSetVpcEndpointIds()
        {
            return this._vpcEndpointIds != null && this._vpcEndpointIds.Count > 0; 
        }

    }
}