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
using Amazon.Runtime;

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
    public partial class DBSubnetGroup : AmazonWebServiceResponse
    {
        
        private string dBSubnetGroupName;
        private string dBSubnetGroupDescription;
        private string vpcId;
        private string subnetGroupStatus;
        private List<Subnet> subnets = new List<Subnet>();


        /// <summary>
        /// Specifies the name of the DB subnet group.
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;
        }

        /// <summary>
        /// Provides the description of the DB subnet group.
        ///  
        /// </summary>
        public string DBSubnetGroupDescription
        {
            get { return this.dBSubnetGroupDescription; }
            set { this.dBSubnetGroupDescription = value; }
        }

        // Check to see if DBSubnetGroupDescription property is set
        internal bool IsSetDBSubnetGroupDescription()
        {
            return this.dBSubnetGroupDescription != null;
        }

        /// <summary>
        /// Provides the VpcId of the DB subnet group.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// Provides the status of the DB subnet group.
        ///  
        /// </summary>
        public string SubnetGroupStatus
        {
            get { return this.subnetGroupStatus; }
            set { this.subnetGroupStatus = value; }
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

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this.subnets.Count > 0;
        }
    }
}
