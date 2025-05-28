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
    /// High-level information about a VPC endpoint association, returned by <c>ListVpcEndpointAssociations</c>.
    /// You can use the information provided in the metadata to retrieve and manage a VPC
    /// endpoint association.
    /// </summary>
    public partial class VpcEndpointAssociationMetadata
    {
        private string _vpcEndpointAssociationArn;

        /// <summary>
        /// Gets and sets the property VpcEndpointAssociationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a VPC endpoint association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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