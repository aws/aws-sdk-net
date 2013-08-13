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
    /// <para>Describes a security group.</para>
    /// </summary>
    public class ClusterSecurityGroup
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

        /// <summary>
        /// Sets the ClusterSecurityGroupName property
        /// </summary>
        /// <param name="clusterSecurityGroupName">The value to set for the ClusterSecurityGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithClusterSecurityGroupName(string clusterSecurityGroupName)
        {
            this.clusterSecurityGroupName = clusterSecurityGroupName;
            return this;
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

        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithDescription(string description)
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
        /// A list of EC2 security groups that are permitted to access clusters associated with this cluster security group.
        ///  
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this.eC2SecurityGroups; }
            set { this.eC2SecurityGroups = value; }
        }
        /// <summary>
        /// Adds elements to the EC2SecurityGroups collection
        /// </summary>
        /// <param name="eC2SecurityGroups">The values to add to the EC2SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithEC2SecurityGroups(params EC2SecurityGroup[] eC2SecurityGroups)
        {
            foreach (EC2SecurityGroup element in eC2SecurityGroups)
            {
                this.eC2SecurityGroups.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the EC2SecurityGroups collection
        /// </summary>
        /// <param name="eC2SecurityGroups">The values to add to the EC2SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithEC2SecurityGroups(IEnumerable<EC2SecurityGroup> eC2SecurityGroups)
        {
            foreach (EC2SecurityGroup element in eC2SecurityGroups)
            {
                this.eC2SecurityGroups.Add(element);
            }

            return this;
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
        /// <summary>
        /// Adds elements to the IPRanges collection
        /// </summary>
        /// <param name="iPRanges">The values to add to the IPRanges collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithIPRanges(params IPRange[] iPRanges)
        {
            foreach (IPRange element in iPRanges)
            {
                this.iPRanges.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the IPRanges collection
        /// </summary>
        /// <param name="iPRanges">The values to add to the IPRanges collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithIPRanges(IEnumerable<IPRange> iPRanges)
        {
            foreach (IPRange element in iPRanges)
            {
                this.iPRanges.Add(element);
            }

            return this;
        }

        // Check to see if IPRanges property is set
        internal bool IsSetIPRanges()
        {
            return this.iPRanges.Count > 0;
        }
    }
}
