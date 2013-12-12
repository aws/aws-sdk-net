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
    /// <li> DescribeDBSecurityGroups </li>
    /// <li> AuthorizeDBSecurityGroupIngress </li>
    /// <li> CreateDBSecurityGroup </li>
    /// <li> RevokeDBSecurityGroupIngress </li>
    /// 
    /// </ul>
    /// <para>This data type is used as a response element in the DescribeDBSecurityGroups action.</para>
    /// </summary>
    public partial class DBSecurityGroup : AmazonWebServiceResponse
    {
        
        private string ownerId;
        private string dBSecurityGroupName;
        private string dBSecurityGroupDescription;
        private string vpcId;
        private List<EC2SecurityGroup> eC2SecurityGroups = new List<EC2SecurityGroup>();
        private List<IPRange> iPRanges = new List<IPRange>();


        /// <summary>
        /// Provides the AWS ID of the owner of a specific DB security group.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// Specifies the name of the DB security group.
        ///  
        /// </summary>
        public string DBSecurityGroupName
        {
            get { return this.dBSecurityGroupName; }
            set { this.dBSecurityGroupName = value; }
        }

        // Check to see if DBSecurityGroupName property is set
        internal bool IsSetDBSecurityGroupName()
        {
            return this.dBSecurityGroupName != null;
        }

        /// <summary>
        /// Provides the description of the DB security group.
        ///  
        /// </summary>
        public string DBSecurityGroupDescription
        {
            get { return this.dBSecurityGroupDescription; }
            set { this.dBSecurityGroupDescription = value; }
        }

        // Check to see if DBSecurityGroupDescription property is set
        internal bool IsSetDBSecurityGroupDescription()
        {
            return this.dBSecurityGroupDescription != null;
        }

        /// <summary>
        /// Provides the VpcId of the DB security group.
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
        /// Contains a list of <a>EC2SecurityGroup</a> elements.
        ///  
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this.eC2SecurityGroups; }
            set { this.eC2SecurityGroups = value; }
        }

        // Check to see if EC2SecurityGroups property is set
        internal bool IsSetEC2SecurityGroups()
        {
            return this.eC2SecurityGroups.Count > 0;
        }

        /// <summary>
        /// Contains a list of <a>IPRange</a> elements.
        ///  
        /// </summary>
        public List<IPRange> IPRanges
        {
            get { return this.iPRanges; }
            set { this.iPRanges = value; }
        }

        // Check to see if IPRanges property is set
        internal bool IsSetIPRanges()
        {
            return this.iPRanges.Count > 0;
        }
    }
}
