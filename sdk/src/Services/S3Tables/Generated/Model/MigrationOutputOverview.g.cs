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
    /// Where a migration writes its reports, and the location of each report once it is written.
    /// </summary>
    public partial class MigrationOutputOverview
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The general purpose bucket that the migration writes every report to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 1024)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property ObjectCompatibilityReport. 
        /// <para>
        /// The object compatibility report: one row for each source object under the source table's
        /// location, with whether the migration includes the object and its most severe finding.
        /// The migration writes it when planning finishes. If planning fails, the report might
        /// not be written.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportOverview ObjectCompatibilityReport { get; set; }

        /// <summary>
        /// Checks to see if the ObjectCompatibilityReport property is set.
        /// </summary>
        internal bool IsSetObjectCompatibilityReport() => this.ObjectCompatibilityReport != null;

        /// <summary>
        /// Gets and sets the property ObjectMigrationReport. 
        /// <para>
        /// The object migration report: one row for each source object that the migration tried
        /// to migrate, with whether it migrated, how it was transformed, and why it failed. The
        /// migration writes it once, when the migration ends. It isn't written if planning fails
        /// or if a sync has nothing to migrate.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportOverview ObjectMigrationReport { get; set; }

        /// <summary>
        /// Checks to see if the ObjectMigrationReport property is set.
        /// </summary>
        internal bool IsSetObjectMigrationReport() => this.ObjectMigrationReport != null;

        /// <summary>
        /// Gets and sets the property TableCompatibilityReport. 
        /// <para>
        /// The table compatibility report: the sample object that the schema is inferred from,
        /// the table-level findings, and one row for each destination column with its type change
        /// and how the migration policies apply to it. The migration writes it when planning
        /// finishes, before any data migrates. If planning fails, the report might not be written.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReportOverview TableCompatibilityReport { get; set; }

        /// <summary>
        /// Checks to see if the TableCompatibilityReport property is set.
        /// </summary>
        internal bool IsSetTableCompatibilityReport() => this.TableCompatibilityReport != null;
    }
}
