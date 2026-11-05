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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Contains details about the global table.
    /// </summary>
    public partial class GlobalTableDescription
    {
        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The creation time of the global table.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property GlobalTableArn. 
        /// <para>
        /// The unique identifier of the global table.
        /// </para>
        /// </summary>
        public string GlobalTableArn { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableArn property is set.
        /// </summary>
        internal bool IsSetGlobalTableArn() => this.GlobalTableArn != null;

        /// <summary>
        /// Gets and sets the property GlobalTableName. 
        /// <para>
        /// The global table name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string GlobalTableName { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableName property is set.
        /// </summary>
        internal bool IsSetGlobalTableName() => this.GlobalTableName != null;

        /// <summary>
        /// Gets and sets the property GlobalTableStatus. 
        /// <para>
        /// The current state of the global table:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> - The global table is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> - The global table is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - The global table is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> - The global table is ready for use.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public GlobalTableStatus GlobalTableStatus { get; set; }

        /// <summary>
        /// Checks to see if the GlobalTableStatus property is set.
        /// </summary>
        internal bool IsSetGlobalTableStatus() => this.GlobalTableStatus != null;

        /// <summary>
        /// Gets and sets the property ReplicationGroup. 
        /// <para>
        /// The Regions where the global table has replicas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReplicaDescription> ReplicationGroup { get; set; } = AWSConfigs.InitializeCollections ? new List<ReplicaDescription>() : null;

        /// <summary>
        /// Checks to see if the ReplicationGroup property is set.
        /// </summary>
        internal bool IsSetReplicationGroup() => this.ReplicationGroup != null && (this.ReplicationGroup.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
