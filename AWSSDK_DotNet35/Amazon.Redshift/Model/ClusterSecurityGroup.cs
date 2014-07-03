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

        // Check to see if IPRanges property is set
        internal bool IsSetIPRanges()
        {
            return this._iPRanges != null && this._iPRanges.Count > 0; 
        }

    }
}