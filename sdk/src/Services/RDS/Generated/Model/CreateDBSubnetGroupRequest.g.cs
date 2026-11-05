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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDBSubnetGroup operation. Creates a new DB
    /// subnet group. DB subnet groups must contain at least one subnet in at least two AZs
    /// in the Amazon Web Services Region.
    /// </summary>
    public partial class CreateDBSubnetGroupRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBSubnetGroupDescription. 
        /// <para>
        /// The description for the DB subnet group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBSubnetGroupDescription { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupDescription property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupDescription() => this.DBSubnetGroupDescription != null;

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        /// The name for the DB subnet group. This value is stored as a lowercase string.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain no more than 255 letters, numbers, periods, underscores, spaces, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not be default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// First character must be a letter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>mydbsubnetgroup</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DBSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DBSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetDBSubnetGroupName() => this.DBSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The EC2 Subnet IDs for the DB subnet group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to assign to the DB subnet group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
