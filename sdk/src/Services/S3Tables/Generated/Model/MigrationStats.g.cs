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
    /// The number of source objects that migrated, failed or are pending. For a sync, the
    /// counts cover every object of the table after the sync, including objects that earlier
    /// migrations migrated. The counts are set when planning finishes and updated when the
    /// migration ends.
    /// </summary>
    public partial class MigrationStats
    {
        /// <summary>
        /// Gets and sets the property ObjectsFailedMigration. 
        /// <para>
        /// The number of source objects that didn't migrate, because they failed or because another
        /// object, such as an object in the same partition, failed. The object migration report
        /// lists the cause for each object.
        /// </para>
        /// </summary>
        public long? ObjectsFailedMigration { get; set; }

        /// <summary>
        /// Checks to see if the ObjectsFailedMigration property is set.
        /// </summary>
        internal bool IsSetObjectsFailedMigration() => this.ObjectsFailedMigration.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectsMigrated. 
        /// <para>
        /// The number of source objects whose data the migration wrote to the destination table.
        /// Migrated data can be queried after the migration commits it. If the migration fails
        /// or is cancelled, some migrated objects might not be committed.
        /// </para>
        /// </summary>
        public long? ObjectsMigrated { get; set; }

        /// <summary>
        /// Checks to see if the ObjectsMigrated property is set.
        /// </summary>
        internal bool IsSetObjectsMigrated() => this.ObjectsMigrated.HasValue;

        /// <summary>
        /// Gets and sets the property ObjectsPendingMigration. 
        /// <para>
        /// The number of source objects that haven't migrated or failed yet. When a migration
        /// fails or is cancelled, these are the objects that it didn't migrate.
        /// </para>
        /// </summary>
        public long? ObjectsPendingMigration { get; set; }

        /// <summary>
        /// Checks to see if the ObjectsPendingMigration property is set.
        /// </summary>
        internal bool IsSetObjectsPendingMigration() => this.ObjectsPendingMigration.HasValue;
    }
}
