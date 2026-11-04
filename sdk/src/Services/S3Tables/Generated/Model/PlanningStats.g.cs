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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Statistics about the source and the partitions in a migration.
    /// </summary>
    public partial class PlanningStats
    {
        /// <summary>
        /// Gets and sets the property ObjectsPlanned. 
        /// <para>
        /// The number of source objects in the migration. For a start, these are the data files
        /// in the Amazon Web Services Glue table's partitions, or under the table's location
        /// if the table isn't partitioned. For a sync, these are all the data files of the table
        /// after the sync, including files that earlier migrations migrated.
        /// </para>
        /// </summary>
        public long? ObjectsPlanned { get; set; }

        /// <summary>
        /// Checks to see if the ObjectsPlanned property is set.
        /// </summary>
        internal bool IsSetObjectsPlanned() => this.ObjectsPlanned.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectsScanned. 
        /// <para>
        /// The number of source objects that the migration found under the source table's location,
        /// whether or not it migrates them. The object compatibility report has one row for each.
        /// </para>
        /// </summary>
        public long? ObjectsScanned { get; set; }

        /// <summary>
        /// Checks to see if the ObjectsScanned property is set.
        /// </summary>
        internal bool IsSetObjectsScanned() => this.ObjectsScanned.HasValue;

        /// <summary>
        /// Gets and sets the property PartitionCount. 
        /// <para>
        /// The number of partitions in the destination table after this migration, or 0 if the
        /// source table isn't partitioned. This value is returned when planning produces a valid
        /// plan.
        /// </para>
        /// </summary>
        public long? PartitionCount { get; set; }

        /// <summary>
        /// Checks to see if the PartitionCount property is set.
        /// </summary>
        internal bool IsSetPartitionCount() => this.PartitionCount.HasValue;
    }
}
