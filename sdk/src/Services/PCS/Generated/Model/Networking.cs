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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
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
namespace Amazon.PCS.Model
{
    /// <summary>
    /// The networking configuration for the cluster's control plane.
    /// </summary>
    public partial class Networking
    {
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The list of security group IDs associated with the Elastic Network Interface (ENI)
        /// created in subnets.
        /// </para>
        ///  
        /// <para>
        /// The following rules are required:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Inbound rule 1
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Protocol: All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ports: All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Source: Self
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Outbound rule 1
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Protocol: All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ports: All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Destination: 0.0.0.0/0 (IPv4)
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Outbound rule 2
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Protocol: All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Ports: All
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Destination: Self
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
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
        /// The ID of the subnet where Amazon Web Services PCS creates an Elastic Network Interface
        /// (ENI) to enable communication between managed controllers and Amazon Web Services
        /// PCS resources. The subnet must have an available IP address, cannot reside in AWS
        /// Outposts, AWS Wavelength, or an AWS Local Zone.
        /// </para>
        ///  
        /// <para>
        ///  Example: <c>subnet-abcd1234</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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

    }
}