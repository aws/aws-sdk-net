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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterSubnetGroup operation.
    /// Modifies a cluster subnet group to include the specified list of VPC subnets. The
    /// operation replaces the existing list of subnets with the new list of subnets.
    /// 
    ///  
    /// <para>
    /// VPC Block Public Access (BPA) enables you to block resources in VPCs and subnets that
    /// you own in a Region from reaching or being reached from the internet through internet
    /// gateways and egress-only internet gateways. If a subnet group for a provisioned cluster
    /// is in an account with VPC BPA turned on, the following capabilities are blocked:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Creating a public cluster
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Restoring a public cluster
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Modifying a private cluster to be public
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Adding a subnet with VPC BPA turned on to the subnet group when there's at least one
    /// public cluster within the group
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about VPC BPA, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/security-vpc-bpa.html">Block
    /// public access to VPCs and subnets</a> in the <i>Amazon VPC User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyClusterSubnetGroupRequest : AmazonRedshiftRequest
    {
        private string _clusterSubnetGroupName;
        private string _description;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ClusterSubnetGroupName. 
        /// <para>
        /// The name of the subnet group to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ClusterSubnetGroupName
        {
            get { return this._clusterSubnetGroupName; }
            set { this._clusterSubnetGroupName = value; }
        }

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this._clusterSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the subnet group to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// An array of VPC subnet IDs. A maximum of 20 subnets can be modified in a single request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
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