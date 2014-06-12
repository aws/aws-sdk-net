/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a security group.
    /// </summary>
    public partial class ClusterSecurityGroup
    {
        private string _clusterSecurityGroupName;
        private string _description;
        private List<EC2SecurityGroup> _eC2SecurityGroups = new List<EC2SecurityGroup>();
        private List<IPRange> _iPRanges = new List<IPRange>();


        /// <summary>
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        ///         The name of the cluster security group to which the operation was applied.
        ///        
        /// </para>
        /// </summary>
        public string ClusterSecurityGroupName
        {
            get { return this._clusterSecurityGroupName; }
            set { this._clusterSecurityGroupName = value; }
        }


        /// <summary>
        /// Sets the ClusterSecurityGroupName property
        /// </summary>
        /// <param name="clusterSecurityGroupName">The value to set for the ClusterSecurityGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithClusterSecurityGroupName(string clusterSecurityGroupName)
        {
            this._clusterSecurityGroupName = clusterSecurityGroupName;
            return this;
        }

        // Check to see if ClusterSecurityGroupName property is set
        internal bool IsSetClusterSecurityGroupName()
        {
            return this._clusterSecurityGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///         A description of the security group.        
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }


        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">The value to set for the Description property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithDescription(string description)
        {
            this._description = description;
            return this;
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }


        /// <summary>
        /// Gets and sets the property EC2SecurityGroups. 
        /// <para>
        ///             A list of EC2 security groups that are permitted to access clusters associated
        /// with             this cluster security group.        
        /// </para>
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this._eC2SecurityGroups; }
            set { this._eC2SecurityGroups = value; }
        }

        /// <summary>
        /// Sets the EC2SecurityGroups property
        /// </summary>
        /// <param name="eC2SecurityGroups">The values to add to the EC2SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithEC2SecurityGroups(params EC2SecurityGroup[] eC2SecurityGroups)
        {
            foreach (var element in eC2SecurityGroups)
            {
                this._eC2SecurityGroups.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the EC2SecurityGroups property
        /// </summary>
        /// <param name="eC2SecurityGroups">The values to add to the EC2SecurityGroups collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithEC2SecurityGroups(IEnumerable<EC2SecurityGroup> eC2SecurityGroups)
        {
            foreach (var element in eC2SecurityGroups)
            {
                this._eC2SecurityGroups.Add(element);
            }
            return this;
        }
        // Check to see if EC2SecurityGroups property is set
        internal bool IsSetEC2SecurityGroups()
        {
            return this._eC2SecurityGroups != null && this._eC2SecurityGroups.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property IPRanges. 
        /// <para>
        ///             A list of IP ranges (CIDR blocks) that are permitted to access       
        ///      clusters associated with this cluster security group.        
        /// </para>
        /// </summary>
        public List<IPRange> IPRanges
        {
            get { return this._iPRanges; }
            set { this._iPRanges = value; }
        }

        /// <summary>
        /// Sets the IPRanges property
        /// </summary>
        /// <param name="iPRanges">The values to add to the IPRanges collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithIPRanges(params IPRange[] iPRanges)
        {
            foreach (var element in iPRanges)
            {
                this._iPRanges.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the IPRanges property
        /// </summary>
        /// <param name="iPRanges">The values to add to the IPRanges collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ClusterSecurityGroup WithIPRanges(IEnumerable<IPRange> iPRanges)
        {
            foreach (var element in iPRanges)
            {
                this._iPRanges.Add(element);
            }
            return this;
        }
        // Check to see if IPRanges property is set
        internal bool IsSetIPRanges()
        {
            return this._iPRanges != null && this._iPRanges.Count > 0; 
        }

    }
}