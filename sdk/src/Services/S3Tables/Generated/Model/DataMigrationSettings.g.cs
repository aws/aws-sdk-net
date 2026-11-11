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
    /// The maintenance settings and migration policies for the destination table.
    /// </summary>
    public partial class DataMigrationSettings
    {
        /// <summary>
        /// Gets and sets the property MaintenanceSettings. 
        /// <para>
        /// The maintenance settings for the destination table. The migration applies them when
        /// it creates the table: snapshot management starts then, and compaction starts after
        /// you complete the migration. If you don't specify a setting, the migration uses its
        /// default: a target file size of 512 MB, the binpack compaction strategy, at least 3
        /// snapshots, and a maximum snapshot age of 120 hours. Unreferenced file removal follows
        /// the table bucket's configuration after you complete the migration.
        /// </para>
        /// </summary>
        public MaintenanceSettings MaintenanceSettings { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceSettings property is set.
        /// </summary>
        internal bool IsSetMaintenanceSettings() => this.MaintenanceSettings != null;

        /// <summary>
        /// Gets and sets the property MigrationPolicies. 
        /// <para>
        /// The policies for source data that doesn't fit the destination schema.
        /// </para>
        /// </summary>
        public MigrationPolicies MigrationPolicies { get; set; }

        /// <summary>
        /// Checks to see if the MigrationPolicies property is set.
        /// </summary>
        internal bool IsSetMigrationPolicies() => this.MigrationPolicies != null;
    }
}
