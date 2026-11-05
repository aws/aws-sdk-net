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
    /// The snapshot management settings that a migration applies to the destination table.
    /// </summary>
    public partial class MigrationSnapshotManagementSettings
    {
        /// <summary>
        /// Gets and sets the property MaxSnapshotAgeHours. 
        /// <para>
        /// The maximum age, in hours, of a snapshot before it can be expired. The default is
        /// 120.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2147483647)]
        public int? MaxSnapshotAgeHours { get; set; }

        /// <summary>
        /// Checks to see if the MaxSnapshotAgeHours property is set.
        /// </summary>
        internal bool IsSetMaxSnapshotAgeHours() => this.MaxSnapshotAgeHours.HasValue;

        /// <summary>
        /// Gets and sets the property MinSnapshotsToKeep. 
        /// <para>
        /// The minimum number of snapshots to keep. The value must be 3 or more. The default
        /// is 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3)]
        public int? MinSnapshotsToKeep { get; set; }

        /// <summary>
        /// Checks to see if the MinSnapshotsToKeep property is set.
        /// </summary>
        internal bool IsSetMinSnapshotsToKeep() => this.MinSnapshotsToKeep.HasValue;
    }
}
