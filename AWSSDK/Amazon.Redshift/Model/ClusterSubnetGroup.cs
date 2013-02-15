/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes a subnet group.</para>
    /// </summary>
    public class ClusterSubnetGroup
    {
        
        private string clusterSubnetGroupName;
        private string description;
        private string vpcId;
        private string subnetGroupStatus;
        private List<Subnet> subnets = new List<Subnet>();

        /// <summary>
        /// The name of the cluster subnet group.
        ///  
        /// </summary>
        public string ClusterSubnetGroupName
        {
            get { return this.clusterSubnetGroupName; }
            set { this.clusterSubnetGroupName = value; }
        }

        /// <summary>
        /// Sets the ClusterSubnetGroupName property
        /// </summary>
        /// <param name="clusterSubnetGroupName">The value to set for the ClusterSubnetGroupName property </param>
        /// <returns>this instance</returns>
        public ClusterSubnetGroup WithClusterSubnetGroupName(string clusterSubnetGroupName)
        {
            this.clusterSubnetGroupName = clusterSubnetGroupName;
            return this;
        }
            

        // Check to see if ClusterSubnetGroupName property is set
        internal bool IsSetClusterSubnetGroupName()
        {
            return this.clusterSubnetGroupName != null;
        }

        /// <summary>
        /// The description of the cluster subnet group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        public ClusterSubnetGroup WithDescription(string description)
        {
            this.description = description;
            return this;
        }
            

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The VPC ID of the cluster subnet group.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        /// <summary>
        /// Sets the VpcId property
        /// </summary>
        /// <param name="vpcId">The value to set for the VpcId property </param>
        /// <returns>this instance</returns>
        public ClusterSubnetGroup WithVpcId(string vpcId)
        {
            this.vpcId = vpcId;
            return this;
        }
            

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The status of the cluster subnet group. Possible values are <c>Complete</c>, <c>Incomplete</c> and <c>Invalid</c>.
        ///  
        /// </summary>
        public string SubnetGroupStatus
        {
            get { return this.subnetGroupStatus; }
            set { this.subnetGroupStatus = value; }
        }

        /// <summary>
        /// Sets the SubnetGroupStatus property
        /// </summary>
        /// <param name="subnetGroupStatus">The value to set for the SubnetGroupStatus property </param>
        /// <returns>this instance</returns>
        public ClusterSubnetGroup WithSubnetGroupStatus(string subnetGroupStatus)
        {
            this.subnetGroupStatus = subnetGroupStatus;
            return this;
        }
            

        // Check to see if SubnetGroupStatus property is set
        internal bool IsSetSubnetGroupStatus()
        {
            return this.subnetGroupStatus != null;
        }

        /// <summary>
        /// A list of the VPC <a>Subnet</a> elements.
        ///  
        /// </summary>
        public List<Subnet> Subnets
        {
            get { return this.subnets; }
            set { this.subnets = value; }
        }
        /// <summary>
        /// Adds elements to the Subnets collection
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        public ClusterSubnetGroup WithSubnets(params Subnet[] subnets)
        {
            foreach (Subnet element in subnets)
            {
                this.subnets.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Subnets collection
        /// </summary>
        /// <param name="subnets">The values to add to the Subnets collection </param>
        /// <returns>this instance</returns>
        public ClusterSubnetGroup WithSubnets(IEnumerable<Subnet> subnets)
        {
            foreach (Subnet element in subnets)
            {
                this.subnets.Add(element);
            }

            return this;
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this.subnets.Count > 0;
        }
    }
}
