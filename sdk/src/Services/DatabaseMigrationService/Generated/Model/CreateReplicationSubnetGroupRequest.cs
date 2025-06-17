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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateReplicationSubnetGroup operation.
    /// Creates a replication subnet group given a list of the subnet IDs in a VPC.
    /// 
    ///  
    /// <para>
    /// The VPC needs to have at least one subnet in at least two availability zones in the
    /// Amazon Web Services Region, otherwise the service will throw a <c>ReplicationSubnetGroupDoesNotCoverEnoughAZs</c>
    /// exception.
    /// </para>
    ///  
    /// <para>
    /// If a replication subnet group exists in your Amazon Web Services account, the CreateReplicationSubnetGroup
    /// action returns the following error message: The Replication Subnet Group already exists.
    /// In this case, delete the existing replication subnet group. To do so, use the <a href="https://docs.aws.amazon.com/en_us/dms/latest/APIReference/API_DeleteReplicationSubnetGroup.html">DeleteReplicationSubnetGroup</a>
    /// action. Optionally, choose Subnet groups in the DMS console, then choose your subnet
    /// group. Next, choose Delete from Actions.
    /// </para>
    /// </summary>
    public partial class CreateReplicationSubnetGroupRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _replicationSubnetGroupDescription;
        private string _replicationSubnetGroupIdentifier;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroupDescription. 
        /// <para>
        /// The description for the subnet group. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: This parameter Must not contain non-printable control characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationSubnetGroupDescription
        {
            get { return this._replicationSubnetGroupDescription; }
            set { this._replicationSubnetGroupDescription = value; }
        }

        // Check to see if ReplicationSubnetGroupDescription property is set
        internal bool IsSetReplicationSubnetGroupDescription()
        {
            return this._replicationSubnetGroupDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationSubnetGroupIdentifier. 
        /// <para>
        /// The name for the replication subnet group. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain no more than 255 alphanumeric characters, periods, underscores,
        /// or hyphens. Must not be "default".
        /// </para>
        ///  
        /// <para>
        /// Example: <c>mySubnetgroup</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationSubnetGroupIdentifier
        {
            get { return this._replicationSubnetGroupIdentifier; }
            set { this._replicationSubnetGroupIdentifier = value; }
        }

        // Check to see if ReplicationSubnetGroupIdentifier property is set
        internal bool IsSetReplicationSubnetGroupIdentifier()
        {
            return this._replicationSubnetGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// Two or more subnet IDs to be assigned to the subnet group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the subnet group.
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