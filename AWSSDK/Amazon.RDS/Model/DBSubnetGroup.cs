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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Contains the result of a successful invocation of the following actions: </para>
    /// <ul>
    /// <li> CreateDBSubnetGroup </li>
    /// <li> ModifyDBSubnetGroup </li>
    /// <li> DescribeDBSubnetGroups </li>
    /// <li> DeleteDBSubnetGroup </li>
    /// 
    /// </ul>
    /// <para>This data type is used as a response element in the DescribeDBSubnetGroups action.</para>
    /// </summary>
    public class DBSubnetGroup
    {
        
        private string dBSubnetGroupName;
        private string dBSubnetGroupDescription;
        private string vpcId;
        private string subnetGroupStatus;
        private List<Subnet> subnets = new List<Subnet>();

        /// <summary>
        /// Specifies the name of the DB Subnet Group.
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        /// <summary>
        /// Sets the DBSubnetGroupName property
        /// </summary>
        /// <param name="dBSubnetGroupName">The value to set for the DBSubnetGroupName property </param>
        /// <returns>this instance</returns>
        public DBSubnetGroup WithDBSubnetGroupName(string dBSubnetGroupName)
        {
            this.dBSubnetGroupName = dBSubnetGroupName;
            return this;
        }
            

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;
        }

        /// <summary>
        /// Provides the description of the DB Subnet Group.
        ///  
        /// </summary>
        public string DBSubnetGroupDescription
        {
            get { return this.dBSubnetGroupDescription; }
            set { this.dBSubnetGroupDescription = value; }
        }

        /// <summary>
        /// Sets the DBSubnetGroupDescription property
        /// </summary>
        /// <param name="dBSubnetGroupDescription">The value to set for the DBSubnetGroupDescription property </param>
        /// <returns>this instance</returns>
        public DBSubnetGroup WithDBSubnetGroupDescription(string dBSubnetGroupDescription)
        {
            this.dBSubnetGroupDescription = dBSubnetGroupDescription;
            return this;
        }
            

        // Check to see if DBSubnetGroupDescription property is set
        internal bool IsSetDBSubnetGroupDescription()
        {
            return this.dBSubnetGroupDescription != null;
        }

        /// <summary>
        /// Provides the VpcId of the DB Subnet Group.
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
        public DBSubnetGroup WithVpcId(string vpcId)
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
        /// Provides the status of the DB Subnet Group.
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
        public DBSubnetGroup WithSubnetGroupStatus(string subnetGroupStatus)
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
        /// Contains a list of <a>Subnet</a> elements.
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
        public DBSubnetGroup WithSubnets(params Subnet[] subnets)
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
        public DBSubnetGroup WithSubnets(IEnumerable<Subnet> subnets)
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
