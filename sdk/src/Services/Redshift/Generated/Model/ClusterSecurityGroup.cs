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

/*
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
        private List<EC2SecurityGroup> _ec2SecurityGroups = new List<EC2SecurityGroup>();
        private List<IPRange> _ipRanges = new List<IPRange>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        ///  The name of the cluster security group to which the operation was applied. 
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
        ///  A description of the security group. 
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
        ///  A list of EC2 security groups that are permitted to access clusters associated with
        /// this cluster security group. 
        /// </para>
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this._ec2SecurityGroups; }
            set { this._ec2SecurityGroups = value; }
        }

        // Check to see if EC2SecurityGroups property is set
        internal bool IsSetEC2SecurityGroups()
        {
            return this._ec2SecurityGroups != null && this._ec2SecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IPRanges. 
        /// <para>
        ///  A list of IP ranges (CIDR blocks) that are permitted to access clusters associated
        /// with this cluster security group. 
        /// </para>
        /// </summary>
        public List<IPRange> IPRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IPRanges property is set
        internal bool IsSetIPRanges()
        {
            return this._ipRanges != null && this._ipRanges.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the cluster security group.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}