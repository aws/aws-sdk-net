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
    /// Contains the details for an Amazon RDS DB shard group.
    /// </summary>
    public partial class DBShardGroup
    {
        /// <summary>
        /// Gets and sets the property ComputeRedundancy. 
        /// <para>
        /// Specifies whether to create standby DB shard groups for the DB shard group. Valid
        /// values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// 0 - Creates a DB shard group without a standby DB shard group. This is the default
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 1 - Creates a DB shard group with a standby DB shard group in a different Availability
        /// Zone (AZ).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// 2 - Creates a DB shard group with two standby DB shard groups in two different AZs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? ComputeRedundancy { get; set; }

        /// <summary>
        /// Checks to see if the ComputeRedundancy property is set.
        /// </summary>
        internal bool IsSetComputeRedundancy() => this.ComputeRedundancy.HasValue;

        /// <summary>
        /// Gets and sets the property DBClusterIdentifier. 
        /// <para>
        /// The name of the primary DB cluster for the DB shard group.
        /// </para>
        /// </summary>
        public string DBClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifier() => this.DBClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBShardGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the DB shard group.
        /// </para>
        /// </summary>
        public string DBShardGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the DBShardGroupArn property is set.
        /// </summary>
        internal bool IsSetDBShardGroupArn() => this.DBShardGroupArn != null;

        /// <summary>
        /// Gets and sets the property DBShardGroupIdentifier. 
        /// <para>
        /// The name of the DB shard group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DBShardGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DBShardGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetDBShardGroupIdentifier() => this.DBShardGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property DBShardGroupResourceId. 
        /// <para>
        /// The Amazon Web Services Region-unique, immutable identifier for the DB shard group.
        /// </para>
        /// </summary>
        public string DBShardGroupResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DBShardGroupResourceId property is set.
        /// </summary>
        internal bool IsSetDBShardGroupResourceId() => this.DBShardGroupResourceId != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The connection endpoint for the DB shard group.
        /// </para>
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property MaxACU. 
        /// <para>
        /// The maximum capacity of the DB shard group in Aurora capacity units (ACUs).
        /// </para>
        /// </summary>
        public double? MaxACU { get; set; }

        /// <summary>
        /// Checks to see if the MaxACU property is set.
        /// </summary>
        internal bool IsSetMaxACU() => this.MaxACU.HasValue;

        /// <summary>
        /// Gets and sets the property MinACU. 
        /// <para>
        /// The minimum capacity of the DB shard group in Aurora capacity units (ACUs).
        /// </para>
        /// </summary>
        public double? MinACU { get; set; }

        /// <summary>
        /// Checks to see if the MinACU property is set.
        /// </summary>
        internal bool IsSetMinACU() => this.MinACU.HasValue;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Indicates whether the DB shard group is publicly accessible.
        /// </para>
        ///  
        /// <para>
        /// When the DB shard group is publicly accessible, its Domain Name System (DNS) endpoint
        /// resolves to the private IP address from within the DB shard group's virtual private
        /// cloud (VPC). It resolves to the public IP address from outside of the DB shard group's
        /// VPC. Access to the DB shard group is ultimately controlled by the security group it
        /// uses. That public access isn't permitted if the security group assigned to the DB
        /// shard group doesn't permit it.
        /// </para>
        ///  
        /// <para>
        /// When the DB shard group isn't publicly accessible, it is an internal DB shard group
        /// with a DNS name that resolves to a private IP address.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a>CreateDBShardGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// This setting is only for Aurora Limitless Database.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the DB shard group.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TagList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagList { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TagList property is set.
        /// </summary>
        internal bool IsSetTagList() => this.TagList != null && (this.TagList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
