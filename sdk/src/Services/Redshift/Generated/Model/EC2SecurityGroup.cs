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
    /// Describes an Amazon EC2 security group.
    /// </summary>
    public partial class EC2SecurityGroup
    {
        private string _ec2SecurityGroupName;
        private string _ec2SecurityGroupOwnerId;
        private string _status;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        /// The name of the EC2 Security Group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string EC2SecurityGroupName
        {
            get { return this._ec2SecurityGroupName; }
            set { this._ec2SecurityGroupName = value; }
        }

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this._ec2SecurityGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the EC2 security group specified
        /// in the <c>EC2SecurityGroupName</c> field. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string EC2SecurityGroupOwnerId
        {
            get { return this._ec2SecurityGroupOwnerId; }
            set { this._ec2SecurityGroupOwnerId = value; }
        }

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this._ec2SecurityGroupOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the EC2 security group.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of tags for the EC2 security group.
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