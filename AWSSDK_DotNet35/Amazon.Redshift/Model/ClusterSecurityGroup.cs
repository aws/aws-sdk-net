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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes a security group.</para>
    /// </summary>
    public partial class ClusterSecurityGroup : AmazonWebServiceResponse
    {
        
        private string clusterSecurityGroupName;
        private string description;
        private List<EC2SecurityGroup> eC2SecurityGroups = new List<EC2SecurityGroup>();
        private List<IPRange> iPRanges = new List<IPRange>();


        /// <summary>
        /// The name of the cluster security group to which the operation was applied.
        ///  
        /// </summary>
        public string ClusterSecurityGroupName
        {
            get { return this.clusterSecurityGroupName; }
            set { this.clusterSecurityGroupName = value; }
        }

        // Check to see if ClusterSecurityGroupName property is set
        internal bool IsSetClusterSecurityGroupName()
        {
            return this.clusterSecurityGroupName != null;
        }

        /// <summary>
        /// A description of the security group.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// A list of EC2 security groups that are permitted to access clusters associated with this cluster security group.
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
        /// A list of IP ranges (CIDR blocks) that are permitted to access clusters associated with this cluster security group.
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
