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
    /// Describes a security group.
    /// </summary>
    public partial class ClusterSecurityGroup
    {
        private string _clusterSecurityGroupName;
        private string _description;
        private List<EC2SecurityGroup> _ec2SecurityGroups = AWSConfigs.InitializeCollections ? new List<EC2SecurityGroup>() : null;
        private List<IPRange> _ipRanges = AWSConfigs.InitializeCollections ? new List<IPRange>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ClusterSecurityGroupName. 
        /// <para>
        /// The name of the cluster security group to which the operation was applied.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// A description of the security group.
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
        /// Gets and sets the property EC2SecurityGroups. 
        /// <para>
        /// A list of EC2 security groups that are permitted to access clusters associated with
        /// this cluster security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EC2SecurityGroup> EC2SecurityGroups
        {
            get { return this._ec2SecurityGroups; }
            set { this._ec2SecurityGroups = value; }
        }

        // Check to see if EC2SecurityGroups property is set
        internal bool IsSetEC2SecurityGroups()
        {
            return this._ec2SecurityGroups != null && (this._ec2SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IPRanges. 
        /// <para>
        /// A list of IP ranges (CIDR blocks) that are permitted to access clusters associated
        /// with this cluster security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IPRange> IPRanges
        {
            get { return this._ipRanges; }
            set { this._ipRanges = value; }
        }

        // Check to see if IPRanges property is set
        internal bool IsSetIPRanges()
        {
            return this._ipRanges != null && (this._ipRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the cluster security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}