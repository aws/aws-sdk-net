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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
    /// Contains details about the snapshot management settings for an Iceberg table. The
    /// oldest snapshot expires when its age exceeds the <c>maxSnapshotAgeHours</c> and the
    /// total number of snapshots exceeds the value for the minimum number of snapshots to
    /// keep <c>minSnapshotsToKeep</c>.
    /// </summary>
    public partial class IcebergSnapshotManagementSettings
    {
        private int? _maxSnapshotAgeHours;
        private int? _minSnapshotsToKeep;

        /// <summary>
        /// Gets and sets the property MaxSnapshotAgeHours. 
        /// <para>
        /// The maximum age of a snapshot before it can be expired.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? MaxSnapshotAgeHours
        {
            get { return this._maxSnapshotAgeHours; }
            set { this._maxSnapshotAgeHours = value; }
        }

        // Check to see if MaxSnapshotAgeHours property is set
        internal bool IsSetMaxSnapshotAgeHours()
        {
            return this._maxSnapshotAgeHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSnapshotsToKeep. 
        /// <para>
        /// The minimum number of snapshots to keep.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int? MinSnapshotsToKeep
        {
            get { return this._minSnapshotsToKeep; }
            set { this._minSnapshotsToKeep = value; }
        }

        // Check to see if MinSnapshotsToKeep property is set
        internal bool IsSetMinSnapshotsToKeep()
        {
            return this._minSnapshotsToKeep.HasValue; 
        }

    }
}